namespace PannelloDiControlloSerraIdroponica
{
    partial class PANNELLO_DI_CONTROLLO_SERRA
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PANNELLO_DI_CONTROLLO_SERRA));
            this.groupBoxCollegamentoSeriale = new System.Windows.Forms.GroupBox();
            this.comboBoxSerialPortsName = new System.Windows.Forms.ComboBox();
            this.labelAbDisSeriale = new System.Windows.Forms.Label();
            this.buttonONOFFSeriale = new System.Windows.Forms.Button();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxAttuatori = new System.Windows.Forms.GroupBox();
            this.groupBoxPompaAcqua = new System.Windows.Forms.GroupBox();
            this.labelPompaAcqua = new System.Windows.Forms.Label();
            this.buttonPompaAcqua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSecurityAllOFF = new System.Windows.Forms.Button();
            this.groupBoxControlliVentilatore = new System.Windows.Forms.GroupBox();
            this.labelONOFFVentilatore = new System.Windows.Forms.Label();
            this.buttonONOFFVentilatore = new System.Windows.Forms.Button();
            this.groupBoxControlliLuce = new System.Windows.Forms.GroupBox();
            this.buttonONOFFLUCE = new System.Windows.Forms.Button();
            this.labelONOFFLUCE = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxSensoreUmidita = new System.Windows.Forms.TextBox();
            this.textBoxTemperatura = new System.Windows.Forms.TextBox();
            this.textBoxLuce = new System.Windows.Forms.TextBox();
            this.textBoxLivelloAcqua = new System.Windows.Forms.TextBox();
            this.buttonLetturaSensori = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxSensori = new System.Windows.Forms.GroupBox();
            this.groupBoxSensoriLivelloAcquaQuantitaLuce = new System.Windows.Forms.GroupBox();
            this.labelLivelloAcqua = new System.Windows.Forms.Label();
            this.labelLuce = new System.Windows.Forms.Label();
            this.groupBoxSensoreUmiditaTemperatura = new System.Windows.Forms.GroupBox();
            this.labelUmidita = new System.Windows.Forms.Label();
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.groupBoxONOFFLetturaSensori = new System.Windows.Forms.GroupBox();
            this.textBoxTimerLetturaSensori = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxErroriFromSerial = new System.Windows.Forms.RichTextBox();
            this.groupBoxCollegamentoSeriale.SuspendLayout();
            this.groupBoxAttuatori.SuspendLayout();
            this.groupBoxPompaAcqua.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxControlliVentilatore.SuspendLayout();
            this.groupBoxControlliLuce.SuspendLayout();
            this.groupBoxSensori.SuspendLayout();
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.SuspendLayout();
            this.groupBoxSensoreUmiditaTemperatura.SuspendLayout();
            this.groupBoxONOFFLetturaSensori.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCollegamentoSeriale
            // 
            this.groupBoxCollegamentoSeriale.Controls.Add(this.comboBoxSerialPortsName);
            this.groupBoxCollegamentoSeriale.Controls.Add(this.labelAbDisSeriale);
            this.groupBoxCollegamentoSeriale.Controls.Add(this.buttonONOFFSeriale);
            this.groupBoxCollegamentoSeriale.Location = new System.Drawing.Point(16, 30);
            this.groupBoxCollegamentoSeriale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCollegamentoSeriale.Name = "groupBoxCollegamentoSeriale";
            this.groupBoxCollegamentoSeriale.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCollegamentoSeriale.Size = new System.Drawing.Size(285, 117);
            this.groupBoxCollegamentoSeriale.TabIndex = 0;
            this.groupBoxCollegamentoSeriale.TabStop = false;
            this.groupBoxCollegamentoSeriale.Text = "COLLEGAMENTO CON LA SERIALE";
            // 
            // comboBoxSerialPortsName
            // 
            this.comboBoxSerialPortsName.FormattingEnabled = true;
            this.comboBoxSerialPortsName.Location = new System.Drawing.Point(22, 72);
            this.comboBoxSerialPortsName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxSerialPortsName.Name = "comboBoxSerialPortsName";
            this.comboBoxSerialPortsName.Size = new System.Drawing.Size(140, 21);
            this.comboBoxSerialPortsName.TabIndex = 2;
            this.toolTip.SetToolTip(this.comboBoxSerialPortsName, "COMBOBOX CHE CI PERMETTE DI SELEZIONARE LA PORTA SERIALE DA UTILIZZARE");
            this.comboBoxSerialPortsName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortsName_SelectedIndexChanged);
            this.comboBoxSerialPortsName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxSerialPortsName_MouseClick);
            // 
            // labelAbDisSeriale
            // 
            this.labelAbDisSeriale.AutoSize = true;
            this.labelAbDisSeriale.ForeColor = System.Drawing.Color.Red;
            this.labelAbDisSeriale.Location = new System.Drawing.Point(50, 32);
            this.labelAbDisSeriale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAbDisSeriale.Name = "labelAbDisSeriale";
            this.labelAbDisSeriale.Size = new System.Drawing.Size(77, 13);
            this.labelAbDisSeriale.TabIndex = 1;
            this.labelAbDisSeriale.Text = "DISABILITATA";
            // 
            // buttonONOFFSeriale
            // 
            this.buttonONOFFSeriale.Location = new System.Drawing.Point(180, 27);
            this.buttonONOFFSeriale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonONOFFSeriale.Name = "buttonONOFFSeriale";
            this.buttonONOFFSeriale.Size = new System.Drawing.Size(88, 23);
            this.buttonONOFFSeriale.TabIndex = 1;
            this.buttonONOFFSeriale.Text = "ON";
            this.toolTip.SetToolTip(this.buttonONOFFSeriale, "BOTTONE CHE GESTISCE LA CONNESSIONE DELLA PORTA SERIALE (ATTIVA,DISATTIVA)");
            this.buttonONOFFSeriale.UseVisualStyleBackColor = true;
            this.buttonONOFFSeriale.Click += new System.EventHandler(this.buttonONOFFSeriale_Click);
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.BaudRate = 115200;
            this.serialPortArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortArduino_DataReceived);
            // 
            // groupBoxAttuatori
            // 
            this.groupBoxAttuatori.Controls.Add(this.groupBoxPompaAcqua);
            this.groupBoxAttuatori.Controls.Add(this.groupBox1);
            this.groupBoxAttuatori.Controls.Add(this.groupBoxControlliVentilatore);
            this.groupBoxAttuatori.Controls.Add(this.groupBoxControlliLuce);
            this.groupBoxAttuatori.Location = new System.Drawing.Point(639, 30);
            this.groupBoxAttuatori.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxAttuatori.Name = "groupBoxAttuatori";
            this.groupBoxAttuatori.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxAttuatori.Size = new System.Drawing.Size(281, 356);
            this.groupBoxAttuatori.TabIndex = 1;
            this.groupBoxAttuatori.TabStop = false;
            this.groupBoxAttuatori.Text = "ATTUATORI";
            // 
            // groupBoxPompaAcqua
            // 
            this.groupBoxPompaAcqua.Controls.Add(this.labelPompaAcqua);
            this.groupBoxPompaAcqua.Controls.Add(this.buttonPompaAcqua);
            this.groupBoxPompaAcqua.Location = new System.Drawing.Point(21, 193);
            this.groupBoxPompaAcqua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxPompaAcqua.Name = "groupBoxPompaAcqua";
            this.groupBoxPompaAcqua.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxPompaAcqua.Size = new System.Drawing.Size(233, 77);
            this.groupBoxPompaAcqua.TabIndex = 3;
            this.groupBoxPompaAcqua.TabStop = false;
            this.groupBoxPompaAcqua.Text = "POMPA DELL\'ACQUA";
            // 
            // labelPompaAcqua
            // 
            this.labelPompaAcqua.AutoSize = true;
            this.labelPompaAcqua.ForeColor = System.Drawing.Color.Red;
            this.labelPompaAcqua.Location = new System.Drawing.Point(24, 38);
            this.labelPompaAcqua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPompaAcqua.Name = "labelPompaAcqua";
            this.labelPompaAcqua.Size = new System.Drawing.Size(77, 13);
            this.labelPompaAcqua.TabIndex = 4;
            this.labelPompaAcqua.Text = "DISABILITATA";
            // 
            // buttonPompaAcqua
            // 
            this.buttonPompaAcqua.Location = new System.Drawing.Point(117, 33);
            this.buttonPompaAcqua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPompaAcqua.Name = "buttonPompaAcqua";
            this.buttonPompaAcqua.Size = new System.Drawing.Size(88, 23);
            this.buttonPompaAcqua.TabIndex = 3;
            this.buttonPompaAcqua.Text = "ON";
            this.toolTip.SetToolTip(this.buttonPompaAcqua, "BOTTONE CHE GESTISCE L\'ACCENSIONE OPPURE LO SPEGNIMENTO DELLA POMPA DELL\'ACQUA");
            this.buttonPompaAcqua.UseVisualStyleBackColor = true;
            this.buttonPompaAcqua.Click += new System.EventHandler(this.buttonPompaAcqua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSecurityAllOFF);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(100, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(154, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SECURITY BUTTON";
            // 
            // buttonSecurityAllOFF
            // 
            this.buttonSecurityAllOFF.BackColor = System.Drawing.Color.Transparent;
            this.buttonSecurityAllOFF.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSecurityAllOFF.ForeColor = System.Drawing.Color.Red;
            this.buttonSecurityAllOFF.Location = new System.Drawing.Point(37, 20);
            this.buttonSecurityAllOFF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSecurityAllOFF.Name = "buttonSecurityAllOFF";
            this.buttonSecurityAllOFF.Size = new System.Drawing.Size(88, 23);
            this.buttonSecurityAllOFF.TabIndex = 3;
            this.buttonSecurityAllOFF.Text = "OFF ALL";
            this.toolTip.SetToolTip(this.buttonSecurityAllOFF, "BOTTONE CHE SPEGNE OGNI ATTUATORE E SENSORE DI ARDUINO");
            this.buttonSecurityAllOFF.UseVisualStyleBackColor = false;
            this.buttonSecurityAllOFF.Click += new System.EventHandler(this.buttonSecurityAllOFF_Click);
            // 
            // groupBoxControlliVentilatore
            // 
            this.groupBoxControlliVentilatore.Controls.Add(this.labelONOFFVentilatore);
            this.groupBoxControlliVentilatore.Controls.Add(this.buttonONOFFVentilatore);
            this.groupBoxControlliVentilatore.Location = new System.Drawing.Point(21, 104);
            this.groupBoxControlliVentilatore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxControlliVentilatore.Name = "groupBoxControlliVentilatore";
            this.groupBoxControlliVentilatore.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxControlliVentilatore.Size = new System.Drawing.Size(233, 74);
            this.groupBoxControlliVentilatore.TabIndex = 2;
            this.groupBoxControlliVentilatore.TabStop = false;
            this.groupBoxControlliVentilatore.Text = "CONTROLLI VENTILATORE";
            // 
            // labelONOFFVentilatore
            // 
            this.labelONOFFVentilatore.AutoSize = true;
            this.labelONOFFVentilatore.ForeColor = System.Drawing.Color.Red;
            this.labelONOFFVentilatore.Location = new System.Drawing.Point(23, 39);
            this.labelONOFFVentilatore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelONOFFVentilatore.Name = "labelONOFFVentilatore";
            this.labelONOFFVentilatore.Size = new System.Drawing.Size(49, 13);
            this.labelONOFFVentilatore.TabIndex = 3;
            this.labelONOFFVentilatore.Text = "SPENTO";
            // 
            // buttonONOFFVentilatore
            // 
            this.buttonONOFFVentilatore.Location = new System.Drawing.Point(117, 34);
            this.buttonONOFFVentilatore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonONOFFVentilatore.Name = "buttonONOFFVentilatore";
            this.buttonONOFFVentilatore.Size = new System.Drawing.Size(88, 23);
            this.buttonONOFFVentilatore.TabIndex = 2;
            this.buttonONOFFVentilatore.Text = "ON";
            this.toolTip.SetToolTip(this.buttonONOFFVentilatore, "BOTTONE CHE GESTISCE L\'ACCENSIONE OPPURE LO SPEGNIMENTO DEL VENTILATORE");
            this.buttonONOFFVentilatore.UseVisualStyleBackColor = true;
            this.buttonONOFFVentilatore.Click += new System.EventHandler(this.buttonONOFFVentilatore_Click);
            // 
            // groupBoxControlliLuce
            // 
            this.groupBoxControlliLuce.Controls.Add(this.buttonONOFFLUCE);
            this.groupBoxControlliLuce.Controls.Add(this.labelONOFFLUCE);
            this.groupBoxControlliLuce.Location = new System.Drawing.Point(21, 32);
            this.groupBoxControlliLuce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxControlliLuce.Name = "groupBoxControlliLuce";
            this.groupBoxControlliLuce.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxControlliLuce.Size = new System.Drawing.Size(233, 66);
            this.groupBoxControlliLuce.TabIndex = 2;
            this.groupBoxControlliLuce.TabStop = false;
            this.groupBoxControlliLuce.Text = "CONTROLLI LUCE";
            // 
            // buttonONOFFLUCE
            // 
            this.buttonONOFFLUCE.Location = new System.Drawing.Point(117, 24);
            this.buttonONOFFLUCE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonONOFFLUCE.Name = "buttonONOFFLUCE";
            this.buttonONOFFLUCE.Size = new System.Drawing.Size(88, 23);
            this.buttonONOFFLUCE.TabIndex = 2;
            this.buttonONOFFLUCE.Text = "ON";
            this.toolTip.SetToolTip(this.buttonONOFFLUCE, "BOTTONE CHE GESTISCE L\'ACCENSIONE OPPURE LO SPEGNIMENTO DELLA LAMPADA");
            this.buttonONOFFLUCE.UseVisualStyleBackColor = true;
            this.buttonONOFFLUCE.Click += new System.EventHandler(this.buttonONOFFLUCE_Click);
            // 
            // labelONOFFLUCE
            // 
            this.labelONOFFLUCE.AutoSize = true;
            this.labelONOFFLUCE.ForeColor = System.Drawing.Color.Red;
            this.labelONOFFLUCE.Location = new System.Drawing.Point(24, 29);
            this.labelONOFFLUCE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelONOFFLUCE.Name = "labelONOFFLUCE";
            this.labelONOFFLUCE.Size = new System.Drawing.Size(49, 13);
            this.labelONOFFLUCE.TabIndex = 2;
            this.labelONOFFLUCE.Text = "SPENTA";
            // 
            // textBoxSensoreUmidita
            // 
            this.textBoxSensoreUmidita.Location = new System.Drawing.Point(122, 30);
            this.textBoxSensoreUmidita.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSensoreUmidita.Name = "textBoxSensoreUmidita";
            this.textBoxSensoreUmidita.Size = new System.Drawing.Size(131, 21);
            this.textBoxSensoreUmidita.TabIndex = 2;
            this.toolTip.SetToolTip(this.textBoxSensoreUmidita, "RESTITUISCE I VALORI RICEVUTI DAL SENSORE DI UMIDITA\'");
            this.textBoxSensoreUmidita.TextChanged += new System.EventHandler(this.textBoxSensoreUmidita_TextChanged);
            // 
            // textBoxTemperatura
            // 
            this.textBoxTemperatura.Location = new System.Drawing.Point(122, 61);
            this.textBoxTemperatura.Name = "textBoxTemperatura";
            this.textBoxTemperatura.Size = new System.Drawing.Size(132, 21);
            this.textBoxTemperatura.TabIndex = 5;
            this.toolTip.SetToolTip(this.textBoxTemperatura, "RESTITUISCE I VALORI RICEVUTI DAL SENSORE DI TEMPERATURA");
            this.textBoxTemperatura.TextChanged += new System.EventHandler(this.textBoxTemperatura_TextChanged);
            // 
            // textBoxLuce
            // 
            this.textBoxLuce.Location = new System.Drawing.Point(122, 33);
            this.textBoxLuce.Name = "textBoxLuce";
            this.textBoxLuce.Size = new System.Drawing.Size(132, 21);
            this.textBoxLuce.TabIndex = 4;
            this.toolTip.SetToolTip(this.textBoxLuce, "RESTITUISCE I VALORI RICEVUTI DAL FOTO RESISTORE");
            // 
            // textBoxLivelloAcqua
            // 
            this.textBoxLivelloAcqua.Location = new System.Drawing.Point(122, 62);
            this.textBoxLivelloAcqua.Name = "textBoxLivelloAcqua";
            this.textBoxLivelloAcqua.Size = new System.Drawing.Size(131, 21);
            this.textBoxLivelloAcqua.TabIndex = 4;
            this.toolTip.SetToolTip(this.textBoxLivelloAcqua, "RESTITUISCE I VALORI RICEVUTI DAL SENSORE DEL LIVELLO DELL\'ACQUA");
            // 
            // buttonLetturaSensori
            // 
            this.buttonLetturaSensori.Location = new System.Drawing.Point(20, 30);
            this.buttonLetturaSensori.Name = "buttonLetturaSensori";
            this.buttonLetturaSensori.Size = new System.Drawing.Size(75, 23);
            this.buttonLetturaSensori.TabIndex = 4;
            this.buttonLetturaSensori.Text = "ON";
            this.toolTip.SetToolTip(this.buttonLetturaSensori, "BOTTONE CHE ABILITA LA LETTURA DEI DATI PROVENIENTI DAI SENSORI");
            this.buttonLetturaSensori.UseVisualStyleBackColor = true;
            this.buttonLetturaSensori.Click += new System.EventHandler(this.buttonLetturaSensori_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBoxSensori
            // 
            this.groupBoxSensori.Controls.Add(this.groupBoxSensoriLivelloAcquaQuantitaLuce);
            this.groupBoxSensori.Controls.Add(this.groupBoxSensoreUmiditaTemperatura);
            this.groupBoxSensori.Controls.Add(this.groupBoxONOFFLetturaSensori);
            this.groupBoxSensori.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSensori.Location = new System.Drawing.Point(327, 30);
            this.groupBoxSensori.Name = "groupBoxSensori";
            this.groupBoxSensori.Size = new System.Drawing.Size(295, 356);
            this.groupBoxSensori.TabIndex = 3;
            this.groupBoxSensori.TabStop = false;
            this.groupBoxSensori.Text = "SENSORI";
            // 
            // groupBoxSensoriLivelloAcquaQuantitaLuce
            // 
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.Controls.Add(this.textBoxLivelloAcqua);
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.Controls.Add(this.textBoxLuce);
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.Controls.Add(this.labelLivelloAcqua);
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.Controls.Add(this.labelLuce);
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.Location = new System.Drawing.Point(17, 249);
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.Name = "groupBoxSensoriLivelloAcquaQuantitaLuce";
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.Size = new System.Drawing.Size(260, 101);
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.TabIndex = 4;
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.TabStop = false;
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.Text = "QUANTITA\' LUCE E LIVELLO DELL\'ACQUA";
            // 
            // labelLivelloAcqua
            // 
            this.labelLivelloAcqua.AutoSize = true;
            this.labelLivelloAcqua.Location = new System.Drawing.Point(15, 65);
            this.labelLivelloAcqua.Name = "labelLivelloAcqua";
            this.labelLivelloAcqua.Size = new System.Drawing.Size(88, 13);
            this.labelLivelloAcqua.TabIndex = 6;
            this.labelLivelloAcqua.Text = "LIVELLO ACQUA";
            // 
            // labelLuce
            // 
            this.labelLuce.AutoSize = true;
            this.labelLuce.Location = new System.Drawing.Point(11, 36);
            this.labelLuce.Name = "labelLuce";
            this.labelLuce.Size = new System.Drawing.Size(92, 13);
            this.labelLuce.TabIndex = 4;
            this.labelLuce.Text = "QUANTITA\' LUCE";
            // 
            // groupBoxSensoreUmiditaTemperatura
            // 
            this.groupBoxSensoreUmiditaTemperatura.Controls.Add(this.textBoxTemperatura);
            this.groupBoxSensoreUmiditaTemperatura.Controls.Add(this.textBoxSensoreUmidita);
            this.groupBoxSensoreUmiditaTemperatura.Controls.Add(this.labelUmidita);
            this.groupBoxSensoreUmiditaTemperatura.Controls.Add(this.labelTemperatura);
            this.groupBoxSensoreUmiditaTemperatura.Location = new System.Drawing.Point(17, 124);
            this.groupBoxSensoreUmiditaTemperatura.Name = "groupBoxSensoreUmiditaTemperatura";
            this.groupBoxSensoreUmiditaTemperatura.Size = new System.Drawing.Size(260, 119);
            this.groupBoxSensoreUmiditaTemperatura.TabIndex = 7;
            this.groupBoxSensoreUmiditaTemperatura.TabStop = false;
            this.groupBoxSensoreUmiditaTemperatura.Text = "UMIDITA\' E TEMPERATURA";
            // 
            // labelUmidita
            // 
            this.labelUmidita.AutoSize = true;
            this.labelUmidita.Location = new System.Drawing.Point(33, 33);
            this.labelUmidita.Name = "labelUmidita";
            this.labelUmidita.Size = new System.Drawing.Size(53, 13);
            this.labelUmidita.TabIndex = 4;
            this.labelUmidita.Text = "UMIDITA\'";
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.AutoSize = true;
            this.labelTemperatura.Location = new System.Drawing.Point(18, 69);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(85, 13);
            this.labelTemperatura.TabIndex = 4;
            this.labelTemperatura.Text = "TEMPERATURA";
            // 
            // groupBoxONOFFLetturaSensori
            // 
            this.groupBoxONOFFLetturaSensori.Controls.Add(this.textBoxTimerLetturaSensori);
            this.groupBoxONOFFLetturaSensori.Controls.Add(this.buttonLetturaSensori);
            this.groupBoxONOFFLetturaSensori.Location = new System.Drawing.Point(18, 32);
            this.groupBoxONOFFLetturaSensori.Name = "groupBoxONOFFLetturaSensori";
            this.groupBoxONOFFLetturaSensori.Size = new System.Drawing.Size(259, 81);
            this.groupBoxONOFFLetturaSensori.TabIndex = 4;
            this.groupBoxONOFFLetturaSensori.TabStop = false;
            this.groupBoxONOFFLetturaSensori.Text = "LETTURA SENSORI";
            // 
            // textBoxTimerLetturaSensori
            // 
            this.textBoxTimerLetturaSensori.Location = new System.Drawing.Point(121, 32);
            this.textBoxTimerLetturaSensori.Name = "textBoxTimerLetturaSensori";
            this.textBoxTimerLetturaSensori.Size = new System.Drawing.Size(132, 21);
            this.textBoxTimerLetturaSensori.TabIndex = 5;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Visible = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxErroriFromSerial);
            this.groupBox2.Location = new System.Drawing.Point(16, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 218);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ERRORI PROVENIENTI DALLA SERIALE";
            // 
            // richTextBoxErroriFromSerial
            // 
            this.richTextBoxErroriFromSerial.Location = new System.Drawing.Point(27, 55);
            this.richTextBoxErroriFromSerial.Name = "richTextBoxErroriFromSerial";
            this.richTextBoxErroriFromSerial.Size = new System.Drawing.Size(241, 148);
            this.richTextBoxErroriFromSerial.TabIndex = 5;
            this.richTextBoxErroriFromSerial.Text = "";
            this.richTextBoxErroriFromSerial.TextChanged += new System.EventHandler(this.richTextBoxErroriFromSerial_TextChanged);
            // 
            // PANNELLO_DI_CONTROLLO_SERRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxSensori);
            this.Controls.Add(this.groupBoxAttuatori);
            this.Controls.Add(this.groupBoxCollegamentoSeriale);
            this.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PANNELLO_DI_CONTROLLO_SERRA";
            this.Text = "PANNELLO DI CONTROLLO SERRA IDROPONICA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCollegamentoSeriale.ResumeLayout(false);
            this.groupBoxCollegamentoSeriale.PerformLayout();
            this.groupBoxAttuatori.ResumeLayout(false);
            this.groupBoxPompaAcqua.ResumeLayout(false);
            this.groupBoxPompaAcqua.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxControlliVentilatore.ResumeLayout(false);
            this.groupBoxControlliVentilatore.PerformLayout();
            this.groupBoxControlliLuce.ResumeLayout(false);
            this.groupBoxControlliLuce.PerformLayout();
            this.groupBoxSensori.ResumeLayout(false);
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.ResumeLayout(false);
            this.groupBoxSensoriLivelloAcquaQuantitaLuce.PerformLayout();
            this.groupBoxSensoreUmiditaTemperatura.ResumeLayout(false);
            this.groupBoxSensoreUmiditaTemperatura.PerformLayout();
            this.groupBoxONOFFLetturaSensori.ResumeLayout(false);
            this.groupBoxONOFFLetturaSensori.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCollegamentoSeriale;
        private System.Windows.Forms.Button buttonONOFFSeriale;
        private System.Windows.Forms.Label labelAbDisSeriale;
        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.GroupBox groupBoxAttuatori;
        private System.Windows.Forms.Label labelONOFFLUCE;
        private System.Windows.Forms.Button buttonONOFFLUCE;
        private System.Windows.Forms.Label labelONOFFVentilatore;
        private System.Windows.Forms.Button buttonONOFFVentilatore;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBoxControlliVentilatore;
        private System.Windows.Forms.GroupBox groupBoxControlliLuce;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBoxSensoreUmidita;
        private System.Windows.Forms.Button buttonSecurityAllOFF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxPompaAcqua;
        private System.Windows.Forms.Label labelPompaAcqua;
        private System.Windows.Forms.Button buttonPompaAcqua;
        private System.Windows.Forms.GroupBox groupBoxSensori;
        private System.Windows.Forms.TextBox textBoxTemperatura;
        private System.Windows.Forms.Label labelUmidita;
        private System.Windows.Forms.Label labelTemperatura;
        private System.Windows.Forms.Label labelLuce;
        private System.Windows.Forms.TextBox textBoxLuce;
        private System.Windows.Forms.Label labelLivelloAcqua;
        private System.Windows.Forms.TextBox textBoxLivelloAcqua;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button buttonLetturaSensori;
        private System.Windows.Forms.TextBox textBoxTimerLetturaSensori;
        private System.Windows.Forms.GroupBox groupBoxSensoreUmiditaTemperatura;
        private System.Windows.Forms.GroupBox groupBoxONOFFLetturaSensori;
        private System.Windows.Forms.GroupBox groupBoxSensoriLivelloAcquaQuantitaLuce;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxErroriFromSerial;
        public System.Windows.Forms.ComboBox comboBoxSerialPortsName;
    }
}

