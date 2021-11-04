using System;
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

        private void CalculateBtn_Click(object sender, EventArgs e)
        {

            DataRowView drv = StudentNamesCombo.SelectedItem as DataRowView;

            string item = drv.Row["Course_Enrolled_In"].ToString();

            labelEnrolledCourse.Text = item;

            double discountPercentage = 0;
            double totalFee = 0.0;
            double discount = 0.0;

            if (radioFiveDiscount.Checked)
            {
                discountPercentage = 0.05;
            }
            if (radioTenDiscount.Checked)
            {
                discountPercentage = 0.1;
            }
            if (radioTwelveDiscount.Checked)
            {
                discountPercentage = 0.12;
            }

            switch (item)
            {
                case "HND - COM":
                    discount = 30000.0 * discountPercentage;
                    totalFee = 30000.0 - discount;
                    labelDiscountValue.Text = "LKR " + discount.ToString();
                    labelGrossFee.Text = "LKR " + totalFee.ToString();
                    FeeLabel.Text = "LKR " + "30000.00";
                    break;
                case "HND - BM":
                    discount = 25000.0 * discountPercentage;
                    totalFee = 25000.0 - discount;
                    labelDiscountValue.Text = "LKR " + discount.ToString();
                    labelGrossFee.Text = "LKR " + totalFee.ToString();
                    FeeLabel.Text = "LKR " + "25000.00";
                    break;
                case "Dip - IT":
                    discount = 18000.0 * discountPercentage;
                    totalFee = 18000.0 - discount;
                    labelDiscountValue.Text = "LKR " + discount.ToString();
                    labelGrossFee.Text = "LKR " + totalFee.ToString();
                    FeeLabel.Text = "LKR " + "18000.00";
                    break;
                case "Dip - English":
                    discount = 15000.0 * discountPercentage;
                    totalFee = 15000.0 - discount;
                    labelDiscountValue.Text = "LKR " + discount.ToString();
                    labelGrossFee.Text = "LKR " + totalFee.ToString();
                    FeeLabel.Text = "LKR " + "15000.00";
                    break;
                case "Dip - BM":
                    discount = 18000.0 * discountPercentage;
                    totalFee = 18000.0 - discount;
                    labelDiscountValue.Text = "LKR " + discount.ToString();
                    labelGrossFee.Text = "LKR " + totalFee.ToString();
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
            radioNoDiscount.Checked = true;
        }
        private void StudentNamesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioNoDiscount.Checked = true;
            radioFiveDiscount.Checked = false;
            radioTenDiscount.Checked = false;
            radioTwelveDiscount.Checked = false;

            DataRowView drv = StudentNamesCombo.SelectedItem as DataRowView;

            string item = drv.Row["Course_Enrolled_In"].ToString();

            labelEnrolledCourse.Text = item;

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
    }
}
