using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Enrollment_System
{
    public partial class StudentEnrolmentForm : Form
    {
        public static StudentEnrolmentForm instance;
        public StudentEnrolmentForm()
        {
            InitializeComponent();
            instance = this;
        }

        SqlConnection con = new SqlConnection(@"Server=.;Database=student_management;"+
            "Trusted_Connection=True;MultipleActiveResultSets=True");

        private void StudentEnrolmentForm_Load(object sender, EventArgs e)
        {
            try {
                int registrationNumber = Int32.Parse(textRegistrationNumber.Text);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Exit?", "Exit",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                Environment.Exit(0);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to clear form ?", "Clear",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                textRegistrationNumber.Text = string.Empty;
                textStudentName.Text = string.Empty;
                textContactNumber.Text = string.Empty;
                textAge.Text = string.Empty;
                radioFemale.Checked = false;
                radioMale.Checked = false;
                dateOfBirthPicker.Value = DateTime.Now;
                dateOfBirthPicker.Format = DateTimePickerFormat.Short;
                courseEnrolled.Text = "Select Course";
                courseEnrolled.SelectedItem = 0;
            }
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            try
            {

                char gender = 'm';

                if (radioMale.Checked)
                {
                    gender = 'm';
                }
                if(radioFemale.Checked)
                {
                    gender = 'f';
                }

                if ( !String.IsNullOrWhiteSpace(textRegistrationNumber.Text)
                    && !String.IsNullOrWhiteSpace(textStudentName.Text)
                    && !String.IsNullOrWhiteSpace(textContactNumber.Text)
                    && courseEnrolled.SelectedIndex != -1)
                {
                    int registrationNumber = Int16.Parse(textRegistrationNumber.Text);
                    string studentName = textStudentName.Text;
                    string dateOfBirth = dateOfBirthPicker.Value.ToString();
                    string age = textAge.Text;
                    string contactNumber = textContactNumber.Text;
                    string course = courseEnrolled.SelectedItem.ToString();

                    string insert_query = "INSERT INTO Student VALUES( " + registrationNumber + ",'" + 
                        studentName + "','" +
                        dateOfBirth + "','" + gender + "','" + contactNumber + "','" + course + "');";

                    SqlCommand cmd = new SqlCommand(insert_query, con);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    DialogResult result = MessageBox.Show("Saved Successfully\nDo you want to add new student?", "Added Data",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result.Equals(DialogResult.Yes)) {
                        textRegistrationNumber.Text = string.Empty;
                        textStudentName.Text = string.Empty;
                        textContactNumber.Text = string.Empty;
                        textAge.Text = string.Empty;
                        radioFemale.Checked = false;
                        radioMale.Checked = false;
                        dateOfBirthPicker.Value = DateTime.Now;
                        dateOfBirthPicker.Format = DateTimePickerFormat.Short;
                        courseEnrolled.Text = "Select Course";
                        courseEnrolled.SelectedItem = 0;
                    }

                    con.Close();

                }
                else
                {
                    MessageBox.Show("Complete the Missing Data", "Missing fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            string search_query = "SELECT * FROM Student WHERE Registration_Number=" + textRegistrationNumber.Text + ";";

            SqlCommand cmd1 = new SqlCommand(search_query, con);

            con.Open();
            SqlDataReader read = cmd1.ExecuteReader();
            if (read.Read())
            {
                DialogResult result = MessageBox.Show("Do You Want to delete record?", "Delete Student Data",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result.Equals(DialogResult.Yes))
                {
                    string delete_query = "DELETE FROM Student WHERE Registration_Number=" + 
                        textRegistrationNumber.Text + ";";
                    SqlCommand cmd2 = new SqlCommand(delete_query, con);
                    cmd2.ExecuteReader();

                    textRegistrationNumber.Text = string.Empty;
                    textStudentName.Text = string.Empty;
                    textContactNumber.Text = string.Empty;
                    textAge.Text = string.Empty;
                    radioFemale.Checked = false;
                    radioMale.Checked = false;
                    dateOfBirthPicker.Value = DateTime.Now;
                    dateOfBirthPicker.Format = DateTimePickerFormat.Short;
                    courseEnrolled.Text = "Select Course";
                    courseEnrolled.SelectedItem = 0;

                    MessageBox.Show("Record deletd successfully!", "Success",MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void textRegistrationNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(textRegistrationNumber.Text))
                {
                    string search_query = "SELECT * FROM Student WHERE Registration_Number=" + textRegistrationNumber.Text + ";";

                    SqlCommand cmd = new SqlCommand(search_query, con);

                    con.Open();
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        textStudentName.Text = read.GetValue(1).ToString();
                        dateOfBirthPicker.Text = read.GetValue(2).ToString();
                        textContactNumber.Text = read.GetValue(4).ToString();
                        courseEnrolled.SelectedItem = read.GetValue(5).ToString();

                        if (read.GetValue(3).ToString()[0] == 'm')
                        {
                            radioMale.Checked = true;
                        }
                        else
                        {
                            radioFemale.Checked = true;
                        }

                        int age = Convert.ToUInt16(((DateTime.Today - Convert.ToDateTime(read.GetValue(2)))
                            .TotalDays) / 365);

                        textAge.Text = age.ToString();

                        MessageBox.Show("Student with Registration number " + textRegistrationNumber.Text + " exists!",
                            "Already exists!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        textStudentName.Text = string.Empty;
                        textContactNumber.Text = string.Empty;
                        textAge.Text = string.Empty;
                        radioFemale.Checked = false;
                        radioMale.Checked = false;
                        dateOfBirthPicker.Value = DateTime.Now;
                        dateOfBirthPicker.Format = DateTimePickerFormat.Short;
                        courseEnrolled.Text = "Select Course";
                        courseEnrolled.SelectedItem = 0;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dateOfBirthPicker_CloseUp(object sender, EventArgs e)
        {
            int age = Convert.ToUInt16(((DateTime.Today - dateOfBirthPicker.Value).TotalDays) / 365);
            if (age < 18)
            {
                MessageBox.Show("Cannot Enroll – Below 18 years", "Unsupported age",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textAge.Text = string.Empty;
            }
            else
            {
                textAge.Text = age.ToString();
            }
        }
    }
}
