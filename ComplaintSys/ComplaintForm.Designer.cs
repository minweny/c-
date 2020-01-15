namespace ComplaintSys
{
    partial class ComplaintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplaintForm));
            this.btnDeleteComplaint = new System.Windows.Forms.Button();
            this.btnUpdateComplaint = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateOccured = new System.Windows.Forms.DateTimePicker();
            this.dtpDateRecordedEnter = new System.Windows.Forms.DateTimePicker();
            this.dtpResolutionDateEnter = new System.Windows.Forms.DateTimePicker();
            this.txtCompDesc = new System.Windows.Forms.TextBox();
            this.txtResDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCustExp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grbCustomerProfile = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtCompType = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtCompNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvComplaints = new System.Windows.Forms.DataGridView();
            this.bindSrcComplaints = new System.Windows.Forms.BindingSource(this.components);
            this.bindNavComplaints = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCompClearFilters = new System.Windows.Forms.Button();
            this.btnCompClearSorts = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpResolutionDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDateRecorded = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboComplaintType = new System.Windows.Forms.ComboBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnResolutionDate = new System.Windows.Forms.Button();
            this.btnComplaintType = new System.Windows.Forms.Button();
            this.btnDateRecorded = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSortCustomerId = new System.Windows.Forms.Button();
            this.btnSortComplaintNo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddComplaint = new System.Windows.Forms.Button();
            this.lblCompTotal = new System.Windows.Forms.Label();
            this.btnSelectComplaint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbCustomerProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcComplaints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindNavComplaints)).BeginInit();
            this.bindNavComplaints.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteComplaint
            // 
            this.btnDeleteComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteComplaint.Location = new System.Drawing.Point(951, 139);
            this.btnDeleteComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteComplaint.Name = "btnDeleteComplaint";
            this.btnDeleteComplaint.Size = new System.Drawing.Size(127, 43);
            this.btnDeleteComplaint.TabIndex = 22;
            this.btnDeleteComplaint.Text = "Delete Complaint";
            this.btnDeleteComplaint.UseVisualStyleBackColor = true;
            this.btnDeleteComplaint.Click += new System.EventHandler(this.btnDeleteComplaint_Click);
            // 
            // btnUpdateComplaint
            // 
            this.btnUpdateComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateComplaint.Location = new System.Drawing.Point(951, 82);
            this.btnUpdateComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateComplaint.Name = "btnUpdateComplaint";
            this.btnUpdateComplaint.Size = new System.Drawing.Size(127, 43);
            this.btnUpdateComplaint.TabIndex = 21;
            this.btnUpdateComplaint.Text = "Update Complaint Data";
            this.btnUpdateComplaint.UseVisualStyleBackColor = true;
            this.btnUpdateComplaint.Click += new System.EventHandler(this.btnUpdateComplaint_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.Location = new System.Drawing.Point(951, 27);
            this.btnClearData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(127, 43);
            this.btnClearData.TabIndex = 20;
            this.btnClearData.Text = "Clear Complaint Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(1096, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 95);
            this.label5.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDateOccured);
            this.groupBox1.Controls.Add(this.dtpDateRecordedEnter);
            this.groupBox1.Controls.Add(this.dtpResolutionDateEnter);
            this.groupBox1.Controls.Add(this.txtCompDesc);
            this.groupBox1.Controls.Add(this.txtResDesc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(340, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(585, 218);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complaint Details";
            // 
            // dtpDateOccured
            // 
            this.dtpDateOccured.Checked = false;
            this.dtpDateOccured.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOccured.Location = new System.Drawing.Point(193, 164);
            this.dtpDateOccured.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateOccured.Name = "dtpDateOccured";
            this.dtpDateOccured.Size = new System.Drawing.Size(293, 23);
            this.dtpDateOccured.TabIndex = 20;
            // 
            // dtpDateRecordedEnter
            // 
            this.dtpDateRecordedEnter.Checked = false;
            this.dtpDateRecordedEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateRecordedEnter.Location = new System.Drawing.Point(193, 132);
            this.dtpDateRecordedEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateRecordedEnter.Name = "dtpDateRecordedEnter";
            this.dtpDateRecordedEnter.Size = new System.Drawing.Size(293, 23);
            this.dtpDateRecordedEnter.TabIndex = 19;
            // 
            // dtpResolutionDateEnter
            // 
            this.dtpResolutionDateEnter.Checked = false;
            this.dtpResolutionDateEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpResolutionDateEnter.Location = new System.Drawing.Point(193, 100);
            this.dtpResolutionDateEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpResolutionDateEnter.Name = "dtpResolutionDateEnter";
            this.dtpResolutionDateEnter.Size = new System.Drawing.Size(293, 23);
            this.dtpResolutionDateEnter.TabIndex = 18;
            // 
            // txtCompDesc
            // 
            this.txtCompDesc.Location = new System.Drawing.Point(193, 37);
            this.txtCompDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompDesc.Name = "txtCompDesc";
            this.txtCompDesc.Size = new System.Drawing.Size(373, 26);
            this.txtCompDesc.TabIndex = 10;
            // 
            // txtResDesc
            // 
            this.txtResDesc.Location = new System.Drawing.Point(193, 69);
            this.txtResDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResDesc.Name = "txtResDesc";
            this.txtResDesc.Size = new System.Drawing.Size(373, 26);
            this.txtResDesc.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Date Recorded: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Resolution Descr: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Complaint Descr: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Resolution Date: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Date Occured: ";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(192, 182);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(95, 26);
            this.txtStatus.TabIndex = 9;
            // 
            // txtCustExp
            // 
            this.txtCustExp.Location = new System.Drawing.Point(192, 146);
            this.txtCustExp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustExp.Name = "txtCustExp";
            this.txtCustExp.Size = new System.Drawing.Size(95, 26);
            this.txtCustExp.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Cust. Expectation: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(112, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Status: ";
            // 
            // grbCustomerProfile
            // 
            this.grbCustomerProfile.Controls.Add(this.lblLastName);
            this.grbCustomerProfile.Controls.Add(this.txtCompType);
            this.grbCustomerProfile.Controls.Add(this.txtCustID);
            this.grbCustomerProfile.Controls.Add(this.txtCompNo);
            this.grbCustomerProfile.Controls.Add(this.label8);
            this.grbCustomerProfile.Controls.Add(this.txtStatus);
            this.grbCustomerProfile.Controls.Add(this.label7);
            this.grbCustomerProfile.Controls.Add(this.txtCustExp);
            this.grbCustomerProfile.Controls.Add(this.label1);
            this.grbCustomerProfile.Controls.Add(this.label13);
            this.grbCustomerProfile.Controls.Add(this.label11);
            this.grbCustomerProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCustomerProfile.ForeColor = System.Drawing.Color.White;
            this.grbCustomerProfile.Location = new System.Drawing.Point(21, 12);
            this.grbCustomerProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCustomerProfile.Name = "grbCustomerProfile";
            this.grbCustomerProfile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCustomerProfile.Size = new System.Drawing.Size(304, 219);
            this.grbCustomerProfile.TabIndex = 18;
            this.grbCustomerProfile.TabStop = false;
            this.grbCustomerProfile.Text = "Complaint Profile";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(188, 12);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 20);
            this.lblLastName.TabIndex = 34;
            this.lblLastName.Text = "Last Name";
            // 
            // txtCompType
            // 
            this.txtCompType.Location = new System.Drawing.Point(192, 111);
            this.txtCompType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompType.Name = "txtCompType";
            this.txtCompType.Size = new System.Drawing.Size(95, 26);
            this.txtCompType.TabIndex = 9;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(192, 75);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(95, 26);
            this.txtCustID.TabIndex = 8;
            // 
            // txtCompNo
            // 
            this.txtCompNo.Location = new System.Drawing.Point(192, 39);
            this.txtCompNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompNo.Name = "txtCompNo";
            this.txtCompNo.Size = new System.Drawing.Size(95, 26);
            this.txtCompNo.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Customer ID: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Complaint Type: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complaint No: ";
            // 
            // dgvComplaints
            // 
            this.dgvComplaints.AllowUserToAddRows = false;
            this.dgvComplaints.AllowUserToDeleteRows = false;
            this.dgvComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaints.Location = new System.Drawing.Point(16, 442);
            this.dgvComplaints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvComplaints.Name = "dgvComplaints";
            this.dgvComplaints.ReadOnly = true;
            this.dgvComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaints.Size = new System.Drawing.Size(1225, 218);
            this.dgvComplaints.TabIndex = 23;
            // 
            // bindNavComplaints
            // 
            this.bindNavComplaints.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindNavComplaints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bindNavComplaints.CountItem = this.bindingNavigatorCountItem;
            this.bindNavComplaints.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindNavComplaints.Dock = System.Windows.Forms.DockStyle.None;
            this.bindNavComplaints.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindNavComplaints.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindNavComplaints.Location = new System.Drawing.Point(12, 383);
            this.bindNavComplaints.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindNavComplaints.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindNavComplaints.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindNavComplaints.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindNavComplaints.Name = "bindNavComplaints";
            this.bindNavComplaints.PositionItem = this.bindingNavigatorPositionItem;
            this.bindNavComplaints.Size = new System.Drawing.Size(286, 27);
            this.bindNavComplaints.TabIndex = 24;
            this.bindNavComplaints.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnCompClearFilters
            // 
            this.btnCompClearFilters.Location = new System.Drawing.Point(789, 315);
            this.btnCompClearFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompClearFilters.Name = "btnCompClearFilters";
            this.btnCompClearFilters.Size = new System.Drawing.Size(93, 46);
            this.btnCompClearFilters.TabIndex = 29;
            this.btnCompClearFilters.Text = "Complaints Clear Filters";
            this.btnCompClearFilters.UseVisualStyleBackColor = true;
            this.btnCompClearFilters.Click += new System.EventHandler(this.btnCompClearFilters_Click);
            // 
            // btnCompClearSorts
            // 
            this.btnCompClearSorts.Location = new System.Drawing.Point(789, 254);
            this.btnCompClearSorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompClearSorts.Name = "btnCompClearSorts";
            this.btnCompClearSorts.Size = new System.Drawing.Size(93, 46);
            this.btnCompClearSorts.TabIndex = 28;
            this.btnCompClearSorts.Text = "Complaints Clear Sort";
            this.btnCompClearSorts.UseVisualStyleBackColor = true;
            this.btnCompClearSorts.Click += new System.EventHandler(this.btnCompClearSorts_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpResolutionDate);
            this.groupBox4.Controls.Add(this.dtpDateRecorded);
            this.groupBox4.Controls.Add(this.cboStatus);
            this.groupBox4.Controls.Add(this.cboComplaintType);
            this.groupBox4.Controls.Add(this.btnStatus);
            this.groupBox4.Controls.Add(this.btnResolutionDate);
            this.groupBox4.Controls.Add(this.btnComplaintType);
            this.groupBox4.Controls.Add(this.btnDateRecorded);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(21, 241);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(528, 155);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // dtpResolutionDate
            // 
            this.dtpResolutionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpResolutionDate.Location = new System.Drawing.Point(204, 114);
            this.dtpResolutionDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpResolutionDate.Name = "dtpResolutionDate";
            this.dtpResolutionDate.Size = new System.Drawing.Size(293, 23);
            this.dtpResolutionDate.TabIndex = 8;
            // 
            // dtpDateRecorded
            // 
            this.dtpDateRecorded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateRecorded.Location = new System.Drawing.Point(204, 53);
            this.dtpDateRecorded.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateRecorded.Name = "dtpDateRecorded";
            this.dtpDateRecorded.Size = new System.Drawing.Size(293, 23);
            this.dtpDateRecorded.TabIndex = 7;
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(204, 81);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(108, 25);
            this.cboStatus.TabIndex = 6;
            // 
            // cboComplaintType
            // 
            this.cboComplaintType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComplaintType.FormattingEnabled = true;
            this.cboComplaintType.Location = new System.Drawing.Point(204, 21);
            this.cboComplaintType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboComplaintType.Name = "cboComplaintType";
            this.cboComplaintType.Size = new System.Drawing.Size(108, 25);
            this.cboComplaintType.TabIndex = 4;
            // 
            // btnStatus
            // 
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(33, 81);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(135, 25);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // btnResolutionDate
            // 
            this.btnResolutionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolutionDate.Location = new System.Drawing.Point(33, 111);
            this.btnResolutionDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResolutionDate.Name = "btnResolutionDate";
            this.btnResolutionDate.Size = new System.Drawing.Size(135, 25);
            this.btnResolutionDate.TabIndex = 2;
            this.btnResolutionDate.Text = "ResolutionDate";
            this.btnResolutionDate.UseVisualStyleBackColor = true;
            this.btnResolutionDate.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // btnComplaintType
            // 
            this.btnComplaintType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplaintType.Location = new System.Drawing.Point(33, 20);
            this.btnComplaintType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComplaintType.Name = "btnComplaintType";
            this.btnComplaintType.Size = new System.Drawing.Size(135, 25);
            this.btnComplaintType.TabIndex = 1;
            this.btnComplaintType.Text = "ComplaintType";
            this.btnComplaintType.UseVisualStyleBackColor = true;
            this.btnComplaintType.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // btnDateRecorded
            // 
            this.btnDateRecorded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateRecorded.Location = new System.Drawing.Point(33, 50);
            this.btnDateRecorded.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDateRecorded.Name = "btnDateRecorded";
            this.btnDateRecorded.Size = new System.Drawing.Size(135, 25);
            this.btnDateRecorded.TabIndex = 0;
            this.btnDateRecorded.Text = "DateRecorded";
            this.btnDateRecorded.UseVisualStyleBackColor = true;
            this.btnDateRecorded.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSortCustomerId);
            this.groupBox3.Controls.Add(this.btnSortComplaintNo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(572, 241);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(183, 91);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort";
            // 
            // btnSortCustomerId
            // 
            this.btnSortCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortCustomerId.Location = new System.Drawing.Point(33, 49);
            this.btnSortCustomerId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortCustomerId.Name = "btnSortCustomerId";
            this.btnSortCustomerId.Size = new System.Drawing.Size(108, 25);
            this.btnSortCustomerId.TabIndex = 1;
            this.btnSortCustomerId.Text = "CustomerId";
            this.btnSortCustomerId.UseVisualStyleBackColor = true;
            this.btnSortCustomerId.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // btnSortComplaintNo
            // 
            this.btnSortComplaintNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortComplaintNo.Location = new System.Drawing.Point(33, 21);
            this.btnSortComplaintNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortComplaintNo.Name = "btnSortComplaintNo";
            this.btnSortComplaintNo.Size = new System.Drawing.Size(108, 25);
            this.btnSortComplaintNo.TabIndex = 0;
            this.btnSortComplaintNo.Text = "ComplaintNo";
            this.btnSortComplaintNo.UseVisualStyleBackColor = true;
            this.btnSortComplaintNo.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1041, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Complaint Total:";
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComplaint.Location = new System.Drawing.Point(951, 194);
            this.btnAddComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(127, 43);
            this.btnAddComplaint.TabIndex = 30;
            this.btnAddComplaint.Text = "Add Complaint";
            this.btnAddComplaint.UseVisualStyleBackColor = true;
            this.btnAddComplaint.Click += new System.EventHandler(this.btnAddComplaint_Click);
            // 
            // lblCompTotal
            // 
            this.lblCompTotal.AutoSize = true;
            this.lblCompTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompTotal.Location = new System.Drawing.Point(1173, 409);
            this.lblCompTotal.Name = "lblCompTotal";
            this.lblCompTotal.Size = new System.Drawing.Size(40, 17);
            this.lblCompTotal.TabIndex = 31;
            this.lblCompTotal.Text = "total";
            // 
            // btnSelectComplaint
            // 
            this.btnSelectComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectComplaint.Location = new System.Drawing.Point(951, 251);
            this.btnSelectComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectComplaint.Name = "btnSelectComplaint";
            this.btnSelectComplaint.Size = new System.Drawing.Size(127, 43);
            this.btnSelectComplaint.TabIndex = 33;
            this.btnSelectComplaint.Text = "View Complaint Profile";
            this.btnSelectComplaint.UseVisualStyleBackColor = true;
            this.btnSelectComplaint.Click += new System.EventHandler(this.btnSelectComplaint_Click);
            // 
            // ComplaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1256, 667);
            this.Controls.Add(this.btnSelectComplaint);
            this.Controls.Add(this.lblCompTotal);
            this.Controls.Add(this.btnAddComplaint);
            this.Controls.Add(this.btnCompClearFilters);
            this.Controls.Add(this.btnCompClearSorts);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bindNavComplaints);
            this.Controls.Add(this.dgvComplaints);
            this.Controls.Add(this.btnDeleteComplaint);
            this.Controls.Add(this.btnUpdateComplaint);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbCustomerProfile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ComplaintForm";
            this.Text = "ComplaintForm";
            this.Load += new System.EventHandler(this.ComplaintForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCustomerProfile.ResumeLayout(false);
            this.grbCustomerProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcComplaints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindNavComplaints)).EndInit();
            this.bindNavComplaints.ResumeLayout(false);
            this.bindNavComplaints.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteComplaint;
        private System.Windows.Forms.Button btnUpdateComplaint;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCustExp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grbCustomerProfile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCompDesc;
        private System.Windows.Forms.TextBox txtCompType;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtCompNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvComplaints;
        private System.Windows.Forms.BindingSource bindSrcComplaints;
        private System.Windows.Forms.BindingNavigator bindNavComplaints;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnCompClearFilters;
        private System.Windows.Forms.Button btnCompClearSorts;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpResolutionDate;
        private System.Windows.Forms.DateTimePicker dtpDateRecorded;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboComplaintType;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnResolutionDate;
        private System.Windows.Forms.Button btnComplaintType;
        private System.Windows.Forms.Button btnDateRecorded;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSortCustomerId;
        private System.Windows.Forms.Button btnSortComplaintNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddComplaint;
        private System.Windows.Forms.Label lblCompTotal;
        private System.Windows.Forms.DateTimePicker dtpResolutionDateEnter;
        private System.Windows.Forms.DateTimePicker dtpDateOccured;
        private System.Windows.Forms.DateTimePicker dtpDateRecordedEnter;
        private System.Windows.Forms.Button btnSelectComplaint;
        private System.Windows.Forms.Label lblLastName;
    }
}