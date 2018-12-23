namespace SerialLogs
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.TopEditPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.edittxtNotes = new System.Windows.Forms.TextBox();
            this.serial_LogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new SerialLogs.AppData();
            this.maskedJobNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.editcomboAntenna = new System.Windows.Forms.ComboBox();
            this.antennasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.editcomboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCustomer = new System.Windows.Forms.RadioButton();
            this.rdoSerial = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.serial_LogTableAdapter = new SerialLogs.AppDataTableAdapters.Serial_LogTableAdapter();
            this.tableAdapterManager = new SerialLogs.AppDataTableAdapters.TableAdapterManager();
            this.antennasTableAdapter = new SerialLogs.AppDataTableAdapters.AntennasTableAdapter();
            this.customersTableAdapter = new SerialLogs.AppDataTableAdapters.CustomersTableAdapter();
            this.bottompanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.EditDataGridView = new System.Windows.Forms.DataGridView();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antennaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.checkDelete = new System.Windows.Forms.CheckBox();
            this.TopEditPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serial_LogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antennasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bottompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopEditPanel
            // 
            this.TopEditPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TopEditPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopEditPanel.Controls.Add(this.groupBox2);
            this.TopEditPanel.Controls.Add(this.txtSearch);
            this.TopEditPanel.Controls.Add(this.groupBox1);
            this.TopEditPanel.Controls.Add(this.btnSearch);
            this.TopEditPanel.Controls.Add(this.pictureBox1);
            this.TopEditPanel.Controls.Add(this.btnExit);
            this.TopEditPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopEditPanel.Location = new System.Drawing.Point(0, 0);
            this.TopEditPanel.Name = "TopEditPanel";
            this.TopEditPanel.Size = new System.Drawing.Size(1030, 283);
            this.TopEditPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.edittxtNotes);
            this.groupBox2.Controls.Add(this.maskedJobNumber);
            this.groupBox2.Controls.Add(this.lblNotes);
            this.groupBox2.Controls.Add(this.lblSerialNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.editdateTimePicker1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.editcomboAntenna);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.editcomboBoxCustomer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(270, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 263);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(290, 209);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 29);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(372, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "S&ave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(454, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // edittxtNotes
            // 
            this.edittxtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serial_LogBindingSource, "Notes", true));
            this.edittxtNotes.Location = new System.Drawing.Point(94, 133);
            this.edittxtNotes.MaxLength = 75;
            this.edittxtNotes.Multiline = true;
            this.edittxtNotes.Name = "edittxtNotes";
            this.edittxtNotes.Size = new System.Drawing.Size(361, 61);
            this.edittxtNotes.TabIndex = 6;
            // 
            // serial_LogBindingSource
            // 
            this.serial_LogBindingSource.DataMember = "Serial_Log";
            this.serial_LogBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedJobNumber
            // 
            this.maskedJobNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serial_LogBindingSource, "JobNumber", true));
            this.maskedJobNumber.Location = new System.Drawing.Point(157, 53);
            this.maskedJobNumber.Mask = "A-0000-00";
            this.maskedJobNumber.Name = "maskedJobNumber";
            this.maskedJobNumber.Size = new System.Drawing.Size(87, 26);
            this.maskedJobNumber.TabIndex = 2;
            this.maskedJobNumber.Tag = "Job Number";
            this.maskedJobNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedJobNumber_KeyPress);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(25, 136);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(55, 20);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Text = "Notes:";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serial_LogBindingSource, "Serial", true));
            this.lblSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSerialNumber.Location = new System.Drawing.Point(153, 22);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(0, 20);
            this.lblSerialNumber.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date:";
            // 
            // editdateTimePicker1
            // 
            this.editdateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serial_LogBindingSource, "Date", true));
            this.editdateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.serial_LogBindingSource, "Date", true));
            this.editdateTimePicker1.Location = new System.Drawing.Point(193, 98);
            this.editdateTimePicker1.Name = "editdateTimePicker1";
            this.editdateTimePicker1.Size = new System.Drawing.Size(279, 26);
            this.editdateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Serial Number:";
            // 
            // editcomboAntenna
            // 
            this.editcomboAntenna.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.serial_LogBindingSource, "Antenna", true));
            this.editcomboAntenna.DataSource = this.antennasBindingSource;
            this.editcomboAntenna.DisplayMember = "Antenna";
            this.editcomboAntenna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editcomboAntenna.FormattingEnabled = true;
            this.editcomboAntenna.IntegralHeight = false;
            this.editcomboAntenna.Location = new System.Drawing.Point(347, 58);
            this.editcomboAntenna.Name = "editcomboAntenna";
            this.editcomboAntenna.Size = new System.Drawing.Size(230, 28);
            this.editcomboAntenna.TabIndex = 4;
            this.editcomboAntenna.Tag = "Antenna";
            this.editcomboAntenna.ValueMember = "Antenna";
            // 
            // antennasBindingSource
            // 
            this.antennasBindingSource.DataMember = "Antennas";
            this.antennasBindingSource.DataSource = this.appData;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer:";
            // 
            // editcomboBoxCustomer
            // 
            this.editcomboBoxCustomer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.serial_LogBindingSource, "Customer", true));
            this.editcomboBoxCustomer.DataSource = this.customersBindingSource;
            this.editcomboBoxCustomer.DisplayMember = "Customer";
            this.editcomboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editcomboBoxCustomer.FormattingEnabled = true;
            this.editcomboBoxCustomer.IntegralHeight = false;
            this.editcomboBoxCustomer.Location = new System.Drawing.Point(347, 18);
            this.editcomboBoxCustomer.Name = "editcomboBoxCustomer";
            this.editcomboBoxCustomer.Size = new System.Drawing.Size(230, 28);
            this.editcomboBoxCustomer.TabIndex = 3;
            this.editcomboBoxCustomer.Tag = "Customer";
            this.editcomboBoxCustomer.ValueMember = "Customer";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.appData;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Antenna:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Job Number:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 213);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCustomer);
            this.groupBox1.Controls.Add(this.rdoSerial);
            this.groupBox1.Location = new System.Drawing.Point(11, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 52);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // rdoCustomer
            // 
            this.rdoCustomer.AutoSize = true;
            this.rdoCustomer.Location = new System.Drawing.Point(102, 26);
            this.rdoCustomer.Name = "rdoCustomer";
            this.rdoCustomer.Size = new System.Drawing.Size(104, 24);
            this.rdoCustomer.TabIndex = 1;
            this.rdoCustomer.Text = "Customers";
            this.rdoCustomer.UseVisualStyleBackColor = true;
            this.rdoCustomer.CheckedChanged += new System.EventHandler(this.rdoFocusTxtBxSearch_CheckedChanged);
            // 
            // rdoSerial
            // 
            this.rdoSerial.AutoSize = true;
            this.rdoSerial.Checked = true;
            this.rdoSerial.Location = new System.Drawing.Point(7, 26);
            this.rdoSerial.Name = "rdoSerial";
            this.rdoSerial.Size = new System.Drawing.Size(67, 24);
            this.rdoSerial.TabIndex = 0;
            this.rdoSerial.TabStop = true;
            this.rdoSerial.Text = "Serial";
            this.rdoSerial.UseVisualStyleBackColor = true;
            this.rdoSerial.CheckedChanged += new System.EventHandler(this.rdoFocusTxtBxSearch_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Image = global::SerialLogs.Properties.Resources.Search_32x32;
            this.btnSearch.Location = new System.Drawing.Point(217, 209);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SerialLogs.Properties.Resources.ValcomLogV101;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Image = global::SerialLogs.Properties.Resources.Log_Out_48x48;
            this.btnExit.Location = new System.Drawing.Point(950, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 67);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::SerialLogs.Properties.Resources.Help_32x32;
            this.btnHelp.Location = new System.Drawing.Point(5, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(46, 32);
            this.btnHelp.TabIndex = 51;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(915, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // serial_LogTableAdapter
            // 
            this.serial_LogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AntennasTableAdapter = this.antennasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.Serial_LogTableAdapter = this.serial_LogTableAdapter;
            this.tableAdapterManager.UpdateOrder = SerialLogs.AppDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // antennasTableAdapter
            // 
            this.antennasTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bottompanel.Controls.Add(this.checkDelete);
            this.bottompanel.Controls.Add(this.label6);
            this.bottompanel.Controls.Add(this.btnDelete);
            this.bottompanel.Controls.Add(this.btnHelp);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(0, 508);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(1030, 38);
            this.bottompanel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(170, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(591, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tip: To delete a row, select the whole row or multiple rows and hit the delete bu" +
    "tton!";
            // 
            // EditDataGridView
            // 
            this.EditDataGridView.AllowUserToAddRows = false;
            this.EditDataGridView.AllowUserToDeleteRows = false;
            this.EditDataGridView.AutoGenerateColumns = false;
            this.EditDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EditDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.jobNumberDataGridViewTextBoxColumn,
            this.antennaDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.CustomerInfo});
            this.EditDataGridView.DataSource = this.serial_LogBindingSource;
            this.EditDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditDataGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.EditDataGridView.Location = new System.Drawing.Point(0, 283);
            this.EditDataGridView.Name = "EditDataGridView";
            this.EditDataGridView.ReadOnly = true;
            this.EditDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EditDataGridView.Size = new System.Drawing.Size(1030, 225);
            this.EditDataGridView.TabIndex = 3;
            this.EditDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditDataGridView_CellContentClick);
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Serial #";
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialDataGridViewTextBoxColumn.Width = 87;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobNumberDataGridViewTextBoxColumn
            // 
            this.jobNumberDataGridViewTextBoxColumn.DataPropertyName = "JobNumber";
            this.jobNumberDataGridViewTextBoxColumn.HeaderText = "Job Number";
            this.jobNumberDataGridViewTextBoxColumn.Name = "jobNumberDataGridViewTextBoxColumn";
            this.jobNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // antennaDataGridViewTextBoxColumn
            // 
            this.antennaDataGridViewTextBoxColumn.DataPropertyName = "Antenna";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.antennaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.antennaDataGridViewTextBoxColumn.HeaderText = "Antenna";
            this.antennaDataGridViewTextBoxColumn.Name = "antennaDataGridViewTextBoxColumn";
            this.antennaDataGridViewTextBoxColumn.ReadOnly = true;
            this.antennaDataGridViewTextBoxColumn.Width = 175;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 85;
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.HeaderText = "";
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.ReadOnly = true;
            this.CustomerInfo.Text = "INFO";
            this.CustomerInfo.UseColumnTextForButtonValue = true;
            // 
            // checkDelete
            // 
            this.checkDelete.AutoSize = true;
            this.checkDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkDelete.Location = new System.Drawing.Point(793, 11);
            this.checkDelete.Name = "checkDelete";
            this.checkDelete.Size = new System.Drawing.Size(116, 21);
            this.checkDelete.TabIndex = 52;
            this.checkDelete.Text = "Enable Delete";
            this.checkDelete.UseVisualStyleBackColor = true;
            this.checkDelete.CheckedChanged += new System.EventHandler(this.checkDelete_CheckedChanged);
            // 
            // Edit
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1030, 546);
            this.Controls.Add(this.EditDataGridView);
            this.Controls.Add(this.bottompanel);
            this.Controls.Add(this.TopEditPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.TopEditPanel.ResumeLayout(false);
            this.TopEditPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serial_LogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antennasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bottompanel.ResumeLayout(false);
            this.bottompanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopEditPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AppData appData;
        private System.Windows.Forms.BindingSource serial_LogBindingSource;
        private AppDataTableAdapters.Serial_LogTableAdapter serial_LogTableAdapter;
        private AppDataTableAdapters.TableAdapterManager tableAdapterManager;
        private AppDataTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private AppDataTableAdapters.AntennasTableAdapter antennasTableAdapter;
        private System.Windows.Forms.BindingSource antennasBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblNotes;
        public System.Windows.Forms.DateTimePicker editdateTimePicker1;
        public System.Windows.Forms.ComboBox editcomboAntenna;
        public System.Windows.Forms.ComboBox editcomboBoxCustomer;
        public System.Windows.Forms.TextBox edittxtNotes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.MaskedTextBox maskedJobNumber;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.DataGridView EditDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCustomer;
        private System.Windows.Forms.RadioButton rdoSerial;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antennaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn CustomerInfo;
        private System.Windows.Forms.CheckBox checkDelete;
    }
}