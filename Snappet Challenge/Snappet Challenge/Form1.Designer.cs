
namespace Snappet_Challenge
{
    partial class Form1
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
            this.ltMainList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.btnGetProgress = new System.Windows.Forms.Button();
            this.ltReportList = new System.Windows.Forms.ListBox();
            this.rbCheckByStudent = new System.Windows.Forms.RadioButton();
            this.rbCheckByLO = new System.Windows.Forms.RadioButton();
            this.StudentsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.lbForMainList = new System.Windows.Forms.Label();
            this.lbForComboBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ltMainList
            // 
            this.ltMainList.FormattingEnabled = true;
            this.ltMainList.Location = new System.Drawing.Point(12, 107);
            this.ltMainList.Name = "ltMainList";
            this.ltMainList.Size = new System.Drawing.Size(111, 407);
            this.ltMainList.TabIndex = 0;
            this.ltMainList.SelectedIndexChanged += new System.EventHandler(this.lbMainList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // cbOptions
            // 
            this.cbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Location = new System.Drawing.Point(253, 37);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(134, 21);
            this.cbOptions.TabIndex = 3;
            // 
            // btnGetProgress
            // 
            this.btnGetProgress.Location = new System.Drawing.Point(409, 37);
            this.btnGetProgress.Name = "btnGetProgress";
            this.btnGetProgress.Size = new System.Drawing.Size(114, 23);
            this.btnGetProgress.TabIndex = 4;
            this.btnGetProgress.Text = "Get Progress";
            this.btnGetProgress.UseVisualStyleBackColor = true;
            this.btnGetProgress.Click += new System.EventHandler(this.btnGetProgress_Click);
            // 
            // ltReportList
            // 
            this.ltReportList.FormattingEnabled = true;
            this.ltReportList.HorizontalScrollbar = true;
            this.ltReportList.Location = new System.Drawing.Point(200, 107);
            this.ltReportList.Name = "ltReportList";
            this.ltReportList.Size = new System.Drawing.Size(309, 407);
            this.ltReportList.TabIndex = 5;
            // 
            // rbCheckByStudent
            // 
            this.rbCheckByStudent.AutoSize = true;
            this.rbCheckByStudent.Location = new System.Drawing.Point(12, 23);
            this.rbCheckByStudent.Name = "rbCheckByStudent";
            this.rbCheckByStudent.Size = new System.Drawing.Size(111, 17);
            this.rbCheckByStudent.TabIndex = 7;
            this.rbCheckByStudent.Text = "Check By Student";
            this.rbCheckByStudent.UseVisualStyleBackColor = true;
            this.rbCheckByStudent.CheckedChanged += new System.EventHandler(this.rbCheckByStudent_CheckedChanged);
            // 
            // rbCheckByLO
            // 
            this.rbCheckByLO.AutoSize = true;
            this.rbCheckByLO.Location = new System.Drawing.Point(12, 53);
            this.rbCheckByLO.Name = "rbCheckByLO";
            this.rbCheckByLO.Size = new System.Drawing.Size(163, 17);
            this.rbCheckByLO.TabIndex = 8;
            this.rbCheckByLO.Text = "Check By Learning Objective";
            this.rbCheckByLO.UseVisualStyleBackColor = true;
            // 
            // StudentsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.StudentsChart.ChartAreas.Add(chartArea1);
            this.StudentsChart.Enabled = false;
            legend1.Name = "Legend1";
            this.StudentsChart.Legends.Add(legend1);
            this.StudentsChart.Location = new System.Drawing.Point(541, 68);
            this.StudentsChart.Name = "StudentsChart";
            this.StudentsChart.Size = new System.Drawing.Size(786, 619);
            this.StudentsChart.TabIndex = 6;
            this.StudentsChart.Text = "StudentsChart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Overview Report:";
            // 
            // lbForMainList
            // 
            this.lbForMainList.AutoSize = true;
            this.lbForMainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForMainList.Location = new System.Drawing.Point(12, 86);
            this.lbForMainList.Name = "lbForMainList";
            this.lbForMainList.Size = new System.Drawing.Size(80, 18);
            this.lbForMainList.TabIndex = 10;
            this.lbForMainList.Text = "Student ID:";
            // 
            // lbForComboBox
            // 
            this.lbForComboBox.AutoSize = true;
            this.lbForComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForComboBox.Location = new System.Drawing.Point(250, 9);
            this.lbForComboBox.Name = "lbForComboBox";
            this.lbForComboBox.Size = new System.Drawing.Size(69, 18);
            this.lbForComboBox.TabIndex = 11;
            this.lbForComboBox.Text = "Subjects:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1339, 808);
            this.Controls.Add(this.lbForComboBox);
            this.Controls.Add(this.lbForMainList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentsChart);
            this.Controls.Add(this.rbCheckByLO);
            this.Controls.Add(this.rbCheckByStudent);
            this.Controls.Add(this.ltReportList);
            this.Controls.Add(this.btnGetProgress);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltMainList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltMainList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.Button btnGetProgress;
        private System.Windows.Forms.ListBox ltReportList;
        private System.Windows.Forms.RadioButton rbCheckByStudent;
        private System.Windows.Forms.RadioButton rbCheckByLO;
        private System.Windows.Forms.DataVisualization.Charting.Chart StudentsChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbForMainList;
        private System.Windows.Forms.Label lbForComboBox;
    }
}

