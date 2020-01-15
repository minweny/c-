using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSys
{
    public class Complaint
    {
        //Fields

        //Properties
        //Instance Properties
        public int ComplaintNo { get; set; }
        public int CustomerId { get; set; }
        public string ComplaintType { get; set; }
        public string ComplaintDesc { get; set; }
        public DateTime DateRecorded { get; set; }
        //public string DateRecorded { get; set; }
        public DateTime DateOccurred { get; set; }
        //public string DateOccurred { get; set; }
        public string CustExpectation { get; set; }
        public string Status { get; set; }
        public DateTime? ResolutionDate { get; set; }
        //public string ResolutionDate { get; set; }
        public string ResolutionDesc { get; set; }
        //public string Email { get; set; }

        //Static Properties
        public static int TotalComplaints { get; set; }

        //---Constructors ----
        /// <summary>
        /// Creates complaint event with status resolved, and adds 1 to total complaints
        /// </summary>
        public Complaint()
        {
            Status = "Resolved";
            TotalComplaints++;
        }

        /// <summary>
        /// Creates complaint with populated fields
        /// </summary>
        /// <param name="complaintNo">Number issued for complaint entry</param>
        /// <param name="customerId">Number issued for customer identification</param>
        /// <param name="status">Determines which status the complaint is in</param>
        public Complaint(int complaintNo, int customerId, string status)
        {
            ComplaintNo = complaintNo;
            CustomerId = customerId;
            Status = status;
            TotalComplaints++;

        }

        public override string ToString()
        {
            return string.Join(Customer.DELIM, new object[] { ComplaintNo, CustomerId, ComplaintType, ComplaintDesc, DateRecorded, DateOccurred, CustExpectation, Status, ResolutionDate, ResolutionDesc });
        }
    }
}
