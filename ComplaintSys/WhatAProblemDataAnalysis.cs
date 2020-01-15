using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; //need this for CHARTS

namespace ComplaintSys
{

    public partial class WhatAProblemDataAnalysis : Form
    {
        MainForm callingForm; //use this reference when you want to access Form1
        public WhatAProblemDataAnalysis()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the charts and resolution values when form opens
        /// </summary>
        private void WhatAProblemDataAnalysis_Load(object sender, EventArgs e)
        {
            ChangeApplicationResolution();
            DisplayStatusChart();
            DisplayStatePieChart();
            DisplayTypeChart();
            DisplayChartDay();
        }

        /// <summary>
        /// Changes resolution of form
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
        /// Displays data grouping of complaint status in column form
        /// </summary>
        private void DisplayStatusChart()
        {
            //1 - Define the data series
            chartStatus.Series.Clear();
            chartStatus.Series.Add("Status");

            //2 - Format the chart
            chartStatus.Series["Status"].Color = Color.Blue;
            chartStatus.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartStatus.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartStatus.Legends.Clear();

            //3 - Do chart calculations - LINQ
            var statusInfo = from c in MainForm.complaints
                             where c.Status != ""
                             group c by c.Status into grp
                             select new
                             {
                                 grp.Key,
                                 SumComplaints = grp.Select(c => c).Count()
                             };

            //4 - Add the data points
            foreach (var c in statusInfo) chartStatus.Series["Status"].Points.AddXY(c.Key, c.SumComplaints);

            //5 - Format the data points
            chartStatus.ChartAreas[0].AxisX.Title = "Complaint Status";
            chartStatus.ChartAreas[0].AxisY.Title = "Number of Complaints";
            chartStatus.Series["Status"].Label = "#VALY";

        }

        /// <summary>
        /// Displays data grouping of complaints by state in pie chart form
        /// </summary>
        private void DisplayStatePieChart()
        {
            //1 - Define the data series
            chartState.Series.Clear();
            chartState.Series.Add("State");

            //2 - Format the chart
            chartState.Series["State"].ChartType = SeriesChartType.Pie;
            chartState.BackColor = Color.Transparent;
            chartState.ChartAreas[0].BackColor = Color.Transparent;

            //chartState.Series["State"].Color = Color.Blue;
            chartState.Legends.Clear();

            //3 - Do chart calculations - LINQ
            var stateInfoJoinQuery =
                from cust in MainForm.customers
                join com in MainForm.complaints on cust.CustomerId equals com.CustomerId
                select new { cust.State, com.ComplaintNo };

            var stateInfo = from c in stateInfoJoinQuery

                            where c.State != ""
                            group c by c.State into grp
                            select new
                            {
                                grp.Key,
                                SumComplaints = grp.Select(c => c.ComplaintNo).Count()
                            };

            //4 - Add data points
            foreach (var c in stateInfo)
            {
                DataPoint dataPoint = chartState.Series["State"].Points.Add(c.SumComplaints);
                dataPoint.Label = c.Key + "\n" + c.SumComplaints;
            }

            //5 - Format the data points
            chartState.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.WordWrap;
            Font mySliceFont = new Font("Book Antiqua", 12.0f, FontStyle.Bold);

        }

        /// <summary>
        /// Displays complaint by type in column chart form
        /// </summary>
        private void DisplayTypeChart()
        {
            //1 - Define the data series
            chartType.Series.Clear();
            chartType.Series.Add("Type");

            //2 - Format the chart
            chartType.Series["Type"].Color = Color.Green;
            chartType.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartType.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartType.Legends.Clear();

            //3 - Do chart calculations - LINQ
            var typeInfo = from c in MainForm.complaints
                           where c.ComplaintType != ""
                           group c by c.ComplaintType into grp
                           select new
                           {
                               grp.Key,
                               SumComplaints = grp.Select(c => c).Count()
                           };


            //4 - Add the data points
            foreach (var c in typeInfo) chartType.Series["Type"].Points.AddXY(c.Key, c.SumComplaints);

            //5 - Format the data points
            chartType.ChartAreas[0].AxisX.Title = "Complaint Type";
            chartType.ChartAreas[0].AxisY.Title = "Number of Complaints";
            chartType.Series["Type"].Label = "#VALY";
            chartType.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.WordWrap;

        }

        /// <summary>
        /// Displays complaints by day of the week in line chart form
        /// </summary>
        private void DisplayChartDay()
        {
            //1 - Define the data series
            chrtDay.Series.Clear();
            chrtDay.Series.Add("Occured Date");

            //3 - Do chart calculations - LINQ
            var complaintDate = from c in MainForm.complaints
                                where c.DateOccurred != null
                                group c by c.DateOccurred.DayOfWeek.ToString() into grp
                                select new
                                {
                                    grp.Key,
                                    SumDay = grp.Select(c => c).Count()
                                };

            //2 - Format the chart
            chrtDay.Series["Occured Date"].ChartType = SeriesChartType.Line;
            chrtDay.Series["Occured Date"].Color = Color.Green;
            chrtDay.Legends.Clear();
            chrtDay.Series["Occured Date"].Label = "#VALY";
            chrtDay.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chrtDay.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chrtDay.ChartAreas[0].AxisX.Title = "Day of Week";
            chrtDay.ChartAreas[0].AxisY.Title = "Number of Complaints";

            //4 - Add the data points
            foreach (var c in complaintDate) chrtDay.Series["Occured Date"].Points.AddXY(c.Key, c.SumDay);
        }
    }
}
