namespace ComplaintSys
{
    partial class WhatAProblemDataAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartState = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartStatus
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatus.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatus.Legends.Add(legend1);
            this.chartStatus.Location = new System.Drawing.Point(48, 21);
            this.chartStatus.Margin = new System.Windows.Forms.Padding(2);
            this.chartStatus.Name = "chartStatus";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStatus.Series.Add(series1);
            this.chartStatus.Size = new System.Drawing.Size(384, 244);
            this.chartStatus.TabIndex = 0;
            this.chartStatus.Text = "chart1";
            // 
            // chartState
            // 
            chartArea2.Name = "ChartArea1";
            this.chartState.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartState.Legends.Add(legend2);
            this.chartState.Location = new System.Drawing.Point(52, 11);
            this.chartState.Margin = new System.Windows.Forms.Padding(2);
            this.chartState.Name = "chartState";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartState.Series.Add(series2);
            this.chartState.Size = new System.Drawing.Size(210, 209);
            this.chartState.TabIndex = 1;
            this.chartState.Text = "chart2";
            // 
            // chartType
            // 
            chartArea3.Name = "ChartArea1";
            this.chartType.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartType.Legends.Add(legend3);
            this.chartType.Location = new System.Drawing.Point(48, 299);
            this.chartType.Margin = new System.Windows.Forms.Padding(2);
            this.chartType.Name = "chartType";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartType.Series.Add(series3);
            this.chartType.Size = new System.Drawing.Size(505, 244);
            this.chartType.TabIndex = 2;
            this.chartType.Text = "chart3";
            // 
            // chrtDay
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtDay.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrtDay.Legends.Add(legend4);
            this.chrtDay.Location = new System.Drawing.Point(487, 21);
            this.chrtDay.Margin = new System.Windows.Forms.Padding(2);
            this.chrtDay.Name = "chrtDay";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrtDay.Series.Add(series4);
            this.chrtDay.Size = new System.Drawing.Size(428, 244);
            this.chrtDay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "State Analysis";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chartState);
            this.panel1.Location = new System.Drawing.Point(609, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 244);
            this.panel1.TabIndex = 5;
            // 
            // WhatAProblemDataAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(962, 586);
            this.Controls.Add(this.chrtDay);
            this.Controls.Add(this.chartType);
            this.Controls.Add(this.chartStatus);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WhatAProblemDataAnalysis";
            this.Text = "WhatAProblemDataAnalysis";
            this.Load += new System.EventHandler(this.WhatAProblemDataAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartState;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}