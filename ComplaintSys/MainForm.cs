/* 
  Software name: What-A-Problem
  Description: “What-A-Problem” for What-A-Burger
  Semester: Spring 2019
  Class: MW 4:00
  Team #: 2
  Developers: McCreary, Mark (Leader); Diamond, Chris; Weldon, John;  Yu, Minwen
  Additional Functionality: This application is designed to manage both the customer data file and the compliant data file. In addition, the application 
                            produces an analysis dashboard user interface that can be used for identifying trends and correlations for strategic business decisions.  
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //ADD NAMESPACE HERE for file processing
using System.Diagnostics; //To write to the DEBUG WIndow

namespace ComplaintSys
{
    public partial class MainForm : Form
    {
        string inputStrCust;                //holds one record that was read in
        string inputStrCompl;                //holds one record that was read in
        string[] customerRecIN;           //string array to hold ONE customer record parsed/split
        string[] complaintRecIN;           //string array to hold ONE complaint record parsed/split
        const char DELIM = ',';         //NOTE: this must be a CHAR for the SPLIT() method used later


        public static BindingList<Customer> customers = new BindingList<Customer>(); //original customers
        public static BindingList<Customer> loadedCustomers = new BindingList<Customer>(); //customers on grid
        public static BindingList<Complaint> complaints = new BindingList<Complaint>(); //original complaints
        public static BindingList<Complaint> loadedComplaints = new BindingList<Complaint>(); //complaints on grid
        public static List<string> sortCustomerFieldsList = new List<String>();
        public static List<string> sortComplaintFieldsList = new List<string>();

        //used for combobox data source
        public static string[] prefixDs, genderDs, cityDs, stateDs, complaintTypeDs, complaintStatusDs;


        const string CUSTOMER_FILE = "Customers.csv";//changed the name
        const string COMPLAINTS_FILE = "Complaints.csv";//changed the name

        const string CUSTOMER_FILE_BACKUP = "BKUP-Customers.csv";//changed the name
        const string COMPLAINTS_FILE_BACKUP = "BKUP-Complaints.csv";//changed the name

        //Size dgvOriginalSize;

        string[] customerHeaders = new string[]
        {
            "Customer ID", "Last Name", "First Name", "Prefix", "Gender", "Address",
            "City", "State", "Zip", "Phone No", "Email"
        };

        string[] complaintHeaders = new string[]
        {
            "Complaint No", "Customer ID", "Type", "Description", "Record Date", "Occurred Date",
            "Expectation", "Status", "Resolution Date", "Resolution Desc."
        };

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the main form upon launch of program
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeApplicationResolution();

            bindSrcCustomers.DataSource = customers;
            bindSrcComplaints.DataSource = complaints;

            PerformImportProcess();
        }

        /// <summary>
        /// Changes the screen resolution of application
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
        /// Loads the data values from csv files into combo boxes
        /// </summary>
        private void LoadDataToCombox()
        {
            // customer form
            HashSet<string> prefixDsSet = new HashSet<string>();
            HashSet<string> genderDsSet = new HashSet<string>();
            HashSet<string> cityDsSet = new HashSet<string>();
            HashSet<string> stateDsSet = new HashSet<string>();

            foreach (Customer c in customers) {
                prefixDsSet.Add(c.Prefix);
                genderDsSet.Add(c.Gender);
                cityDsSet.Add(c.City);
                stateDsSet.Add(c.State);
            }
            prefixDs = prefixDsSet.ToArray<string>();
            genderDs = genderDsSet.ToArray<string>();
            cityDs = cityDsSet.ToArray<string>();
            stateDs = stateDsSet.ToArray<string>();

            //complaint form
            HashSet<string> complaintTypeDsSet = new HashSet<string>();
            HashSet<string> statusDsSet = new HashSet<string>();

            foreach(Complaint c in complaints)
            {
                complaintTypeDsSet.Add(c.ComplaintType);
                statusDsSet.Add(c.Status);
            }
            complaintTypeDs = complaintTypeDsSet.ToArray<string>();
            complaintStatusDs = statusDsSet.ToArray<string>();
        }

        /// <summary>
        /// Import records from csv flies
        /// </summary>
        private void PerformImportProcess()
        {
            //Import CSV File
            LoadCustomerListFromFile(CUSTOMER_FILE);
            LoadComplaintListFromFile(COMPLAINTS_FILE);
            LoadDataToCombox();
        }

        /// <summary>
        /// Load customer information from imported records
        /// </summary>
        /// <param name="fileName">name of file to import from</param>
        private void LoadCustomerListFromFile(string fileName)
        {
            //Clear the customers list
            customers.Clear();

            //Create the FileStream object
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            //Create the StreamReader object
            StreamReader reader = new StreamReader(fs);

            //LEAD READ - i.e. 1st record
            inputStrCust = reader.ReadLine();

            //WHILE: Loop through the file (until an empty record)
            while (inputStrCust != null)
            {
                //split the record that was read (into a String array)
                customerRecIN = inputStrCust.Split(DELIM);

                //create a new customer object (each time it loops!)
                Customer c = new Customer();

                //Load the cutomer object with data from the string array - customerRecIN[]
                if (customerRecIN[0] != "")  //Test all numeric & date data types
                {
                    c.CustomerId = Convert.ToInt32(customerRecIN[0]);
                }
                c.LastName = customerRecIN[1];
                c.FirstName = customerRecIN[2];
                c.Prefix = customerRecIN[3];
                c.Gender = customerRecIN[4];
                c.Address = customerRecIN[5];
                c.City = customerRecIN[6];
                c.State = customerRecIN[7];
                if (customerRecIN[8] != "")
                {
                    c.Zip = Convert.ToInt32(customerRecIN[8]);
                }
                if (customerRecIN[9] != "")
                {
                    c.Phone = customerRecIN[9];
                }
                c.Email = customerRecIN[10];

                //add the new customer to the list
                customers.Add(c);

                //read the next record
                inputStrCust = reader.ReadLine();

            }

            //Close the StreamReader & FileStream objects
            reader.Close();
            fs.Close();
            
        }

        /// <summary>
        /// Load complaint information from imported records
        /// </summary>
        /// <param name="fileName">name of file to import from</param>
        private void LoadComplaintListFromFile(string fileName)
        {
            //Clear the complaints list
            complaints.Clear();
            
            //Create the FileStream object
            FileStream fsComp = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            //Create the StreamReader object
            StreamReader readerComp = new StreamReader(fsComp);

            //LEAD READ - i.e. 1st record
            inputStrCompl = readerComp.ReadLine();

            //WHILE: Loop through the file (until an empty record)
            while (inputStrCompl != null)
            {
                //split the record that was read (into a String array)
                complaintRecIN = inputStrCompl.Split(DELIM);
                
                //create a new complaint object (each time it loops!)
                Complaint co = new Complaint();

                //Load the complaint object with data from the string array - complaintRecIN[]

                if (complaintRecIN[0] != "")  //Test all numeric & date data types
                {
                    co.ComplaintNo = Convert.ToInt32(complaintRecIN[0]);
                }
                if (complaintRecIN[1] != "")  //Test all numeric & date data types
                {
                    co.CustomerId = Convert.ToInt32(complaintRecIN[1]);
                }
                co.ComplaintType = complaintRecIN[2];
                co.ComplaintDesc = complaintRecIN[3];
                if (complaintRecIN[4] != "")  //Test all numeric & date data types
                {
                    co.DateRecorded = Convert.ToDateTime(complaintRecIN[4]);
                }
                if (complaintRecIN[5] != "")  //Test all numeric & date data types
                {
                    double number;
                    double.TryParse(complaintRecIN[5], out number);
                    co.DateOccurred = Convert.ToDateTime(complaintRecIN[5]);
                }
                co.CustExpectation = complaintRecIN[6];
                co.Status = complaintRecIN[7];
                if (complaintRecIN[8] != "")  //Test all numeric & date data types
                {
                    co.ResolutionDate = Convert.ToDateTime(complaintRecIN[8]);
                    
                }
                co.ResolutionDesc = complaintRecIN[9];

                //add the new compalint to the list
                complaints.Add(co);
                
                //read the next record
                inputStrCompl = readerComp.ReadLine();

            }

            //Close the StreamReader & FileStream objects
            readerComp.Close();
            fsComp.Close();
        }

        /// <summary>
        /// Save records changed in program to file
        /// </summary>
        private void ExportToFile()
        {
            FileStream fileStream = new FileStream(CUSTOMER_FILE, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            foreach (Customer c in customers) streamWriter.WriteLine(c);

            streamWriter.Close();
            fileStream.Close();

            fileStream = new FileStream(COMPLAINTS_FILE, FileMode.Create, FileAccess.Write);
            streamWriter = new StreamWriter(fileStream);

            foreach (Complaint c in complaints) streamWriter.WriteLine(c);

            streamWriter.Close();
            fileStream.Close();
        }

        /// <summary>
        /// Save to file and exit proram
        /// </summary>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //exit
            ExportToFile();
            Close();
        }

        /// <summary>
        /// Save to file 
        /// </summary>
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //save
            ExportToFile();
        }

        /// <summary>
        /// Load data for customers and complaints from files
        /// </summary>
        private void loadDataMenuItem_Click(object sender, EventArgs e)
        {
            customers = new BindingList<Customer>();
            complaints = new BindingList<Complaint>();
            LoadCustomerListFromFile(CUSTOMER_FILE);
            LoadComplaintListFromFile(COMPLAINTS_FILE);
        }

        /// <summary>
        /// Load data for customers and complaints from backup files
        /// </summary>
        private void loadBackUpDataMenuItem_Click(object sender, EventArgs e)
        {
            customers = new BindingList<Customer>();
            complaints = new BindingList<Complaint>();
            LoadCustomerListFromFile(CUSTOMER_FILE_BACKUP);
            LoadComplaintListFromFile(COMPLAINTS_FILE_BACKUP);
        }

        /// <summary>
        /// Launches new Analysis form
        /// </summary>
        private void analysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WhatAProblemDataAnalysis analysisFrm = new WhatAProblemDataAnalysis();
            analysisFrm.Show();
        }

        /// <summary>
        /// Save to file upon closing the form
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExportToFile();
        }

        /// <summary>
        /// Launches new customer form
        /// </summary>
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm custfrm = new CustomerForm();
            custfrm.Show();
        }

        /// <summary>
        /// Launches new About form
        /// </summary>
         private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.Show();
        }

       /// <summary>
       /// Launches new complaint form
       /// </summary>
        private void complaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplaintForm compfrm = new ComplaintForm();
            compfrm.Show();
        }

        /// <summary>
        /// Changes color of buttons in form
        /// </summary>
        public static void ChangeButtonColor(object sender)
        {
            Button b = (Button)sender;
            if (b.ForeColor == Color.Red)
            {
                b.ForeColor = Color.Black;
            }
            else
            {
                b.ForeColor = Color.Red;
            }
                       

        }

        
    }

}


