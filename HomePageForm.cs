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
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Server=.;Database=student_management;" +
            "Trusted_Connection=True;MultipleActiveResultSets=True");

        private void StudentAddFormButton_Click(object sender, EventArgs e)
        {
            StudentEnrolmentForm studentEnrolmentForm = new StudentEnrolmentForm();
            studentEnrolmentForm.Show();
        }

        private void FetchData()
        {
            string search_query = "SELECT * FROM Student";
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(search_query, con);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);

            dataGridView1.DataSource = table;
            con.Close();

        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            this.FetchData();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.FetchData();
        }

        private void CalculateCourceFeeBtn_Click(object sender, EventArgs e)
        {
            CourseFeeCalculatorForm courseFeeCalculatorForm = new CourseFeeCalculatorForm();
            courseFeeCalculatorForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Exit?", "Exit",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                Environment.Exit(0);
            }
        }
    }
}
