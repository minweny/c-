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
    public partial class ComplaintForm : Form
    {

        string[] complaintHeaders = new string[]
        {
            "Complaint No", "Customer ID", "Type", "Description", "Record Date", "Occurred Date",
            "Expectation", "Status", "Resolution Date", "Resolution Desc."
        };

        //public static List<Complaint> sortComplaintFieldsList = MainForm.complaints.ToList<Complaint>();
        public static BindingList<Complaint> sortComplaintFieldsList = MainForm.complaints;

        public ComplaintForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Creates the Complaint form upon opening, formatting view and loading data
        /// </summary>
         private void ComplaintForm_Load(object sender, EventArgs e)
        {

            //Clear Label
            lblLastName.Text = "";

            ChangeApplicationResolution();

            bindSrcComplaints.DataSource = MainForm.complaints;

            dgvComplaints.DataSource = bindSrcComplaints;

            bindNavComplaints.BindingSource = bindSrcComplaints;

            //load combobox
            cboComplaintType.DataSource = MainForm.complaintTypeDs;
            cboStatus.DataSource = MainForm.complaintStatusDs;

            filterButtons = new Button[] { btnComplaintType, btnDateRecorded, btnStatus, btnResolutionDate };
            sortButtons = new Button[] { btnSortComplaintNo, btnSortCustomerId };

            lblCompTotal.Text = Complaint.TotalComplaints.ToString();

            dtpResolutionDateEnter.ShowCheckBox = true;
            dtpDateRecordedEnter.ShowCheckBox = true;
            dtpDateOccured.ShowCheckBox = true;

            //Method to format data grid
            FormatDataGridView();

        }

        /// <summary>
        /// Establishes Grid View formats for the data populated in it
        /// </summary>
        private void FormatDataGridView()
        {
            //Format grid view to set widths
            dgvComplaints.Columns[0].Width = 100;
            dgvComplaints.Columns[1].Width = 100;
            dgvComplaints.Columns[2].Width = 100;
            dgvComplaints.Columns[3].Width = 150;
            dgvComplaints.Columns[4].Width = 120;
            dgvComplaints.Columns[5].Width = 120;
            dgvComplaints.Columns[6].Width = 100;
            dgvComplaints.Columns[7].Width = 100;
            dgvComplaints.Columns[8].Width = 100;
            dgvComplaints.Columns[9].Width = 120;
            
            //Format grid view to set specific alignment per instructions
            dgvComplaints.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvComplaints.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvComplaints.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvComplaints.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvComplaints.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvComplaints.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvComplaints.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvComplaints.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvComplaints.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvComplaints.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            //Format header names
            dgvComplaints.Columns[0].HeaderText = "Complaint No";
            dgvComplaints.Columns[1].HeaderText = "Customer ID";
            dgvComplaints.Columns[3].HeaderText = "Complaint Description";
            dgvComplaints.Columns[6].HeaderText = "Customer Expectation";

            //Freeze important columns for scrolling 
            dgvComplaints.Columns[0].Frozen = true;
            dgvComplaints.Columns[1].Frozen = true;

            //Give frozen columns a distinct color
            dgvComplaints.Columns[0].DefaultCellStyle.ForeColor = Color.DarkOrange;
            dgvComplaints.Columns[1].DefaultCellStyle.ForeColor = Color.DarkOrange;

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

        Button[] filterButtons, sortButtons;

        /// <summary>
        /// Clears the filters set by user
        /// </summary>
        private void btnCompClearFilters_Click(object sender, EventArgs e)
        {
            LoadInitialData();
            foreach (Button b in filterButtons) b.ForeColor = Color.Black;
        }

        /// <summary>
        /// Adds sorting and filtering to data view as desired by user
        /// </summary>
        private void filterAndSortButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeButtonColor(sender);
            sortComplaintFieldsList = MainForm.complaints;

            //filter
            if (btnComplaintType.ForeColor == Color.Red) sortComplaintFieldsList = new BindingList<Complaint>( sortComplaintFieldsList.Where(p => p.ComplaintType == cboComplaintType.Text).ToList<Complaint>());
            if(btnDateRecorded.ForeColor == Color.Red) sortComplaintFieldsList = new BindingList<Complaint>(sortComplaintFieldsList.Where(p => p.DateRecorded.ToShortDateString() == dtpDateRecorded.Value.ToShortDateString()).ToList<Complaint>());
            if (btnStatus.ForeColor == Color.Red) sortComplaintFieldsList = new BindingList<Complaint>(sortComplaintFieldsList.Where(p => p.Status == cboStatus.Text).ToList<Complaint>());
            if (btnResolutionDate.ForeColor == Color.Red) sortComplaintFieldsList = new BindingList<Complaint>(sortComplaintFieldsList.Where(p => p.ResolutionDate.HasValue? p.ResolutionDate.Value.ToShortDateString() == dtpResolutionDate.Value.ToShortDateString() : false).ToList<Complaint>());

            //sort
            if (btnSortComplaintNo.ForeColor == Color.Red)
            {
                sortComplaintFieldsList = new BindingList<Complaint>(sortComplaintFieldsList.OrderBy(p => p.ComplaintNo).ToList<Complaint>());
            }
            else if (btnSortCustomerId.ForeColor == Color.Red)
            {
                sortComplaintFieldsList = new BindingList<Complaint>(sortComplaintFieldsList.OrderBy(p => p.CustomerId).ToList<Complaint>());
            }

            if (sender == btnSortComplaintNo && btnSortComplaintNo.ForeColor == Color.Red)
            {
                sortComplaintFieldsList = new BindingList<Complaint>(sortComplaintFieldsList.OrderBy(p => p.ComplaintNo).ToList<Complaint>());
            }
            else if (sender == btnSortCustomerId && btnSortCustomerId.ForeColor == Color.Red)
            {
                sortComplaintFieldsList = new BindingList<Complaint>(sortComplaintFieldsList.OrderBy(p => p.CustomerId).ToList<Complaint>());
            }

            bindSrcComplaints.DataSource = sortComplaintFieldsList;
                                   
        }

        /// <summary>
        /// Clears sorts indicated by user
        /// </summary>
        private void btnCompClearSorts_Click(object sender, EventArgs e)
        {
            LoadInitialData();
            foreach (Button b in sortButtons) b.ForeColor = Color.Black;
        }

        /// <summary>
        /// Checks to see if complaint number is already present in the system
        /// </summary>
        /// <param name="complaintNo">Unique number from the complaint file</param>
        /// <returns>True value if duplicate number exists</returns>
        private bool duplicateNoExists(string complaintNo)
        {
            foreach(Complaint c in MainForm.complaints)
            {
                if (c.ComplaintNo.ToString() == complaintNo) return true;
                
            }
            return false;
        }

        /// <summary>
        /// Adds complaint to file from text in text boxes on form
        /// </summary>
        private void btnAddComplaint_Click(object sender, EventArgs e)
        {

            //Validation
            bool isValid = ValidateFormData();
            if (isValid == false)
            {
                return;
            }

            if (duplicateNoExists(txtCompNo.Text))
            {
                MessageBox.Show("ComplaintNo already exists!");
                return;
            }

            //Create a complaint object
            Complaint c = new Complaint();

            //Declare Variables
            int compNO;
            int custID;

            //Fill the object
            if (txtCompNo.Text == "")
            {
                c.ComplaintNo = Complaint.TotalComplaints++;

            }
            else
            {
                if (txtCompNo.Text != "" && !int.TryParse(txtCompNo.Text, out compNO))
                {
                    c.ComplaintNo = Complaint.TotalComplaints++;
                }
                else
                {
                    c.ComplaintNo = Convert.ToInt32(txtCompNo.Text);
                }
            }
            if (txtCustID.Text == "")
            {
                Random random = new Random();
                c.CustomerId = random.Next(999, 9999);
            }
            else
            {
                if (txtCustID.Text != "" && !int.TryParse(txtCustID.Text, out custID))
                {
                    Random random = new Random();
                    c.CustomerId = random.Next(999, 9999);
                }
                else
                {
                    c.CustomerId = Convert.ToInt32(txtCustID.Text);
                }

            }

            c.ComplaintType = txtCompType.Text;
            c.CustExpectation = txtCustExp.Text;
            c.Status = txtStatus.Text;
            c.ComplaintDesc = txtCompDesc.Text;
            c.ResolutionDesc = txtResDesc.Text;
            c.ResolutionDate = Convert.ToDateTime(dtpResolutionDateEnter.Text);
            c.DateRecorded = Convert.ToDateTime(dtpDateRecordedEnter.Text);
            c.DateOccurred = Convert.ToDateTime(dtpDateOccured.Text);

            //Update the total number of complaints based on the above addition
            lblCompTotal.Text = Complaint.TotalComplaints.ToString();

            //Add complaint object to the list
            MainForm.complaints.Add(c);

        }

        /// <summary>
        /// Event to delete user-selected record from data grid viewer
        /// </summary>
        private void btnDeleteComplaint_Click(object sender, EventArgs e)
        {
            //Variable for forcing user to make selection of the complaint to be deleted.  
            string sugError = "Delete Complaint - Error!";

            //For loop to prompt user to select a complaint to be deleted.
            if (dgvComplaints.CurrentRow.Selected == false)
            {
                MessageBox.Show(sugError, "Please select a complaint you wish to delete. ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string compNo = Convert.ToString(dgvComplaints.Rows[dgvComplaints.CurrentCellAddress.Y].Cells[0].Value);
                string custID = Convert.ToString(dgvComplaints.Rows[dgvComplaints.CurrentCellAddress.Y].Cells[1].Value);
                MessageBox.Show("Complaint Number " + compNo + " for Cutomer ID " + custID + " is the complaint you have selected to delete. ");

            }

            //Variables for complaint object deletion
            int rowNum;

            //Prevent app from crashing if zero complaints are left to delete
            if (MainForm.complaints.Count == 0)
            {
                return;
            }

            //Provides the row# where the user clicked currently
            rowNum = dgvComplaints.CurrentCellAddress.Y;

            //Delete complaint based on current row selection using RemoveAt()
            MainForm.complaints.RemoveAt(rowNum);

            //Update the total complaints label after the deletion
            lblCompTotal.Text = (--Complaint.TotalComplaints).ToString();
        }

        /// <summary>
        /// Updates current record selected, if data is valid
        /// </summary>
         private void btnUpdateComplaint_Click(object sender, EventArgs e)
        {

            //Validation
            bool isValid2 = ValidateFormData2();
            if (isValid2 == false)
            {
                return;
            }

            //Variable for selecting a particular complaint from grid
            int rowNum;

            //Find's the row# where the user clicked
            rowNum = dgvComplaints.CurrentCellAddress.Y;

            if (txtCompNo.Text!= MainForm.complaints[rowNum].ComplaintNo.ToString() && duplicateNoExists(txtCompNo.Text))
            {
                MessageBox.Show("ComplaintNo already exists!");
                return;
            }

            //Variable for forcing user to make selection of the complaint to be updated.  
            string sugError = "Update Complaint - Error!";

            //For loop to prompt user to select a complaint to be updated. 
            if (dgvComplaints.CurrentRow.Selected == false)
            {
                MessageBox.Show(sugError, "Please select a complaint you wish to update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string compNo = Convert.ToString(dgvComplaints.Rows[dgvComplaints.CurrentCellAddress.Y].Cells[0].Value);
                string custID = Convert.ToString(dgvComplaints.Rows[dgvComplaints.CurrentCellAddress.Y].Cells[1].Value);
                MessageBox.Show("Complaint Number " + compNo + " for Cutomer ID " + custID + " is the complaint you have selected to update. ");

            }
                        
            

            //Swaps out the input data back into the complaint list location where it was clicked
            if (txtCompNo.Text != "")
            {
                MainForm.complaints[rowNum].ComplaintNo = Convert.ToInt32(txtCompNo.Text);
            }
            if (txtCustID.Text != "")
            {
                MainForm.complaints[rowNum].CustomerId = Convert.ToInt32(txtCustID.Text);
            }
            if (txtCompType.Text != "")
            {
                MainForm.complaints[rowNum].ComplaintType = txtCompType.Text;
            }
            if (txtCustExp.Text != "")
            {
                MainForm.complaints[rowNum].CustExpectation = txtCustExp.Text;
            }
            if (cboStatus.Text != "")
            {
                MainForm.complaints[rowNum].Status = txtStatus.Text;
            }
            if (txtCompDesc.Text != "")
            {
                MainForm.complaints[rowNum].ComplaintDesc = txtCompDesc.Text;
            }
            if (txtResDesc.Text != "")
            {
                MainForm.complaints[rowNum].ResolutionDesc = txtResDesc.Text;
            }
            if (dtpResolutionDateEnter.Checked == true)
            {
                MainForm.complaints[rowNum].ResolutionDate = Convert.ToDateTime(dtpResolutionDateEnter.Text);
            }
            if (dtpDateRecordedEnter.Checked == true)
            {
                MainForm.complaints[rowNum].DateRecorded = Convert.ToDateTime(dtpDateRecordedEnter.Text);
            }
            if (dtpDateOccured.Checked == true)
            {
                MainForm.complaints[rowNum].DateOccurred = Convert.ToDateTime(dtpDateOccured.Text);
            }

            //Makes the data grid recalculate after updating
            MainForm.complaints.ResetBindings();
        }

        /// <summary>
        /// Clears data from current text boxes
        /// </summary>
        private void btnClearData_Click(object sender, EventArgs e)
        {
            //Reset Background Color
            ResetBackgroundColor();

            //Clears the Textboxes for the User Inputs
            txtCompNo.Text = "";
            txtCustID.Text = "";
            txtCompType.Text = "";
            txtCustExp.Text = "";
            txtStatus.Text = "";
            txtCompDesc.Text = "";
            txtResDesc.Text = "";
            dtpResolutionDateEnter.Text = "";
            dtpDateRecordedEnter.Text = "";
            dtpDateRecordedEnter.Text = "";

            //Clear Label
            lblLastName.Text = "";
        }

        /// <summary>
        /// Selects highlighted complaint to view
        /// </summary>
 
        private void btnSelectComplaint_Click(object sender, EventArgs e)
        {

            //Variable for forcing user to make selection of the complaint to be updated.  
            string sugError = "View Complaint Customer Profile - Error!";

            //For loop to prompt user to select a complaint to be updated. 
            if (dgvComplaints.CurrentRow.Selected == false)
            {
                MessageBox.Show(sugError, "Please select a complaint you wish to view.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            //Variable for selecting a particular complaint from grid
            int rowNum;

            //Find's the row# where the user clicked
            rowNum = dgvComplaints.CurrentCellAddress.Y;

            //Moves the complaint list location where it was clicked into the new textboxes
            txtCompNo.Text = Convert.ToString(sortComplaintFieldsList[rowNum].ComplaintNo);
            txtCustID.Text = Convert.ToString(sortComplaintFieldsList[rowNum].CustomerId);
            txtCompType.Text = sortComplaintFieldsList[rowNum].ComplaintType;
            txtCustExp.Text = sortComplaintFieldsList[rowNum].CustExpectation;
            txtStatus.Text = sortComplaintFieldsList[rowNum].Status;
            txtCompDesc.Text = sortComplaintFieldsList[rowNum].ComplaintDesc;
            txtResDesc.Text = sortComplaintFieldsList[rowNum].ResolutionDesc;
            dtpResolutionDateEnter.Text = Convert.ToString(sortComplaintFieldsList[rowNum].ResolutionDate);
            dtpDateRecordedEnter.Text = Convert.ToString(sortComplaintFieldsList[rowNum].DateRecorded);
            dtpDateOccured.Text = Convert.ToString(sortComplaintFieldsList[rowNum].DateOccurred);
            
        }

        /// <summary>
        /// Loads data into form
        /// </summary>
        private void LoadInitialData()
        {
            //sortComplaintFieldsList = MainForm.complaints.ToList<Complaint>();
            sortComplaintFieldsList = MainForm.complaints;
            bindSrcComplaints.DataSource = sortComplaintFieldsList;
        }

        /// <summary>
        /// Validates form data, and returns message box/indicators of what to correct
        /// </summary>
        /// <returns>boolean value indicating if data is valid</returns>
        private bool ValidateFormData()
        {
            bool isValid = true;
            string msg = "Please correct the following issues:\n";

            //Reset background
            ResetBackgroundColor();

            //Validate text box entries are not empty

            if (txtCompType.Text == "")
            {
                msg += "   All entries must contain a value! Enter a value for complaint type.\n";
                isValid = false;
                txtCompType.BackColor = Color.Pink;
            }
            if (txtCustExp.Text == "")
            {
                msg += "   All entries must contain a value! Enter a value for customer expectation.\n";
                isValid = false;
                txtCustExp.BackColor = Color.Pink;
            }
            if (txtStatus.Text == "")
            {
                msg += "   All entries must contain a value! Enter a value for status.\n";
                isValid = false;
                txtStatus.BackColor = Color.Pink;
            }
            if (txtCompDesc.Text == "")
            {
                msg += "   All entries must contain a value! Enter a value for complaint description.\n";
                isValid = false;
                txtCompDesc.BackColor = Color.Pink;
            }
            if (txtStatus.Text == "Closed")
            {
                if (txtResDesc.Text == "")
                {
                    msg += "   Status is closed. Resolution description must contain a value! Enter a value for resolution description.\n";
                    isValid = false;
                    txtResDesc.BackColor = Color.Pink;
                }
            }

            //Validate text box entries are not integer values
            int compType2;
            int custExp2;
            int status2;
            int compDesc2;
            int resDesc2;

            if (int.TryParse(txtCompType.Text, out compType2))
            {
                msg += "   Must contain a valid value! Enter a valid value for complaint type.\n";
                isValid = false;
                txtCompType.BackColor = Color.Pink;
            }
            if (int.TryParse(txtCustExp.Text, out custExp2))
            {
                msg += "   Must contain a valid value! Enter a valid value for customer expectation.\n";
                isValid = false;
                txtCustExp.BackColor = Color.Pink;
            }
            if (int.TryParse(txtStatus.Text, out status2))
            {
                msg += "   Must contain a valid value! Enter a valid value for status.\n";
                isValid = false;
                txtStatus.BackColor = Color.Pink;
            }
            if (int.TryParse(txtCompDesc.Text, out compDesc2))
            {
                msg += "   Must contain a valid value! Enter a valid value for complaint description.\n";
                isValid = false;
                txtCompDesc.BackColor = Color.Pink;
            }
            if (txtStatus.Text == "Closed")
            {
                if (int.TryParse(txtResDesc.Text, out resDesc2))
                {
                    msg += "   Status is closed. Resolution description must contain a valid value! Enter a valid value for resolution description.\n";
                    isValid = false;
                    txtResDesc.BackColor = Color.Pink;
                }
            }


            //test if ANY were invalid
            if (!isValid)
            {
                MessageBox.Show(msg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return isValid;

        }

        /// <summary>
        /// Validates form data, and returns message box/indicators of what to correct
        /// </summary>
        /// <returns>boolean value indicating if data is valid</returns>
        private bool ValidateFormData2()
        {
            bool isValid2 = true;
            string msg = "Please correct the following issues:\n";

            //Reset background
            ResetBackgroundColor();

            //Validate text box entries are not empty
                     
            
            if (txtStatus.Text == "Closed")
            {
                if (txtResDesc.Text == "")
                {
                    msg += "   Status is closed. Resolution dexription must contain a value! Enter a value for resolution description.\n";
                    isValid2 = false;
                    txtResDesc.BackColor = Color.Pink;
                }
            }

            //Validate text box entries are not integer values
            int compType2;
            int custExp2;
            int status2;
            int compDesc2;
            int resDesc2;

            if (int.TryParse(txtCompType.Text, out compType2))
            {
                msg += "   Must contain a valid value! Enter a valid value for complaint type.\n";
                isValid2 = false;
                txtCompType.BackColor = Color.Pink;
            }
            if (int.TryParse(txtCustExp.Text, out custExp2))
            {
                msg += "   Must contain a valid value! Enter a valid value for customer expectation.\n";
                isValid2 = false;
                txtCustExp.BackColor = Color.Pink;
            }
            if (int.TryParse(txtStatus.Text, out status2))
            {
                msg += "   Must contain a valid value! Enter a valid value for status.\n";
                isValid2 = false;
                txtStatus.BackColor = Color.Pink;
            }
            if (int.TryParse(txtCompDesc.Text, out compDesc2))
            {
                msg += "   Must contain a valid value! Enter a valid value for complaint description.\n";
                isValid2 = false;
                txtCompDesc.BackColor = Color.Pink;
            }
            if (txtStatus.Text == "Closed")
            {
                if (int.TryParse(txtResDesc.Text, out resDesc2))
                {
                    msg += "   Status is closed. Resolution description must contain a valid value! Enter a valid value for resolution description.\n";
                    isValid2 = false;
                    txtResDesc.BackColor = Color.Pink;
                }
            }


            //test if ANY were invalid
            if (!isValid2)
            {
                MessageBox.Show(msg, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return isValid2;

        }

        /// <summary>
        /// Resets the text box background color
        /// </summary>
        private void ResetBackgroundColor()
        {
            //Resets Textbox Background Color
            txtCompNo.BackColor = Color.White;
            txtCustID.BackColor = Color.White;
            txtCompType.BackColor = Color.White;
            txtCustExp.BackColor = Color.White;
            txtStatus.BackColor = Color.White;
            txtCompDesc.BackColor = Color.White;
            txtResDesc.BackColor = Color.White;
        }
        
    }
}
