namespace ComplaintSys
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.label5 = new System.Windows.Forms.Label();
            this.grbCustomerProfile = new System.Windows.Forms.GroupBox();
            this.cboPrefix = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.bindNavCustomers = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindSrcCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.btnCustClearFilters = new System.Windows.Forms.Button();
            this.btnCustClearSorts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboFilterState = new System.Windows.Forms.ComboBox();
            this.cboFilterCity = new System.Windows.Forms.ComboBox();
            this.cboFilterGender = new System.Windows.Forms.ComboBox();
            this.cboFilterPrefix = new System.Windows.Forms.ComboBox();
            this.btnCity = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.btnPrefix = new System.Windows.Forms.Button();
            this.btnGender = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFirstName = new System.Windows.Forms.Button();
            this.btnLastName = new System.Windows.Forms.Button();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.lblCustTotal = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.grbCustomerProfile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindNavCustomers)).BeginInit();
            this.bindNavCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCustomers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(818, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 77);
            this.label5.TabIndex = 4;
            // 
            // grbCustomerProfile
            // 
            this.grbCustomerProfile.Controls.Add(this.cboPrefix);
            this.grbCustomerProfile.Controls.Add(this.cboGender);
            this.grbCustomerProfile.Controls.Add(this.label9);
            this.grbCustomerProfile.Controls.Add(this.txtFirstName);
            this.grbCustomerProfile.Controls.Add(this.txtLastName);
            this.grbCustomerProfile.Controls.Add(this.txtCustID);
            this.grbCustomerProfile.Controls.Add(this.label8);
            this.grbCustomerProfile.Controls.Add(this.label6);
            this.grbCustomerProfile.Controls.Add(this.label7);
            this.grbCustomerProfile.Controls.Add(this.label1);
            this.grbCustomerProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCustomerProfile.ForeColor = System.Drawing.Color.White;
            this.grbCustomerProfile.Location = new System.Drawing.Point(15, 8);
            this.grbCustomerProfile.Margin = new System.Windows.Forms.Padding(2);
            this.grbCustomerProfile.Name = "grbCustomerProfile";
            this.grbCustomerProfile.Padding = new System.Windows.Forms.Padding(2);
            this.grbCustomerProfile.Size = new System.Drawing.Size(228, 173);
            this.grbCustomerProfile.TabIndex = 6;
            this.grbCustomerProfile.TabStop = false;
            this.grbCustomerProfile.Text = "Customer Profile";
            // 
            // cboPrefix
            // 
            this.cboPrefix.FormattingEnabled = true;
            this.cboPrefix.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Miss",
            "Dr"});
            this.cboPrefix.Location = new System.Drawing.Point(115, 113);
            this.cboPrefix.Margin = new System.Windows.Forms.Padding(2);
            this.cboPrefix.Name = "cboPrefix";
            this.cboPrefix.Size = new System.Drawing.Size(90, 24);
            this.cboPrefix.TabIndex = 18;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cboGender.Location = new System.Drawing.Point(115, 140);
            this.cboGender.Margin = new System.Windows.Forms.Padding(2);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(90, 24);
            this.cboGender.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Gender: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(115, 86);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(90, 22);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(115, 59);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(90, 22);
            this.txtLastName.TabIndex = 8;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(115, 32);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(90, 22);
            this.txtCustID.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Last Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Prefix: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "First Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone No: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboState);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtZip);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(247, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(439, 173);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Information";
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "TX",
            "NY",
            "NJ"});
            this.cboState.Location = new System.Drawing.Point(79, 84);
            this.cboState.Margin = new System.Windows.Forms.Padding(2);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(90, 24);
            this.cboState.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(259, 57);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Email: ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(260, 89);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 11;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(79, 113);
            this.txtZip.Margin = new System.Windows.Forms.Padding(2);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(90, 22);
            this.txtZip.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(79, 59);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(90, 22);
            this.txtCity.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(79, 32);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(346, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "City: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 115);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Zip: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 87);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "State: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 32);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Address: ";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(15, 359);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(910, 190);
            this.dgvCustomers.TabIndex = 17;
            // 
            // bindNavCustomers
            // 
            this.bindNavCustomers.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindNavCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bindNavCustomers.CountItem = this.bindingNavigatorCountItem;
            this.bindNavCustomers.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindNavCustomers.Dock = System.Windows.Forms.DockStyle.None;
            this.bindNavCustomers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindNavCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindNavCustomers.Location = new System.Drawing.Point(15, 319);
            this.bindNavCustomers.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindNavCustomers.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindNavCustomers.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindNavCustomers.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindNavCustomers.Name = "bindNavCustomers";
            this.bindNavCustomers.PositionItem = this.bindingNavigatorPositionItem;
            this.bindNavCustomers.Size = new System.Drawing.Size(271, 27);
            this.bindNavCustomers.TabIndex = 18;
            this.bindNavCustomers.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(29, 23);
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
            // btnCustClearFilters
            // 
            this.btnCustClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustClearFilters.Location = new System.Drawing.Point(496, 211);
            this.btnCustClearFilters.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustClearFilters.Name = "btnCustClearFilters";
            this.btnCustClearFilters.Size = new System.Drawing.Size(70, 37);
            this.btnCustClearFilters.TabIndex = 23;
            this.btnCustClearFilters.Text = "Customers Clear Filters";
            this.btnCustClearFilters.UseVisualStyleBackColor = true;
            this.btnCustClearFilters.Click += new System.EventHandler(this.btnCustClearFilters_Click);
            // 
            // btnCustClearSorts
            // 
            this.btnCustClearSorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustClearSorts.Location = new System.Drawing.Point(412, 211);
            this.btnCustClearSorts.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustClearSorts.Name = "btnCustClearSorts";
            this.btnCustClearSorts.Size = new System.Drawing.Size(70, 37);
            this.btnCustClearSorts.TabIndex = 22;
            this.btnCustClearSorts.Text = "Customers Clear Sort";
            this.btnCustClearSorts.UseVisualStyleBackColor = true;
            this.btnCustClearSorts.Click += new System.EventHandler(this.btnCustClearSorts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1211, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "total: 100";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboFilterState);
            this.groupBox2.Controls.Add(this.cboFilterCity);
            this.groupBox2.Controls.Add(this.cboFilterGender);
            this.groupBox2.Controls.Add(this.cboFilterPrefix);
            this.groupBox2.Controls.Add(this.btnCity);
            this.groupBox2.Controls.Add(this.btnState);
            this.groupBox2.Controls.Add(this.btnPrefix);
            this.groupBox2.Controls.Add(this.btnGender);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 195);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(228, 126);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // cboFilterState
            // 
            this.cboFilterState.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilterState.FormattingEnabled = true;
            this.cboFilterState.Location = new System.Drawing.Point(117, 91);
            this.cboFilterState.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterState.Name = "cboFilterState";
            this.cboFilterState.Size = new System.Drawing.Size(82, 20);
            this.cboFilterState.TabIndex = 7;
            // 
            // cboFilterCity
            // 
            this.cboFilterCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilterCity.FormattingEnabled = true;
            this.cboFilterCity.Location = new System.Drawing.Point(117, 66);
            this.cboFilterCity.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterCity.Name = "cboFilterCity";
            this.cboFilterCity.Size = new System.Drawing.Size(82, 20);
            this.cboFilterCity.TabIndex = 6;
            // 
            // cboFilterGender
            // 
            this.cboFilterGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilterGender.FormattingEnabled = true;
            this.cboFilterGender.Location = new System.Drawing.Point(117, 42);
            this.cboFilterGender.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterGender.Name = "cboFilterGender";
            this.cboFilterGender.Size = new System.Drawing.Size(82, 20);
            this.cboFilterGender.TabIndex = 5;
            // 
            // cboFilterPrefix
            // 
            this.cboFilterPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilterPrefix.FormattingEnabled = true;
            this.cboFilterPrefix.Location = new System.Drawing.Point(117, 17);
            this.cboFilterPrefix.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterPrefix.Name = "cboFilterPrefix";
            this.cboFilterPrefix.Size = new System.Drawing.Size(82, 20);
            this.cboFilterPrefix.TabIndex = 4;
            // 
            // btnCity
            // 
            this.btnCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCity.Location = new System.Drawing.Point(25, 66);
            this.btnCity.Margin = new System.Windows.Forms.Padding(2);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(81, 20);
            this.btnCity.TabIndex = 3;
            this.btnCity.Text = "City";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // btnState
            // 
            this.btnState.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnState.Location = new System.Drawing.Point(25, 90);
            this.btnState.Margin = new System.Windows.Forms.Padding(2);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(81, 20);
            this.btnState.TabIndex = 2;
            this.btnState.Text = "State";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // btnPrefix
            // 
            this.btnPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrefix.Location = new System.Drawing.Point(25, 16);
            this.btnPrefix.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrefix.Name = "btnPrefix";
            this.btnPrefix.Size = new System.Drawing.Size(81, 20);
            this.btnPrefix.TabIndex = 1;
            this.btnPrefix.Text = "Prefix";
            this.btnPrefix.UseVisualStyleBackColor = true;
            this.btnPrefix.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // btnGender
            // 
            this.btnGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGender.Location = new System.Drawing.Point(25, 41);
            this.btnGender.Margin = new System.Windows.Forms.Padding(2);
            this.btnGender.Name = "btnGender";
            this.btnGender.Size = new System.Drawing.Size(81, 20);
            this.btnGender.TabIndex = 0;
            this.btnGender.Text = "Gender";
            this.btnGender.UseVisualStyleBackColor = true;
            this.btnGender.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFirstName);
            this.groupBox3.Controls.Add(this.btnLastName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(259, 195);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(133, 65);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort";
            // 
            // btnFirstName
            // 
            this.btnFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstName.Location = new System.Drawing.Point(25, 40);
            this.btnFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstName.Name = "btnFirstName";
            this.btnFirstName.Size = new System.Drawing.Size(81, 20);
            this.btnFirstName.TabIndex = 1;
            this.btnFirstName.Text = "FirstName";
            this.btnFirstName.UseVisualStyleBackColor = true;
            this.btnFirstName.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // btnLastName
            // 
            this.btnLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastName.Location = new System.Drawing.Point(25, 17);
            this.btnLastName.Margin = new System.Windows.Forms.Padding(2);
            this.btnLastName.Name = "btnLastName";
            this.btnLastName.Size = new System.Drawing.Size(81, 20);
            this.btnLastName.TabIndex = 0;
            this.btnLastName.Text = "LastName";
            this.btnLastName.UseVisualStyleBackColor = true;
            this.btnLastName.Click += new System.EventHandler(this.filterAndSortButton_Click);
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCustomer.Location = new System.Drawing.Point(690, 191);
            this.btnSelectCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(95, 35);
            this.btnSelectCustomer.TabIndex = 32;
            this.btnSelectCustomer.Text = "View Customer Profile";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(690, 103);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(95, 35);
            this.btnAddCustomer.TabIndex = 31;
            this.btnAddCustomer.Text = "Add \r\nCustomer";
            this.btnAddCustomer.UseMnemonic = false;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(690, 147);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(95, 35);
            this.btnDeleteCustomer.TabIndex = 30;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(690, 59);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(95, 35);
            this.btnUpdateCustomer.TabIndex = 29;
            this.btnUpdateCustomer.Text = "Update Customer Data";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.Location = new System.Drawing.Point(690, 15);
            this.btnClearData.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(95, 35);
            this.btnClearData.TabIndex = 28;
            this.btnClearData.Text = "Clear Customer Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // lblCustTotal
            // 
            this.lblCustTotal.AutoSize = true;
            this.lblCustTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustTotal.Location = new System.Drawing.Point(880, 330);
            this.lblCustTotal.Name = "lblCustTotal";
            this.lblCustTotal.Size = new System.Drawing.Size(32, 13);
            this.lblCustTotal.TabIndex = 34;
            this.lblCustTotal.Text = "total";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(773, 330);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 13);
            this.label.TabIndex = 33;
            this.label.Text = "Customer Total: ";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(936, 561);
            this.Controls.Add(this.lblCustTotal);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnCustClearFilters);
            this.Controls.Add(this.btnCustClearSorts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bindNavCustomers);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbCustomerProfile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.grbCustomerProfile.ResumeLayout(false);
            this.grbCustomerProfile.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindNavCustomers)).EndInit();
            this.bindNavCustomers.ResumeLayout(false);
            this.bindNavCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCustomers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbCustomerProfile;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.BindingSource bindSrcCustomers;
        private System.Windows.Forms.BindingNavigator bindNavCustomers;
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
        private System.Windows.Forms.Button btnCustClearFilters;
        private System.Windows.Forms.Button btnCustClearSorts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboFilterState;
        private System.Windows.Forms.ComboBox cboFilterCity;
        private System.Windows.Forms.ComboBox cboFilterGender;
        private System.Windows.Forms.ComboBox cboFilterPrefix;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnPrefix;
        private System.Windows.Forms.Button btnGender;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFirstName;
        private System.Windows.Forms.Button btnLastName;
        private System.Windows.Forms.ComboBox cboPrefix;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Label lblCustTotal;
        private System.Windows.Forms.Label label;
    }
}