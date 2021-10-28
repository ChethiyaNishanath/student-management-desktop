
namespace Student_Enrollment_System
{
    partial class StudentEnrolmentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormTitle = new System.Windows.Forms.Label();
            this.registrationNumberLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.courseEnrolledLabel = new System.Windows.Forms.Label();
            this.textRegistrationNumber = new System.Windows.Forms.TextBox();
            this.textStudentName = new System.Windows.Forms.TextBox();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.ageLabel = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textContactNumber = new System.Windows.Forms.TextBox();
            this.courseEnrolled = new System.Windows.Forms.ComboBox();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.panelGender = new System.Windows.Forms.Panel();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.panelGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormTitle.Location = new System.Drawing.Point(290, 9);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(255, 28);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "Student Enrolment System";
            // 
            // registrationNumberLabel
            // 
            this.registrationNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrationNumberLabel.AutoSize = true;
            this.registrationNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrationNumberLabel.Location = new System.Drawing.Point(55, 102);
            this.registrationNumberLabel.Name = "registrationNumberLabel";
            this.registrationNumberLabel.Size = new System.Drawing.Size(170, 23);
            this.registrationNumberLabel.TabIndex = 1;
            this.registrationNumberLabel.Text = "Registration Number";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentNameLabel.Location = new System.Drawing.Point(55, 163);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(121, 23);
            this.studentNameLabel.TabIndex = 2;
            this.studentNameLabel.Text = "Student Name";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthLabel.Location = new System.Drawing.Point(55, 223);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(108, 23);
            this.dateOfBirthLabel.TabIndex = 3;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.Location = new System.Drawing.Point(55, 278);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(66, 23);
            this.genderLabel.TabIndex = 4;
            this.genderLabel.Text = "Gender";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactNumberLabel.Location = new System.Drawing.Point(55, 343);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(138, 23);
            this.contactNumberLabel.TabIndex = 5;
            this.contactNumberLabel.Text = "Contact Number";
            // 
            // courseEnrolledLabel
            // 
            this.courseEnrolledLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.courseEnrolledLabel.AutoSize = true;
            this.courseEnrolledLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.courseEnrolledLabel.Location = new System.Drawing.Point(55, 409);
            this.courseEnrolledLabel.Name = "courseEnrolledLabel";
            this.courseEnrolledLabel.Size = new System.Drawing.Size(150, 23);
            this.courseEnrolledLabel.TabIndex = 6;
            this.courseEnrolledLabel.Text = "Course Enrolled In";
            // 
            // textRegistrationNumber
            // 
            this.textRegistrationNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textRegistrationNumber.Location = new System.Drawing.Point(324, 98);
            this.textRegistrationNumber.Name = "textRegistrationNumber";
            this.textRegistrationNumber.Size = new System.Drawing.Size(288, 27);
            this.textRegistrationNumber.TabIndex = 7;
            this.textRegistrationNumber.TextChanged += new System.EventHandler(this.textRegistrationNumber_TextChanged);
            // 
            // textStudentName
            // 
            this.textStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textStudentName.Location = new System.Drawing.Point(324, 159);
            this.textStudentName.Name = "textStudentName";
            this.textStudentName.Size = new System.Drawing.Size(288, 27);
            this.textStudentName.TabIndex = 8;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOfBirthPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(324, 219);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(132, 27);
            this.dateOfBirthPicker.TabIndex = 9;
            this.dateOfBirthPicker.CloseUp += new System.EventHandler(this.dateOfBirthPicker_CloseUp);
            // 
            // ageLabel
            // 
            this.ageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ageLabel.Location = new System.Drawing.Point(518, 223);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(40, 23);
            this.ageLabel.TabIndex = 10;
            this.ageLabel.Text = "Age";
            // 
            // textAge
            // 
            this.textAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAge.Location = new System.Drawing.Point(594, 219);
            this.textAge.Name = "textAge";
            this.textAge.ReadOnly = true;
            this.textAge.Size = new System.Drawing.Size(125, 27);
            this.textAge.TabIndex = 11;
            // 
            // textContactNumber
            // 
            this.textContactNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textContactNumber.Location = new System.Drawing.Point(324, 339);
            this.textContactNumber.Name = "textContactNumber";
            this.textContactNumber.Size = new System.Drawing.Size(288, 27);
            this.textContactNumber.TabIndex = 12;
            // 
            // courseEnrolled
            // 
            this.courseEnrolled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.courseEnrolled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseEnrolled.FormattingEnabled = true;
            this.courseEnrolled.Items.AddRange(new object[] {
            "HND - COM",
            "HND - BM",
            "Dip - IT",
            "Dip - English",
            "Dip - BM"});
            this.courseEnrolled.Location = new System.Drawing.Point(324, 404);
            this.courseEnrolled.Name = "courseEnrolled";
            this.courseEnrolled.Size = new System.Drawing.Size(151, 28);
            this.courseEnrolled.TabIndex = 13;
            this.courseEnrolled.Text = "Select Course";
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonInsert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ButtonInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonInsert.Location = new System.Drawing.Point(381, 473);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(94, 48);
            this.ButtonInsert.TabIndex = 14;
            this.ButtonInsert.Text = "Insert";
            this.ButtonInsert.UseVisualStyleBackColor = false;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonDelete.Location = new System.Drawing.Point(381, 549);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(94, 48);
            this.ButtonDelete.TabIndex = 15;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ButtonClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonClear.Location = new System.Drawing.Point(381, 629);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(94, 48);
            this.ButtonClear.TabIndex = 16;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonExit.BackColor = System.Drawing.Color.Red;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonExit.Location = new System.Drawing.Point(694, 687);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(94, 48);
            this.ButtonExit.TabIndex = 17;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panelGender
            // 
            this.panelGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGender.Controls.Add(this.radioFemale);
            this.panelGender.Controls.Add(this.radioMale);
            this.panelGender.Location = new System.Drawing.Point(324, 264);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(250, 45);
            this.panelGender.TabIndex = 18;
            // 
            // radioFemale
            // 
            this.radioFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioFemale.AutoSize = true;
            this.radioFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioFemale.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioFemale.Location = new System.Drawing.Point(122, 10);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(86, 27);
            this.radioFemale.TabIndex = 1;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioMale.AutoSize = true;
            this.radioMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioMale.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioMale.Location = new System.Drawing.Point(16, 10);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(69, 27);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // StudentEnrolmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 747);
            this.Controls.Add(this.panelGender);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.courseEnrolled);
            this.Controls.Add(this.textContactNumber);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.textStudentName);
            this.Controls.Add(this.textRegistrationNumber);
            this.Controls.Add(this.courseEnrolledLabel);
            this.Controls.Add(this.contactNumberLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.registrationNumberLabel);
            this.Controls.Add(this.FormTitle);
            this.MaximizeBox = false;
            this.Name = "StudentEnrolmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Enrolment System";
            this.Load += new System.EventHandler(this.StudentEnrolmentForm_Load);
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label registrationNumberLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.Label courseEnrolledLabel;
        private System.Windows.Forms.TextBox textRegistrationNumber;
        private System.Windows.Forms.TextBox textStudentName;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textContactNumber;
        private System.Windows.Forms.ComboBox courseEnrolled;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
    }
}

