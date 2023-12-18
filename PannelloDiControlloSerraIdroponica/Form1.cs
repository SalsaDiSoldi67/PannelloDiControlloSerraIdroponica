using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PannelloDiControlloSerraIdroponica
{
    public partial class PANNELLO_DI_CONTROLLO_SERRA : Form
    {

        /*
         * 
         * VARIABILI IMPORTANTI GLOBALI
         * 
         */

        // VARIABILI BOOLEANE PER GESTIRE IL CONTROLLO DI ACCENSIONE O SPEGNIMENTO DEI BOTTONI
        bool onoff_Luce = false;
        bool onoff_Ventialtore = false;
        bool onoff_Pump = false;
        bool onoff_Sens = false;

        string dataFromSerialIN; // DATI RICEVUTI DA ARDUINO

        string[] ports;// ARRAY CHE CONTERRA' I NOMI DELLE PORTE SERIALI

        // VARIABILE FASE RICEZIONE DATI DEI SENSORI DA ARDUINO

        bool varSensDataRec = false;

        int varLetDataSens;

        /*
         * 
         * FINE VARIABILI IMPORTANTI GLOBALI
         * 
         */
        public PANNELLO_DI_CONTROLLO_SERRA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)// EVENTO RICHIAMATO ALL'AVVIO DEL PANNELLO DI CONTROLLO
        {
            ports = SerialPort.GetPortNames();// OTTIENE I NOMI DELLE PORTE SERIALI
            foreach (string porte in ports)// PRENDE I NOMI DELLE PORTE E LI INSERISCE NELLA COMBOBOX
            {
                comboBoxSerialPortsName.Items.Add(porte);
            }
            // PASSAGGIO CHE RENDE SOLO LEGGIBILI TUTTE LE TEXTBOX E RICHTEXT
            textBoxSensoreUmidita.ReadOnly = true;
            textBoxTemperatura.ReadOnly = true;
            textBoxLuce.ReadOnly = true;
            textBoxLivelloAcqua.ReadOnly = true;
            textBoxTimerLetturaSensori.ReadOnly = true;
            richTextBoxErroriFromSerial.ReadOnly = true;


            notifyIcon.Icon = SystemIcons.Information;// ATTRIBUISCE L'ICONA STANDARD DI SISTEMA ALLA NOTIFYICON 

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)// EVENTO RICHIAMATO ALLA CHIUSURA DEL PANNELLO DI CONTROLLO
        {
            serialPortArduino.Close();// CHIUDE LA PORTA SERIALE
        }

        private void serialPortArduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // EVENTO CHE VIENE ESEGUITO QUANDO CI SONO DATI IN ARRIVO SULLA SERIALE
            dataFromSerialIN = serialPortArduino.ReadExisting();

            dataFromSerialIN.Trim();// DECODIFICA PER PERMETTERE LA COMPARAZIONE
            if (!varSensDataRec)
            {
                if ((dataFromSerialIN != "ALLOFF") && (dataFromSerialIN != "MinP"))
                {
                    //MessageBox.Show(dataFromSerialIN); // TEST
                    MessageBox.Show("Azione eseguita ", "ACTION EVENT", MessageBoxButtons.OK);// MESSAGEBOX CHE MOSTRA L'ESECUZIONE DEL COMANDO APPENA ESEGUITO
                    // MODIFICA I BOTTONI E LE LABEL IN BASE ALL'AZIONE ESEGUITA GRAZIE ALLA CONFERMA DI ARDUINO
                    if (dataFromSerialIN == "XSenstrue#")
                    {
                        this.Invoke(new EventHandler(ard_sent_onSens));

                    }
                    else if (dataFromSerialIN == "XSensfalse#")
                    {
                        this.Invoke(new EventHandler(ard_sent_offSens));
                    }

                    else if (dataFromSerialIN == "XLucetrue#")
                    {
                        this.Invoke(new EventHandler(ard_sent_onLuce));

                    }
                    else if (dataFromSerialIN == "XLucefalse#")
                    {
                        this.Invoke(new EventHandler(ard_sent_offLuce));
                    }
                    else if (dataFromSerialIN == "XVenttrue#")
                    {
                        this.Invoke(new EventHandler(ard_sent_onVent));
                    }
                    else if (dataFromSerialIN == "XVentfalse#")
                    {
                        this.Invoke(new EventHandler(ard_sent_offVent));
                    }
                    else if (dataFromSerialIN == "XPumptrue#")
                    {
                        this.Invoke(new EventHandler(ard_sent_onPump));
                    }
                    else if (dataFromSerialIN == "XPumpfalse#")
                    {
                        this.Invoke(new EventHandler(ard_sent_offPump));
                    }
                    else
                    {
                        // RICHTEXT CHE MOSTRA GLI ERRORI PROVENIENTE DA SCRITTURE ERRATE SULLA PORTA SERIALE

                        this.Invoke(new EventHandler(errorRichTexEvent));
                    }

                }// CONTROLLO DEL TIMER , SE SI INIZIA LA FASE DI RICEZIONE DEI DATI DEI SENSORI
                else if (dataFromSerialIN == "MinP")
                {
                    //MessageBox.Show(dataFromSerialIN); // TEST
                    varSensDataRec = true;
                    // CHIAMA LA PRIMA VOLTA IL METODO PER LO SCAMBIO DI DATI PER I SENSORI varLetDataSens = 0
                    this.Invoke(new EventHandler(letturaDatiSens));// CHIAMA IL METODO CHE PERMETTE DI LEGGERE I DATI DEI SENSORI
                }
                else
                {// CONFERMA DA ARDUINO DELLO SPEGNIMENTO FORZATO DI OGNI COMPONENTE
                    MessageBox.Show("TUTTO SPENTO", "SECURITY EVENT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Invoke(new EventHandler(cut_off));

                }
            }
            else
            {
                //MessageBox.Show(dataFromSerialIN); // TEST
                this.Invoke(new EventHandler(letturaDatiSens));// CHIAMA IL METODO CHE PERMETTE DI LEGGERE I DATI DEI SENSORI
            }
        }

        // PARTI ESEGUITE DURANTE LA FASE DI RICEZIONE DATI DEI SENSORI
        private void letturaDatiSens(object sender, EventArgs e)
        {
            if (varLetDataSens == 0)
            {
                varLetDataSens += 1;
                serialPortArduino.Write("X");

                serialPortArduino.Write("SentUm");
                serialPortArduino.Write("#");
                serialPortArduino.Write(Environment.NewLine);

            }
            else if (varLetDataSens == 1)
            {

                textBoxSensoreUmidita.Text = dataFromSerialIN;
                varLetDataSens += 1;
                serialPortArduino.Write("X");

                serialPortArduino.Write("SentTemp");
                serialPortArduino.Write("#");
                serialPortArduino.Write(Environment.NewLine);

            }
            else if (varLetDataSens == 2)
            {
                textBoxTemperatura.Text = dataFromSerialIN + "°C";
                varLetDataSens += 1;
                serialPortArduino.Write("X");

                serialPortArduino.Write("SentLuce");
                serialPortArduino.Write("#");
                serialPortArduino.Write(Environment.NewLine);

            }
            else if (varLetDataSens == 3)
            {
                textBoxLuce.Text = dataFromSerialIN;
                varLetDataSens += 1;
                serialPortArduino.Write("X");

                serialPortArduino.Write("SentLivA");
                serialPortArduino.Write("#");
                serialPortArduino.Write(Environment.NewLine);
            }
            else if (varLetDataSens == 4)
            {
                textBoxLivelloAcqua.Text = dataFromSerialIN;
                varLetDataSens = 0;
                varSensDataRec = false;
            }
        }
        // RICHIAMA GLI EVENTI PER LO SPEGNIMENTO FORZATO
        private void cut_off(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(ard_sent_offSens));
            this.Invoke(new EventHandler(ard_sent_offLuce));
            this.Invoke(new EventHandler(ard_sent_offVent));
            this.Invoke(new EventHandler(ard_sent_offPump));
        }
        // BOTTONE CHE ABILITA O DISABILITA LA COMUNICAZIONE SERIALE
        private void buttonONOFFSeriale_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPortArduino.IsOpen)
                {

                    serialPortArduino.Close();
                    notifyIcon.BalloonTipText = "Chiusura porta seriale";
                    notifyIcon.ShowBalloonTip(1000);// CREA UNA NOTIFICA NELLA SEZIONE DEDICATA PER IL TEMPO DATO TRA PARENTESI
                    buttonONOFFSeriale.Text = "ON";
                    labelAbDisSeriale.Text = "DISABILITATA";
                    labelAbDisSeriale.ForeColor = Color.Red;
                    Thread CloseDown = new Thread(new ThreadStart(serialPortArduino.Dispose));// CREA UN METODO CHE CHIUDE LE RISORSE  -->
                    CloseDown.Start();//-->  NON GESTITE DELLA SERIALE, COSI CHE LA CHIUSURA DELLA PORTA SERIALE NON DIA ERRORI
                }
                else
                {

                    serialPortArduino.PortName = comboBoxSerialPortsName.Text;
                    serialPortArduino.Open();
                    notifyIcon.BalloonTipText = "Apertura porta seriale";
                    notifyIcon.ShowBalloonTip(1000);// CREA UNA NOTIFICA NELLA SEZIONE DEDICATA PER IL TEMPO DATO TRA PARENTESI
                    buttonONOFFSeriale.Text = "OFF";
                    labelAbDisSeriale.Text = "ABILITATA";
                    labelAbDisSeriale.ForeColor = Color.Green;

                }

            }
            catch (Exception error)
            {


                if (error.Message.Equals($"La porta '{serialPortArduino.PortName}' non esiste."))// CONTROLLA L'ERRORE PORTA SERIALE SBAGLIATA
                {
                    MessageBox.Show("COLLEGARE ARDUINO NELLA PORTA SERIALE ADATTA", "ERRORE SERIALE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (error.Message.Equals("PortName non può essere vuoto.\r\nNome parametro: PortName"))
                {
                    MessageBox.Show("SELEZIONARE UNA PORTA NELLA COMBOBOX", "ERRORE SERIALE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show(error.Message);

                }

            }
        }
        private void comboBoxSerialPortsName_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxSerialPortsName.Items.Clear();
            ports = SerialPort.GetPortNames();// OTTIENE I NOMI DELLE PORTE SERIALI
            foreach (string porte in ports)// PRENDE I NOMI DELLE PORTE E LI INSERISCE NELLA COMBOBOX
            {
                comboBoxSerialPortsName.Items.Add(porte);
            }
        }
        // BOTTONE CHE SPEGNE FORZATAMENTE TUTTI GLI ATTUATORI E I SENSORI SU ARDUINO
        private void buttonSecurityAllOFF_Click(object sender, EventArgs e)
        {
            try
            {

                serialPortArduino.Write("X");

                serialPortArduino.Write("OFFALL");
                serialPortArduino.Write("#");
                serialPortArduino.Write(Environment.NewLine);

            }
            catch (Exception error)
            {
                if (error.Message.Equals("Porta chiusa."))
                {

                    MessageBox.Show("PREMERE IL BOTTONE PER AVVIARE LA CONNESSIONE SERIALE", "ERRORE SERIALE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show(error.Message);

                }

            }
        }
        // BOTTONE CHE INVIA AD ARDUINO IL COMANDO PER LO SPEGNIMENTO O L'ACCENSIONE DELLA LUCE 
        private void buttonONOFFLUCE_Click(object sender, EventArgs e)
        {
            try
            {
                if (onoff_Luce)
                {

                    serialPortArduino.Write("X");

                    serialPortArduino.Write("OFFLuce");
                    serialPortArduino.Write("#");
                    serialPortArduino.Write(Environment.NewLine);


                }
                else
                {

                    serialPortArduino.Write("X");

                    serialPortArduino.Write("ONLuce");
                    serialPortArduino.Write("#");
                    serialPortArduino.Write(Environment.NewLine);

                }

            }
            catch (Exception error)
            {

                if (error.Message.Equals("Porta chiusa."))
                {

                    MessageBox.Show("PREMERE IL BOTTONE PER AVVIARE LA CONNESSIONE SERIALE", "ERRORE SERIALE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show(error.Message);

                }
            }
        }
        // BOTTONE CHE INVIA AD ARDUINO IL COMANDO PER LO SPEGNIMENTO O L'ACCENSIONE DEL VENTILATORE
        private void buttonONOFFVentilatore_Click(object sender, EventArgs e)
        {
            try
            {
                if (onoff_Ventialtore)
                {

                    serialPortArduino.Write("X");

                    serialPortArduino.Write("OFFVent");
                    serialPortArduino.Write("#");
                    serialPortArduino.Write(Environment.NewLine);


                }
                else
                {

                    serialPortArduino.Write("X");

                    serialPortArduino.Write("ONVent");
                    serialPortArduino.Write("#");
                    serialPortArduino.Write(Environment.NewLine);

                }

            }
            catch (Exception error)
            {

                if (error.Message.Equals("Porta chiusa."))
                {

                    MessageBox.Show("PREMERE IL BOTTONE PER AVVIARE LA CONNESSIONE SERIALE", "ERRORE SERIALE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show(error.Message);

                }
            }

        }
        // BOTTONE CHE INVIA AD ARDUINO IL COMANDO PER LO SPEGNIMENTO O L'ACCENSIONE DELLA POMPA
        private void buttonPompaAcqua_Click(object sender, EventArgs e)
        {
            try
            {
                if (onoff_Pump)
                {

                    serialPortArduino.Write("X");

                    serialPortArduino.Write("OFFPump");
                    serialPortArduino.Write("#");
                    serialPortArduino.Write(Environment.NewLine);


                }
                else
                {

                    serialPortArduino.Write("X");

                    serialPortArduino.Write("ONPump");
                    serialPortArduino.Write("#");
                    serialPortArduino.Write(Environment.NewLine);

                }

            }
            catch (Exception error)
            {

                if (error.Message.Equals("Porta chiusa."))
                {

                    MessageBox.Show("PREMERE IL BOTTONE PER AVVIARE LA CONNESSIONE SERIALE", "ERRORE SERIALE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show(error.Message);

                }
            }
        }
        // BOTTONE CHE INVIA AD ARDUINO IL COMANDO PER LO SPEGNIMENTO O L'ACCENSIONE DELLA LETTURA DEI SENSORI
        private void buttonLetturaSensori_Click(object sender, EventArgs e)
        {
            try
            {
                if (onoff_Sens)
                {

                    serialPortArduino.Write("X");

                    serialPortArduino.Write("OFFSens");
                    serialPortArduino.Write("#");
                    serialPortArduino.Write(Environment.NewLine);


                }
                else
                {

                    serialPortArduino.Write("X");

                    serialPortArduino.Write("ONSens");
                    serialPortArduino.Write("#");
                    serialPortArduino.Write(Environment.NewLine);

                }

            }
            catch (Exception error)
            {

                if (error.Message.Equals("Porta chiusa."))
                {

                    MessageBox.Show("PREMERE IL BOTTONE PER AVVIARE LA CONNESSIONE SERIALE", "ERRORE SERIALE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show(error.Message);

                }
            }
        }// RICHTEXTBOX CHE MOSTRA GLI ERRORI PROVENIENI DALLA SERIALE
        private void errorRichTexEvent(object sender, EventArgs e)
        {
            richTextBoxErroriFromSerial.Text += dataFromSerialIN;// AGGIUNGE STRINGHE ALLA RICHTEXT
            richTextBoxErroriFromSerial.Text += "\r\n";
        }
        // EVENTI RICHIAMATI
        private void ard_sent_onLuce(object sender, EventArgs e)
        {

            buttonONOFFLUCE.Text = "OFF";
            labelONOFFLUCE.Text = "ACCESA";
            labelONOFFLUCE.ForeColor = Color.Green;
            onoff_Luce = true;
        }

        private void ard_sent_offLuce(object sender, EventArgs e)
        {
            buttonONOFFLUCE.Text = "ON";
            labelONOFFLUCE.Text = "SPENTA";
            labelONOFFLUCE.ForeColor = Color.Red;
            onoff_Luce = false;

        }
        private void ard_sent_onVent(object sender, EventArgs e)
        {
            buttonONOFFVentilatore.Text = "OFF";
            labelONOFFVentilatore.Text = "ACCESO";
            labelONOFFVentilatore.ForeColor = Color.Green;
            onoff_Ventialtore = true;
        }
        private void ard_sent_offVent(object sender, EventArgs e)
        {
            buttonONOFFVentilatore.Text = "ON";
            labelONOFFVentilatore.Text = "SPENTO";
            labelONOFFVentilatore.ForeColor = Color.Red;
            onoff_Ventialtore = false;
        }
        private void ard_sent_onPump(object sender, EventArgs e)
        {
            buttonPompaAcqua.Text = "OFF";
            labelPompaAcqua.Text = "ABILITATA";
            labelPompaAcqua.ForeColor = Color.Green;
            onoff_Pump = true;
        }
        private void ard_sent_offPump(object sender, EventArgs e)
        {
            buttonPompaAcqua.Text = "ON";
            labelPompaAcqua.Text = "DISABILITATA";
            labelPompaAcqua.ForeColor = Color.Red;
            onoff_Pump = false;
        }
        private void ard_sent_onSens(object sender, EventArgs e)
        {
            buttonLetturaSensori.Text = "OFF";
            textBoxTimerLetturaSensori.Text = "DATI IN ARRIVO";
            textBoxTimerLetturaSensori.ForeColor = Color.Green;
            onoff_Sens = true;
        }

        private void ard_sent_offSens(object sender, EventArgs e)
        {
            buttonLetturaSensori.Text = "ON";
            textBoxTimerLetturaSensori.Text = "LETTURA DISATTIVATA";
            textBoxTimerLetturaSensori.ForeColor = Color.Red;
            onoff_Sens = false;
        }
        // PARTE DELLA RICHTEXTBOX
        private void richTextBoxErroriFromSerial_TextChanged(object sender, EventArgs e)
        {
            // FANNO IN MODO CHE LA RICHTEXT SCROLLI I DATI QUANDO SI RIEMPIE
            richTextBoxErroriFromSerial.SelectionStart = richTextBoxErroriFromSerial.Text.Length;
            richTextBoxErroriFromSerial.ScrollToCaret();
        }

        private void timer_Tick(object sender, EventArgs e)
        {


        }

        private void textBoxSensoreUmidita_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTemperatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSerialPortsName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
