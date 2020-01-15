using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplaintSys
{
    public partial class CustomerForm : Form
    {

        string[] customerHeaders = new string[]
        {
            "Customer ID", "Last Name", "First Name", "Prefix", "Gender", "Address",
            "City", "State", "Zip", "Phone No", "Email"
        };
        
        public static BindingList<Customer> sortCustomerFieldsList = MainForm.customers;



        public CustomerForm()
        {
            InitializeComponent();

        }

        Button[] filterButtons, sortButtons;

        /// <summary>
        /// Loads the form for viewing
        /// </summary>
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ChangeApplicationResolution();

            //bindSrcCustomers.DataSource = MainForm.customers;
            bindSrcCustomers.DataSource = sortCustomerFieldsList;

            dgvCustomers.DataSource = bindSrcCustomers;

            bindNavCustomers.BindingSource = bindSrcCustomers;

            cboFilterPrefix.DataSource = MainForm.prefixDs;
            cboFilterCity.DataSource = MainForm.cityDs;
            cboFilterGender.DataSource = MainForm.genderDs;
            cboFilterState.DataSource = MainForm.stateDs;

            cboState.DataSource = MainForm.stateDs;

            filterButtons = new Button[] { btnPrefix, btnGender, btnCity, btnState };
            sortButtons = new Button[] { btnLastName, btnFirstName };

            //Loads sample data on form
            LoadInitialValues();

            //Displays total customers
            lblCustTotal.Text = Customer.TotalCustomers.ToString();

            //Disable the highlighted customer initially
            dgvCustomers.Rows[0].Selected = false;

            dgvCustomers.ClearSelection();
            dgvCustomers.CurrentCell = null;

            //Method to format data grid
            FormatDataGridView();



        }

        /// <summary>
        /// Formats the grid view
        /// </summary>
        private void FormatDataGridView()
        {
            //Format grid view to set widths
            dgvCustomers.Columns[0].Width = 100;
            dgvCustomers.Columns[1].Width = 95;
            dgvCustomers.Columns[2].Width = 95;
            dgvCustomers.Columns[3].Width = 50;
            dgvCustomers.Columns[4].Width = 50;
            dgvCustomers.Columns[5].Width = 145;
            dgvCustomers.Columns[6].Width = 50;
            dgvCustomers.Columns[7].Width = 50;
            dgvCustomers.Columns[8].Width = 50;
            dgvCustomers.Columns[9].Width = 100;
            dgvCustomers.Columns[10].Width = 125;

            //Format grid view to set specific alignment per instructions
            dgvCustomers.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomers.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCustomers.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCustomers.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomers.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomers.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCustomers.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCustomers.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomers.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomers.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCustomers.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Format header names
            dgvCustomers.Columns[0].HeaderText = "Customer ID";
            dgvCustomers.Columns[1].HeaderText = "Last Name";
            dgvCustomers.Columns[2].HeaderText = "First Name";
            dgvCustomers.Columns[9].HeaderText = "Phone No";

            //Freeze important columns for scrolling 
            dgvCustomers.Columns[0].Frozen = true;
            dgvCustomers.Columns[1].Frozen = true;

            //Give frozen columns a distinct color
            dgvCustomers.Columns[0].DefaultCellStyle.ForeColor = Color.DarkOrange;
            dgvCustomers.Columns[1].DefaultCellStyle.ForeColor = Color.DarkOrange;

        }

        /// <summary>
        /// Loads initial information from Main Form
        /// </summary>
        private void LoadInitialValues()
        {
            //Variable for determining where the user clicked
            int rowNum;

            //Find's the row# where the app is currently highlighted
            rowNum = dgvCustomers.CurrentCellAddress.Y;

            //Use the row# to populate the customer data information cells
            txtCustID.Text = MainForm.customers[rowNum].CustomerId.ToString();
            txtLastName.Text = MainForm.customers[rowNum].LastName;
            txtFirstName.Text = MainForm.customers[rowNum].FirstName;
            cboPrefix.Text = MainForm.customers[rowNum].Prefix;
            cboGender.Text = MainForm.customers[rowNum].Gender;
            txtAddress.Text = MainForm.customers[rowNum].Address;
            txtCity.Text = MainForm.customers[rowNum].City;
            cboState.Text = MainForm.customers[rowNum].State;
            txtZip.Text = MainForm.customers[rowNum].Zip.ToString();
            txtPhone.Text = MainForm.customers[rowNum].Phone;
            txtEmail.Text = MainForm.customers[rowNum].Email;


        }

        /// <summary>
        /// Changes resolution of the application
        /// </summary>
        private void ChangeApplicationResolution()
        {
            int formWidth = 980;
            int formHeigth = 605;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Size = new System.Drawing.Size(formWidth, formHeigth);
            this.CenterToScreen();
        }

        /// <summary>
        /// Filters and sorts data by variables selected by user
        /// </summary>
        private void filterAndSortButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeButtonColor(sender);

            //sortCustomerFieldsList = MainForm.customers.ToList<Customer>();
            sortCustomerFieldsList = MainForm.customers;

            //filter
            if (btnPrefix.ForeColor == Color.Red) sortCustomerFieldsList = new BindingList<Customer>(sortCustomerFieldsList.Where(p => p.Prefix == cboFilterPrefix.Text).ToList<Customer>());
            if (btnGender.ForeColor == Color.Red) sortCustomerFieldsList = new BindingList<Customer>(sortCustomerFieldsList.Where(p => p.Gender == cboFilterGender.Text).ToList<Customer>());
            if (btnCity.ForeColor == Color.Red) sortCustomerFieldsList = new BindingList<Customer>(sortCustomerFieldsList.Where(p => p.City == cboFilterCity.Text).ToList<Customer>());
            if (btnState.ForeColor == Color.Red) sortCustomerFieldsList = new BindingList<Customer>(sortCustomerFieldsList.Where(p => p.State == cboFilterState.Text).ToList<Customer>());


            //sort
            if (btnLastName.ForeColor == Color.Red) sortCustomerFieldsList = new BindingList<Customer>(sortCustomerFieldsList.OrderBy(p => p.LastName).ToList<Customer>());
            if (btnFirstName.ForeColor == Color.Red) sortCustomerFieldsList = new BindingList<Customer>(sortCustomerFieldsList.OrderBy(p => p.FirstName).ToList<Customer>());
            if (btnLastName.ForeColor == Color.Red && sender == btnLastName) sortCustomerFieldsList = new BindingList<Customer>(sortCustomerFieldsList.OrderBy(p => p.LastName).ToList<Customer>());
            if (btnFirstName.ForeColor == Color.Red && sender == btnFirstName) sortCustomerFieldsList = new BindingList<Customer>(sortCustomerFieldsList.OrderBy(p => p.FirstName).ToList<Customer>());

            bindSrcCustomers.DataSource = sortCustomerFieldsList;
        }

        /// <summary>
        /// Clears established sorts
        /// </summary>
        private void btnCustClearSorts_Click(object sender, EventArgs e)
        {
            foreach (Button b in sortButtons) b.ForeColor = Color.Black;
            LoadInitialData();
        }

        /// <summary>
        /// Clears established filters
        /// </summary>
        private void btnCustClearFilters_Click(object sender, EventArgs e)
        {
            foreach (Button b in filterButtons) b.ForeColor = Color.Black;
            LoadInitialData();
        }

        /// <summary>
        /// Establishes if Customer ID has already been designated
        /// </summary>
        /// <param name="ID">String used as unique identifier for customer record</param>
        /// <returns>boolean value true if a duplicate exists</returns>
        private bool duplicateCustomerIdExists(string ID)
        {
            foreach(Customer c in MainForm.customers)
            {
                if (c.CustomerId.ToString() == ID) return true;
            }
            return false;
        }

        /// <summary>
        /// Adds customer to file if data is valid
        /// </summary>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            //Validation
            bool isValid = ValidateFormData();
            if (isValid == false)
            {
                return;
            }

            if (duplicateCustomerIdExists(txtCustID.Text))
            {
                MessageBox.Show("Customer ID already exists!");
                return;
            }

            //Create a customer object
            Customer c = new Customer();

            //Fill the object
            if (txtCustID.Text == "")
            {
                Random random = new Random();
                c.CustomerId = random.Next(999, 9999);
            }
            else
            {
                c.CustomerId = Convert.ToInt32(txtCustID.Text);
            }

            c.LastName = txtLastName.Text;
            c.FirstName = txtFirstName.Text;
            c.Prefix = cboPrefix.Text;
            c.Gender = cboGender.Text;
            c.Address = txtAddress.Text;
            c.City = txtCity.Text;
            c.State = cboState.Text;
            c.Zip = Convert.ToInt32(txtZip.Text);
            c.Phone = txtPhone.Text;
            c.Email = txtEmail.Text;

            //Update the total number of customers based on the above addition
            lblCustTotal.Text = Customer.TotalCustomers.ToString();

            //Add customer object to the list
            MainForm.customers.Add(c);


        }

        /// <summary>
        /// Deletes customer data
        /// </summary>
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            //Variable for forcing user to make selection of the customer to be deleted.  
            string sugError = "Delete Customer - Error!";

            //For loop to prompt user to select a customer to be deleted.
            if (dgvCustomers.CurrentRow.Selected == false)
            {
                MessageBox.Show(sugError, "Please select a customer you wish to delete. ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string custID = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCellAddress.Y].Cells[0].Value);
                string custFirst = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCellAddress.Y].Cells[2].Value);
                string custLast = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCellAddress.Y].Cells[1].Value);
                MessageBox.Show(custID + " - " + custFirst + " " + custLast + " is the customer you have selected to delete. ");

            }

            //Variables for customer object deletion
            int rowNum;

            //Prevent app from crashing if zero customers are left to delete
            if (MainForm.customers.Count == 0)
            {
                return;
            }

            //Provides the row# where the user clicked currently
            rowNum = dgvCustomers.CurrentCellAddress.Y;

            //Delete customer based on current row selection using RemoveAt()
            MainForm.customers.RemoveAt(rowNum);

            //Update the total customers label after the deletion
            lblCustTotal.Text = (--Customer.TotalCustomers).ToString();

        }
        /// <summary>
        /// Updates selected record with data from text boxes, if valid
        /// </summary>
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            //Validation
            bool isValid2 = ValidateFormData2();
            if (isValid2 == false)
            {
                return;
            }

            //Variable for selecting a particular customer from grid
            int rowNum;

            //Find's the row# where the user clicked
            rowNum = dgvCustomers.CurrentCellAddress.Y;

            if (MainForm.customers[rowNum].CustomerId.ToString() != txtCustID.Text && duplicateCustomerIdExists(txtCustID.Text))
            {
                MessageBox.Show("Customer ID already exists!");
                return;
            }

            //Variable for forcing user to make selection of the customer to be updated.  
            string sugError = "Update Customer - Error!";

            //For loop to prompt user to select a customer to be updated. 
            if (dgvCustomers.CurrentRow.Selected == false)
            {
                MessageBox.Show(sugError, "Please select a customer you wish to update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string custID = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCellAddress.Y].Cells[0].Value);
                string custFirst = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCellAddress.Y].Cells[2].Value);
                string custLast = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCellAddress.Y].Cells[1].Value);
                MessageBox.Show(custID + " - " + custFirst + " " + custLast + " is the customer you have selected to update. ");

            }

            
            

            //Swaps out the input data back into the customer list location where it was clicked
            if (txtCustID.Text != "")
            {
                MainForm.customers[rowNum].CustomerId = Convert.ToInt32(txtCustID.Text);
            }
            if (txtLastName.Text != "")
            {
                MainForm.customers[rowNum].LastName = txtLastName.Text;
            }
            if (txtFirstName.Text != "")
            {
                MainForm.customers[rowNum].FirstName = txtFirstName.Text;
            }
            if (cboPrefix.Text != "")
            {
                MainForm.customers[rowNum].Prefix = cboPrefix.Text;
            }
            if (cboGender.Text != "")
            {
                MainForm.customers[rowNum].Gender = cboGender.Text;
            }
            if (txtAddress.Text != "")
            {
                MainForm.customers[rowNum].Address = txtAddress.Text;
            }
            if (txtCity.Text != "")
            {
                MainForm.customers[rowNum].City = txtCity.Text;
            }
            if (cboState.Text != "")
            {
                MainForm.customers[rowNum].State = cboState.Text;
            }
            if (txtZip.Text != "")
            {
                MainForm.customers[rowNum].Zip = Convert.ToInt32(txtZip.Text);
            }
            if (txtPhone.Text != "")
            {
                MainForm.customers[rowNum].Phone = txtPhone.Text;
            }
            if (txtEmail.Text != "")
            {
                MainForm.customers[rowNum].Email = txtEmail.Text;
            }

            //Makes the data grid recalculate after updating
            MainForm.customers.ResetBindings();
        }

        /// <summary>
        /// Selects record indicated by user for further viewing
        /// </summary>
        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            //Variable for forcing user to make selection of the customer to be viewed.  
            string sugError = "View Customer Profile - Error!";

            //For loop to prompt user to select a customer to be viewed.
            //if (dgvCustomers.CurrentRow.Selected == false)
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show(sugError, "Please select a customer you wish to view. ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //Variable for selecting a particular customer from grid
            int rowNum;

            //Find's the row# where the user clicked
            rowNum = dgvCustomers.CurrentCellAddress.Y;

            //Use the row# to populate the customer data information cells
            txtCustID.Text = sortCustomerFieldsList[rowNum].CustomerId.ToString();
            txtLastName.Text = sortCustomerFieldsList[rowNum].LastName;
            txtFirstName.Text = sortCustomerFieldsList[rowNum].FirstName;
            cboPrefix.Text = sortCustomerFieldsList[rowNum].Prefix;
            cboGender.Text = sortCustomerFieldsList[rowNum].Gender;
            txtAddress.Text = sortCustomerFieldsList[rowNum].Address;
            txtCity.Text = sortCustomerFieldsList[rowNum].City;
            cboState.Text = sortCustomerFieldsList[rowNum].State;
            txtZip.Text = sortCustomerFieldsList[rowNum].Zip.ToString();
            txtPhone.Text = sortCustomerFieldsList[rowNum].Phone;
            txtEmail.Text = sortCustomerFieldsList[rowNum].Email;
            
        }

        /// <summary>
        /// Loads data from Main Form
        /// </summary>
        private void LoadInitialData()
        {
            //sortCustomerFieldsList = MainForm.customers.ToList<Customer>();
            sortCustomerFieldsList = MainForm.customers;
            bindSrcCustomers.DataSource = sortCustomerFieldsList;
        }

        /// <summary>
        /// Clears data in text boxes
        /// </summary>
        private void btnClearData_Click(object sender, EventArgs e)
        {
            //Reset Background Color
            ResetBackgroundColor();

            //Clear all data in the fields for customer
            txtCustID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            cboState.Text = "";
            txtZip.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cboPrefix.Text = "";
            cboGender.Text = "";


        }
        
        /// <summary>
        /// Validates that data in text boxes is valid
        /// </summary>
        /// <returns>boolean value indicating that data is valid</returns>
        private bool ValidateFormData()
        {
            bool isValid = true;
            string msg = "Please correct the following issues:\n";
            
            //Reset background
            ResetBackgroundColor();

            //Validate text box entries are not empty
            
            if (txtLastName.Text == "")
            {
                msg += "   All entries must contain a value! Enter a value for last name.\n";
                isValid = false;
                txtLastName.BackColor = Color.Pink;
            }
            if (txtFirstName.Text == "")
            {
                msg += "   All entries must contain a value! Enter a value for first name.\n";
                isValid = false;
                txtFirstName.BackColor = Color.Pink;
            }
            if (txtAddress.Text == "")
            {
                msg += "   All entries must contain a value! Enter a value for address.\n";
                isValid = false;
                txtAddress.BackColor = Color.Pink;
            }
            if (txtCity.Text == "")
            {
                msg += "   All entries must contain a value! Enter a value for city.\n";
                isValid = false;
                txtCity.BackColor = Color.Pink;
            }
            if (txtZip.Text == "")
            {
                msg += "   All entries must contain a value! Enter a value for zip code.\n";
                isValid = false;
                txtZip.BackColor = Color.Pink;
            }
            
            //Validate text box entries are not integer values
            
            int lastName;
            int firstName;
            int address;
            int city;
            int email;
            
            if (int.TryParse(txtLastName.Text, out lastName))
            {
                msg += "   Must contain a valid value! Enter a valid value for last name.\n";
                isValid = false;
                txtLastName.BackColor = Color.Pink;
            }
            if (int.TryParse(txtFirstName.Text, out firstName))
            {
                msg += "   Must contain a valid value! Enter a valid value for first name.\n";
                isValid = false;
                txtFirstName.BackColor = Color.Pink;
            }
            if (int.TryParse(txtAddress.Text, out address))
            {
                msg += "   Must contain a valid value! Enter a valid value for address.\n";
                isValid = false;
                txtAddress.BackColor = Color.Pink;
            }
            if (int.TryParse(txtCity.Text, out city))
            {
                msg += "   Must contain a valid value! Enter a valid value for city.\n";
                isValid = false;
                txtCity.BackColor = Color.Pink;
            }
                        
            if (int.TryParse(txtEmail.Text, out email))
            {
                msg += "   Must contain a valid value! Enter a valid value for email.\n";
                isValid = false;
                txtEmail.BackColor = Color.Pink;
            }

            //Validate is an integer
            int custID;
            int zip;

            if (txtCustID.Text != "" && !int.TryParse(txtCustID.Text, out custID))
            {
                msg += "   Invalid entry for customer ID! Re-enter a valid numeric value for customer ID.\n";
                isValid = false;
                txtCustID.BackColor = Color.Pink;
            }
            if (!int.TryParse(txtZip.Text, out zip))
            {
                msg += "   Invalid entry for zip code! Re-enter a valid numeric value for zip code.\n";
                isValid = false;
                txtZip.BackColor = Color.Pink;
            }

            //Validate Phone Number
            int phone;

            if (int.TryParse(txtPhone.Text, out phone) || Convert.ToString(txtPhone.Text).Length != 10)
            {
                msg += "   Invalid entry for phone number! Re-enter a valid ten digit value for phone number.\n";
                isValid = false;
                txtPhone.BackColor = Color.Pink;
            }

            //test if ANY were invalid
            if (!isValid)
            {
                MessageBox.Show(msg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return isValid;

        }

        /// <summary>
        /// Validates that data in text boxes is valid
        /// </summary>
        /// <returns>boolean value indicating that data is valid</returns>
        private bool ValidateFormData2()
        {
            bool isValid2 = true;
            string msg = "Please correct the following issues:\n";
            
            //Reset background
            ResetBackgroundColor();

            //Validate text box entries are not integer values
            
            int lastName2;
            int firstName2;
            int address2;
            int city2;
            int email2;

            
            if (int.TryParse(txtLastName.Text, out lastName2))
            {
                msg += "   Must contain a valid value! Enter a valid value for last name.\n";
                isValid2 = false;
                txtLastName.BackColor = Color.Pink;
            }
            if (int.TryParse(txtFirstName.Text, out firstName2))
            {
                msg += "   Must contain a valid value! Enter a valid value for first name.\n";
                isValid2 = false;
                txtFirstName.BackColor = Color.Pink;
            }
            if (int.TryParse(txtAddress.Text, out address2))
            {
                msg += "   Must contain a valid value! Enter a valid value for address.\n";
                isValid2 = false;
                txtAddress.BackColor = Color.Pink;
            }
            if (int.TryParse(txtCity.Text, out city2))
            {
                msg += "   Must contain a valid value! Enter a valid value for city.\n";
                isValid2 = false;
                txtCity.BackColor = Color.Pink;
            }
                        
            if (int.TryParse(txtEmail.Text, out email2))
            {
                msg += "   Must contain a valid value! Enter a valid value for email.\n";
                isValid2 = false;
                txtEmail.BackColor = Color.Pink;
            }


            //Validate is an integer
            int custID2;
            int zip2;

            if (txtCustID.Text != "" && !int.TryParse(txtCustID.Text, out custID2))
            {
                msg += "   Invalid entry for customer ID! Re-enter a valid numeric value for customer ID.\n";
                isValid2 = false;
                txtCustID.BackColor = Color.Pink;
            }
            if (txtZip.Text != "" && !int.TryParse(txtZip.Text, out zip2))
            {
                msg += "   Invalid entry for zip code! Re-enter a valid numeric value for zip code.\n";
                isValid2 = false;
                txtZip.BackColor = Color.Pink;
            }

            //Validate Phone Number
            int phone2;

            if (int.TryParse(txtPhone.Text, out phone2) || txtPhone.Text != "" && Convert.ToString(txtPhone.Text).Length != 10)
            {
                msg += "   Invalid entry for phone number! Re-enter a valid ten digit value for phone number.\n";
                isValid2 = false;
                txtPhone.BackColor = Color.Pink;
            }

            //test if ANY were invalid
            if (!isValid2)
            {
                MessageBox.Show(msg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return isValid2;

        }

        /// <summary>
        /// Resets the background color of the text boxes
        /// </summary>
        private void ResetBackgroundColor()
        {
            //Reset background
            txtCustID.BackColor = Color.White;
            txtLastName.BackColor = Color.White;
            txtFirstName.BackColor = Color.White;
            txtAddress.BackColor = Color.White;
            txtCity.BackColor = Color.White;
            cboState.BackColor = Color.White;
            txtZip.BackColor = Color.White;
            txtPhone.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
        }


    }
}
