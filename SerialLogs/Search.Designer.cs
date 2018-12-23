namespace SerialLogs
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.appData = new SerialLogs.AppData();
            this.serial_LogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serial_LogTableAdapter = new SerialLogs.AppDataTableAdapters.Serial_LogTableAdapter();
            this.tableAdapterManager = new SerialLogs.AppDataTableAdapters.TableAdapterManager();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchLogsTitle = new System.Windows.Forms.Label();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antennaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetINFO = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customersTableAdapter = new SerialLogs.AppDataTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serial_LogBindingSource)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.AntennasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Serial_LogTableAdapter = this.serial_LogTableAdapter;
            this.tableAdapterManager.UpdateOrder = SerialLogs.AppDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.btnExit);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.lblSearchID);
            this.TopPanel.Controls.Add(this.txtSearch);
            this.TopPanel.Controls.Add(this.btnSearch);
            this.TopPanel.Controls.Add(this.lblSearchLogsTitle);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(923, 161);
            this.TopPanel.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Image = global::SerialLogs.Properties.Resources.Log_Out_48x48;
            this.btnExit.Location = new System.Drawing.Point(842, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 67);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serial, Customer, Job Number, Antenna:";
            // 
            // lblSearchID
            // 
            this.lblSearchID.AutoSize = true;
            this.lblSearchID.Location = new System.Drawing.Point(11, 93);
            this.lblSearchID.Name = "lblSearchID";
            this.lblSearchID.Size = new System.Drawing.Size(84, 20);
            this.lblSearchID.TabIndex = 3;
            this.lblSearchID.Text = "Search by:\r\n";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(310, 114);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(246, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(580, 114);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchLogsTitle
            // 
            this.lblSearchLogsTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSearchLogsTitle.AutoSize = true;
            this.lblSearchLogsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLogsTitle.Location = new System.Drawing.Point(131, 12);
            this.lblSearchLogsTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearchLogsTitle.Name = "lblSearchLogsTitle";
            this.lblSearchLogsTitle.Size = new System.Drawing.Size(483, 63);
            this.lblSearchLogsTitle.TabIndex = 0;
            this.lblSearchLogsTitle.Text = "Serial Logs Search";
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.AutoGenerateColumns = false;
            this.searchDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.jobNumberDataGridViewTextBoxColumn,
            this.antennaDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.GetINFO});
            this.searchDataGridView.DataSource = this.serial_LogBindingSource;
            this.searchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchDataGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.searchDataGridView.Location = new System.Drawing.Point(0, 161);
            this.searchDataGridView.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            this.searchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataGridView.Size = new System.Drawing.Size(923, 293);
            this.searchDataGridView.TabIndex = 1;
            this.searchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDataGridView_CellContentClick);
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Serial #";
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.serialDataGridViewTextBoxColumn.Width = 87;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.FillWeight = 422.4806F;
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Width = 217;
            // 
            // jobNumberDataGridViewTextBoxColumn
            // 
            this.jobNumberDataGridViewTextBoxColumn.DataPropertyName = "JobNumber";
            this.jobNumberDataGridViewTextBoxColumn.FillWeight = 19.37984F;
            this.jobNumberDataGridViewTextBoxColumn.HeaderText = "Job Number";
            this.jobNumberDataGridViewTextBoxColumn.Name = "jobNumberDataGridViewTextBoxColumn";
            this.jobNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // antennaDataGridViewTextBoxColumn
            // 
            this.antennaDataGridViewTextBoxColumn.DataPropertyName = "Antenna";
            this.antennaDataGridViewTextBoxColumn.FillWeight = 19.37984F;
            this.antennaDataGridViewTextBoxColumn.HeaderText = "Antenna";
            this.antennaDataGridViewTextBoxColumn.Name = "antennaDataGridViewTextBoxColumn";
            this.antennaDataGridViewTextBoxColumn.ReadOnly = true;
            this.antennaDataGridViewTextBoxColumn.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.FillWeight = 19.37984F;
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 19.37984F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GetINFO
            // 
            this.GetINFO.HeaderText = "";
            this.GetINFO.Name = "GetINFO";
            this.GetINFO.ReadOnly = true;
            this.GetINFO.Text = "INFO";
            this.GetINFO.UseColumnTextForButtonValue = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(923, 454);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serial_LogBindingSource)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppData appData;
        private System.Windows.Forms.BindingSource serial_LogBindingSource;
        private AppDataTableAdapters.Serial_LogTableAdapter serial_LogTableAdapter;
        private AppDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchLogsTitle;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.Label lblSearchID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antennaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn GetINFO;
        private AppDataTableAdapters.CustomersTableAdapter customersTableAdapter;
    }
}