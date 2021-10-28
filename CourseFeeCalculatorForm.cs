﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Enrollment_System
{
    public partial class CourseFeeCalculatorForm : Form
    {
        public static CourseFeeCalculatorForm instance;
        public CourseFeeCalculatorForm()
        {
            InitializeComponent();
            instance = this;
        }

        SqlConnection con = new SqlConnection(@"Server=.;Database=student_management;" +
            "Trusted_Connection=True;MultipleActiveResultSets=True");

        private void StudentSelectLabel_Click(object sender, EventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {

            DataRowView drv = StudentNamesCombo.SelectedItem as DataRowView;

            string item = drv.Row["Course_Enrolled_In"].ToString();

            switch (item)
            {
                case "HND - COM":
                    FeeLabel.Text = "LKR " + "30000.00";
                    break;
                case "HND - BM":
                    FeeLabel.Text = "LKR " + "25000.00";
                    break;
                case "Dip - IT":
                    FeeLabel.Text = "LKR " + "18000.00";
                    break;
                case "Dip - English":
                    FeeLabel.Text = "LKR " + "15000.00";
                    break;
                case "Dip - BM":
                    FeeLabel.Text = "LKR " + "18000.00";
                    break;
            }
        }

        private void CourseFeeCalculatorForm_Load(object sender, EventArgs e)
        {
            string search_query = "SELECT Student_Name, Course_Enrolled_In  FROM Student";
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(search_query, con);
            DataSet data = new DataSet();
            sqlDataAdapter.Fill(data, "Student");
            StudentNamesCombo.DisplayMember = "Student_Name";
            StudentNamesCombo.ValueMember = "Course_Enrolled_In";
            StudentNamesCombo.DataSource = data.Tables["Student"];
            con.Close();
        }
    }
}