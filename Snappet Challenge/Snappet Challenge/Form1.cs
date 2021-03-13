using Newtonsoft.Json;
using Snappet_Challenge.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Snappet_Challenge
{
    public partial class Form1 : Form
    {
        StudentsProgress studentsProgress = new StudentsProgress();

        public Form1()
        {
            InitializeComponent();
            rbCheckByStudent.Checked = true;
            ShowAllStudents();
        }

        //Gets the progress depends on the checked radio button!
        private void btnGetProgress_Click(object sender, EventArgs e)
        {
            ltReportList.Items.Clear();
            StudentsChart.Series.Clear();
            if (ltMainList.SelectedItem == null && cbOptions.SelectedItem == null)
            {
                MessageBox.Show("Please Select an option from the " + lbForMainList.Text + " list and then from the " + lbForComboBox.Text + " combobox");
            }
            else if (cbOptions.SelectedItem == null)
            {
                MessageBox.Show("Please Select an option from the " + lbForComboBox.Text + " combobox");
            }
            else
            {
                if (rbCheckByStudent.Checked)
                {
                    GetProgressOfOneStudent();
                }
                else
                {
                    GetProgressOfAllStudentsBasedOnSubjects();
                }
            }
            
        }

        //An event that changes the lbMainList when the radiobutton check is changed
        private void rbCheckByStudent_CheckedChanged(object sender, EventArgs e)
        {
            cbOptions.Items.Clear();
            if (rbCheckByStudent.Checked)
            {
                ShowAllStudents();
                lbForMainList.Text = "Students ID:";
                lbForComboBox.Text = "Subjects:";
            }
            else
            {
                ShowAllSubjects();
                lbForMainList.Text = "Subjects:";
                lbForComboBox.Text = "Learning Objectives:";
            }
        }

        //An event that changes the combobox data when different item is selected in the LbMainList
        private void lbMainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbCheckByLO.Checked)
            {
                AddLOToComboBox();
            }
        }  

        //Shows a progress chart of the selected student and the selected subject
        public void GetProgressOfOneStudent()
        {
            int selectedStudent = Convert.ToInt32(ltMainList.SelectedItem.ToString());
            string selectedSubject = cbOptions.SelectedItem.ToString();
            StudentsChart.ChartAreas[0].AxisX.Title = "Submition Date&Time";
            StudentsChart.ChartAreas[0].AxisY.Title = "Progress";
            StudentsChart.ChartAreas[0].AxisX.CustomLabels.Clear();

            foreach (ChilderenResults i in studentsProgress.GetOnlyTodayQuestions())
            {
                    if (selectedStudent == i.userId && selectedSubject == i.subject)
                    {
                        if (StudentsChart.Series.IsUniqueName(i.learningObjective))
                        {
                            StudentsChart.Series.Add(i.learningObjective);
                            StudentsChart.Series[i.learningObjective].ChartType = SeriesChartType.Line;
                            StudentsChart.Series[i.learningObjective].BorderWidth = 5;
                        }
                        string Time = i.submitDateTime.Month.ToString() + "/" + i.submitDateTime.Day.ToString() + " " + i.submitDateTime.Hour.ToString() + "h:" + i.submitDateTime.Minute.ToString() + "m";
                        ltReportList.Items.Add(i.learningObjective + ", Progress: " + i.progress + ", Time: " + Time);
                        StudentsChart.Series[i.learningObjective].Points.AddXY(Time, i.progress);
                    }
            }
            StudentsChart.Titles.Clear();
            StudentsChart.Titles.Add(ltMainList.SelectedItem.ToString() + " Progress Chart");
        }

        //Shows a progress of all students based on the selected subject and learning objective
        public void GetProgressOfAllStudentsBasedOnSubjects()
        {
            string selectedLearningObjective = cbOptions.SelectedItem.ToString();
            List<ChilderenResults> LatestProgressOfStudents = studentsProgress.GetLatestProgressBasedOnLastSubmition(selectedLearningObjective);

            ltReportList.Items.Clear();
            StudentsChart.Series.Clear();
            StudentsChart.ChartAreas[0].AxisX.CustomLabels.Clear();

            StudentsChart.ChartAreas[0].AxisX.Title = "Student ID";
            StudentsChart.ChartAreas[0].AxisY.Title = "Progress";
            

            //create customed X axis
            int[] studentIds = studentsProgress.GetUsersIds().ToArray();
            Axis axisX = StudentsChart.ChartAreas[0].AxisX;
            double axisLabelPos = 0.5;
            StudentsChart.Series.Add("Student Progress");

            for (int i = 0; i < studentIds.Length; i++)
            {
                axisX.CustomLabels.Add(axisLabelPos, axisLabelPos + 1, studentIds[i].ToString());
                axisLabelPos += 1.0;
            }
            //End Creating Customed X axis
            
            //add the progress to the chart
            foreach (ChilderenResults i in LatestProgressOfStudents)
            {
                if (i.learningObjective == selectedLearningObjective)
                {
                    StudentsChart.Series["Student Progress"].ChartType = SeriesChartType.Column;
                    StudentsChart.Series["Student Progress"].BorderWidth = 5;
                    StudentsChart.Series["Student Progress"].Points.AddXY(i.userId.ToString(), i.progress);
                    ltReportList.Items.Add("User ID: " + i.userId + ", Progress: " + i.progress);
                }
            }

        }

        //Shows all the students in the lbMainList
        public void ShowAllStudents()
        {
            ltMainList.Items.Clear();
            foreach (int i in studentsProgress.GetUsersIds())
            {
                ltMainList.Items.Add(i);
            }
            AddSubjectsToComboBox();
        }

        //Shows all Subjects in the lbMainList
        public void ShowAllSubjects()
        {
            ltMainList.Items.Clear();
            foreach (string i in studentsProgress.GetAllSubjects())
            {
                ltMainList.Items.Add(i);
            }
        }

        //Adds subjects to the combobox
        public void AddSubjectsToComboBox()
        {
            cbOptions.Items.Clear();
            foreach (string i in studentsProgress.GetAllSubjects())
            {
                cbOptions.Items.Add(i);
            }
        }

        //adds learning objectives in the combobox based on the selected language
        public void AddLOToComboBox()
        {
            cbOptions.Items.Clear();
            foreach (string x in studentsProgress.GetLearningObjectivesOfASpecificSubject(ltMainList.SelectedItem.ToString()))
            {
                cbOptions.Items.Add(x);
            }
        }

    }
}
