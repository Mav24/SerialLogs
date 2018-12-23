namespace SerialLogs
{
    partial class NewSerialNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSerialNumber));
            this.btnChangeYear = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboAntenna = new System.Windows.Forms.ComboBox();
            this.antennasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new SerialLogs.AppData();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedSerial = new System.Windows.Forms.MaskedTextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblJobNumber = new System.Windows.Forms.Label();
            this.lblAntenna = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblSerialCount = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.serial_LogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serial_LogTableAdapter = new SerialLogs.AppDataTableAdapters.Serial_LogTableAdapter();
            this.tableAdapterManager = new SerialLogs.AppDataTableAdapters.TableAdapterManager();
            this.antennasTableAdapter = new SerialLogs.AppDataTableAdapters.AntennasTableAdapter();
            this.customersTableAdapter = new SerialLogs.AppDataTableAdapters.CustomersTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewCust = new System.Windows.Forms.Button();
            this.btnAddAntenna = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.maskedJobNumber = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.antennasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serial_LogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeYear
            // 
            this.btnChangeYear.BackColor = System.Drawing.Color.LightCoral;
            this.btnChangeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeYear.Location = new System.Drawing.Point(15, 13);
            this.btnChangeYear.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnChangeYear.Name = "btnChangeYear";
            this.btnChangeYear.Size = new System.Drawing.Size(100, 27);
            this.btnChangeYear.TabIndex = 11;
            this.btnChangeYear.Text = "Start New Year";
            this.btnChangeYear.UseVisualStyleBackColor = false;
            this.btnChangeYear.Click += new System.EventHandler(this.btnChangeYear_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 402);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(149, 21);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 46;
            // 
            // comboAntenna
            // 
            this.comboAntenna.DataSource = this.antennasBindingSource;
            this.comboAntenna.DisplayMember = "Antenna";
            this.comboAntenna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAntenna.FormattingEnabled = true;
            this.comboAntenna.IntegralHeight = false;
            this.comboAntenna.Location = new System.Drawing.Point(376, 195);
            this.comboAntenna.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.comboAntenna.Name = "comboAntenna";
            this.comboAntenna.Size = new System.Drawing.Size(243, 28);
            this.comboAntenna.TabIndex = 5;
            this.comboAntenna.Tag = "Antenna";
            this.comboAntenna.ValueMember = "Antenna";
            // 
            // antennasBindingSource
            // 
            this.antennasBindingSource.DataMember = "Antennas";
            this.antennasBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboCustomer
            // 
            this.comboCustomer.DataSource = this.customersBindingSource;
            this.comboCustomer.DisplayMember = "Customer";
            this.comboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.IntegralHeight = false;
            this.comboCustomer.ItemHeight = 20;
            this.comboCustomer.Location = new System.Drawing.Point(376, 141);
            this.comboCustomer.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(243, 28);
            this.comboCustomer.TabIndex = 3;
            this.comboCustomer.Tag = "Customer";
            this.comboCustomer.ValueMember = "Customer";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.appData;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(598, 389);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(502, 389);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 249);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 26);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2018, 5, 29, 0, 0, 0, 0);
            // 
            // maskedSerial
            // 
            this.maskedSerial.Location = new System.Drawing.Point(160, 141);
            this.maskedSerial.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.maskedSerial.Mask = "00-0000";
            this.maskedSerial.Name = "maskedSerial";
            this.maskedSerial.Size = new System.Drawing.Size(73, 26);
            this.maskedSerial.TabIndex = 12;
            this.maskedSerial.Tag = "Serial Number";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(104, 299);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNotes.MaxLength = 75;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(458, 64);
            this.txtNotes.TabIndex = 8;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(215, 194);
            this.txtCount.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtCount.MaxLength = 3;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(50, 26);
            this.txtCount.TabIndex = 1;
            this.txtCount.Tag = "# of Serials";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(273, 254);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 20);
            this.lblDate.TabIndex = 44;
            this.lblDate.Text = "Date:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotes.Location = new System.Drawing.Point(21, 302);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(61, 20);
            this.lblNotes.TabIndex = 45;
            this.lblNotes.Text = "Notes:";
            // 
            // lblJobNumber
            // 
            this.lblJobNumber.AutoSize = true;
            this.lblJobNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblJobNumber.Location = new System.Drawing.Point(20, 251);
            this.lblJobNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJobNumber.Name = "lblJobNumber";
            this.lblJobNumber.Size = new System.Drawing.Size(110, 20);
            this.lblJobNumber.TabIndex = 41;
            this.lblJobNumber.Text = "Job Number:";
            // 
            // lblAntenna
            // 
            this.lblAntenna.AutoSize = true;
            this.lblAntenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAntenna.Location = new System.Drawing.Point(273, 201);
            this.lblAntenna.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAntenna.Name = "lblAntenna";
            this.lblAntenna.Size = new System.Drawing.Size(82, 20);
            this.lblAntenna.TabIndex = 43;
            this.lblAntenna.Text = "Antenna:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.Location = new System.Drawing.Point(273, 145);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(91, 20);
            this.lblCustomer.TabIndex = 42;
            this.lblCustomer.Text = "Customer:";
            // 
            // lblSerialCount
            // 
            this.lblSerialCount.AutoSize = true;
            this.lblSerialCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSerialCount.Location = new System.Drawing.Point(21, 197);
            this.lblSerialCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSerialCount.Name = "lblSerialCount";
            this.lblSerialCount.Size = new System.Drawing.Size(182, 20);
            this.lblSerialCount.TabIndex = 40;
            this.lblSerialCount.Text = "# Of Serials To Issue:";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSerialNumber.Location = new System.Drawing.Point(21, 145);
            this.lblSerialNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(127, 20);
            this.lblSerialNumber.TabIndex = 39;
            this.lblSerialNumber.Text = "Serial Number:";
            // 
            // serial_LogBindingSource
            // 
            this.serial_LogBindingSource.DataMember = "Serial_Log";
            this.serial_LogBindingSource.DataSource = this.appData;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SerialLogs.Properties.Resources.ValcomLogV101;
            this.pictureBox1.Location = new System.Drawing.Point(233, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewCust
            // 
            this.btnAddNewCust.FlatAppearance.BorderSize = 0;
            this.btnAddNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewCust.Image = global::SerialLogs.Properties.Resources.User_24x24;
            this.btnAddNewCust.Location = new System.Drawing.Point(637, 137);
            this.btnAddNewCust.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAddNewCust.Name = "btnAddNewCust";
            this.btnAddNewCust.Size = new System.Drawing.Size(45, 34);
            this.btnAddNewCust.TabIndex = 4;
            this.btnAddNewCust.UseVisualStyleBackColor = true;
            this.btnAddNewCust.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddAntenna
            // 
            this.btnAddAntenna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAntenna.Image = global::SerialLogs.Properties.Resources.Add;
            this.btnAddAntenna.Location = new System.Drawing.Point(637, 191);
            this.btnAddAntenna.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAddAntenna.Name = "btnAddAntenna";
            this.btnAddAntenna.Size = new System.Drawing.Size(45, 33);
            this.btnAddAntenna.TabIndex = 6;
            this.btnAddAntenna.UseVisualStyleBackColor = true;
            this.btnAddAntenna.Click += new System.EventHandler(this.btnAddAntenna_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::SerialLogs.Properties.Resources.Help_32x32;
            this.btnHelp.Location = new System.Drawing.Point(640, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(50, 35);
            this.btnHelp.TabIndex = 50;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // maskedJobNumber
            // 
            this.maskedJobNumber.Location = new System.Drawing.Point(139, 248);
            this.maskedJobNumber.Mask = "a-0000-00";
            this.maskedJobNumber.Name = "maskedJobNumber";
            this.maskedJobNumber.Size = new System.Drawing.Size(88, 26);
            this.maskedJobNumber.TabIndex = 2;
            this.maskedJobNumber.Tag = "Job number";
            // 
            // NewSerialNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 445);
            this.Controls.Add(this.maskedJobNumber);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAddAntenna);
            this.Controls.Add(this.btnAddNewCust);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChangeYear);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboAntenna);
            this.Controls.Add(this.comboCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maskedSerial);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblJobNumber);
            this.Controls.Add(this.lblAntenna);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblSerialCount);
            this.Controls.Add(this.lblSerialNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewSerialNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue New Serial Number";
            this.Load += new System.EventHandler(this.NewSerialNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.antennasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serial_LogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeYear;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboAntenna;
        public System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.MaskedTextBox maskedSerial;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblJobNumber;
        private System.Windows.Forms.Label lblAntenna;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblSerialCount;
        private System.Windows.Forms.Label lblSerialNumber;
        private AppData appData;
        private System.Windows.Forms.BindingSource serial_LogBindingSource;
        private AppDataTableAdapters.Serial_LogTableAdapter serial_LogTableAdapter;
        private AppDataTableAdapters.TableAdapterManager tableAdapterManager;
        private AppDataTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private AppDataTableAdapters.AntennasTableAdapter antennasTableAdapter;
        private System.Windows.Forms.BindingSource antennasBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddNewCust;
        private System.Windows.Forms.Button btnAddAntenna;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.MaskedTextBox maskedJobNumber;
    }
}