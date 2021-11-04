
namespace Student_Enrollment_System
{
    partial class CourseFeeCalculatorForm
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
            this.CourseFeeTitle = new System.Windows.Forms.Label();
            this.StudentNamesCombo = new System.Windows.Forms.ComboBox();
            this.SelectStudentLabel = new System.Windows.Forms.Label();
            this.CourseFeeLabel = new System.Windows.Forms.Label();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioTwelveDiscount = new System.Windows.Forms.RadioButton();
            this.radioTenDiscount = new System.Windows.Forms.RadioButton();
            this.radioFiveDiscount = new System.Windows.Forms.RadioButton();
            this.radioNoDiscount = new System.Windows.Forms.RadioButton();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelDiscountAmount = new System.Windows.Forms.Label();
            this.labelDiscountValue = new System.Windows.Forms.Label();
            this.labelTotalFee = new System.Windows.Forms.Label();
            this.labelGrossFee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEnrolledCourse = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseFeeTitle
            // 
            this.CourseFeeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CourseFeeTitle.AutoSize = true;
            this.CourseFeeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CourseFeeTitle.Location = new System.Drawing.Point(303, 55);
            this.CourseFeeTitle.Name = "CourseFeeTitle";
            this.CourseFeeTitle.Size = new System.Drawing.Size(239, 31);
            this.CourseFeeTitle.TabIndex = 0;
            this.CourseFeeTitle.Text = "Course Fee Calculator";
            // 
            // StudentNamesCombo
            // 
            this.StudentNamesCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudentNamesCombo.FormattingEnabled = true;
            this.StudentNamesCombo.Location = new System.Drawing.Point(337, 146);
            this.StudentNamesCombo.Name = "StudentNamesCombo";
            this.StudentNamesCombo.Size = new System.Drawing.Size(239, 28);
            this.StudentNamesCombo.TabIndex = 2;
            this.StudentNamesCombo.SelectedIndexChanged += new System.EventHandler(this.StudentNamesCombo_SelectedIndexChanged);
            // 
            // SelectStudentLabel
            // 
            this.SelectStudentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectStudentLabel.AutoSize = true;
            this.SelectStudentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectStudentLabel.Location = new System.Drawing.Point(110, 217);
            this.SelectStudentLabel.Name = "SelectStudentLabel";
            this.SelectStudentLabel.Size = new System.Drawing.Size(120, 23);
            this.SelectStudentLabel.TabIndex = 3;
            this.SelectStudentLabel.Text = "Select Student";
            // 
            // CourseFeeLabel
            // 
            this.CourseFeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CourseFeeLabel.AutoSize = true;
            this.CourseFeeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CourseFeeLabel.Location = new System.Drawing.Point(110, 452);
            this.CourseFeeLabel.Name = "CourseFeeLabel";
            this.CourseFeeLabel.Size = new System.Drawing.Size(95, 23);
            this.CourseFeeLabel.TabIndex = 4;
            this.CourseFeeLabel.Text = "Course Fee";
            // 
            // FeeLabel
            // 
            this.FeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FeeLabel.AutoSize = true;
            this.FeeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeeLabel.Location = new System.Drawing.Point(407, 447);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(87, 28);
            this.FeeLabel.TabIndex = 5;
            this.FeeLabel.Text = "LKR 0.00";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculateBtn.Location = new System.Drawing.Point(400, 634);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(94, 48);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioTwelveDiscount);
            this.panel1.Controls.Add(this.radioTenDiscount);
            this.panel1.Controls.Add(this.radioFiveDiscount);
            this.panel1.Controls.Add(this.radioNoDiscount);
            this.panel1.Location = new System.Drawing.Point(337, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 125);
            this.panel1.TabIndex = 7;
            // 
            // radioTwelveDiscount
            // 
            this.radioTwelveDiscount.AutoSize = true;
            this.radioTwelveDiscount.Location = new System.Drawing.Point(0, 95);
            this.radioTwelveDiscount.Name = "radioTwelveDiscount";
            this.radioTwelveDiscount.Size = new System.Drawing.Size(124, 24);
            this.radioTwelveDiscount.TabIndex = 3;
            this.radioTwelveDiscount.TabStop = true;
            this.radioTwelveDiscount.Text = "12 % Discount";
            this.radioTwelveDiscount.UseVisualStyleBackColor = true;
            // 
            // radioTenDiscount
            // 
            this.radioTenDiscount.AutoSize = true;
            this.radioTenDiscount.Location = new System.Drawing.Point(0, 64);
            this.radioTenDiscount.Name = "radioTenDiscount";
            this.radioTenDiscount.Size = new System.Drawing.Size(124, 24);
            this.radioTenDiscount.TabIndex = 2;
            this.radioTenDiscount.TabStop = true;
            this.radioTenDiscount.Text = "10 % Discount";
            this.radioTenDiscount.UseVisualStyleBackColor = true;
            // 
            // radioFiveDiscount
            // 
            this.radioFiveDiscount.AutoSize = true;
            this.radioFiveDiscount.Location = new System.Drawing.Point(0, 33);
            this.radioFiveDiscount.Name = "radioFiveDiscount";
            this.radioFiveDiscount.Size = new System.Drawing.Size(116, 24);
            this.radioFiveDiscount.TabIndex = 1;
            this.radioFiveDiscount.TabStop = true;
            this.radioFiveDiscount.Text = "5 % Discount";
            this.radioFiveDiscount.UseVisualStyleBackColor = true;
            // 
            // radioNoDiscount
            // 
            this.radioNoDiscount.AutoSize = true;
            this.radioNoDiscount.Location = new System.Drawing.Point(0, 3);
            this.radioNoDiscount.Name = "radioNoDiscount";
            this.radioNoDiscount.Size = new System.Drawing.Size(112, 24);
            this.radioNoDiscount.TabIndex = 0;
            this.radioNoDiscount.TabStop = true;
            this.radioNoDiscount.Text = "No Discount";
            this.radioNoDiscount.UseVisualStyleBackColor = true;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDiscount.Location = new System.Drawing.Point(110, 146);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(126, 23);
            this.labelDiscount.TabIndex = 8;
            this.labelDiscount.Text = "Apply Discount";
            // 
            // labelDiscountAmount
            // 
            this.labelDiscountAmount.AutoSize = true;
            this.labelDiscountAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDiscountAmount.Location = new System.Drawing.Point(110, 510);
            this.labelDiscountAmount.Name = "labelDiscountAmount";
            this.labelDiscountAmount.Size = new System.Drawing.Size(144, 23);
            this.labelDiscountAmount.TabIndex = 9;
            this.labelDiscountAmount.Text = "Discount Amount";
            // 
            // labelDiscountValue
            // 
            this.labelDiscountValue.AutoSize = true;
            this.labelDiscountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiscountValue.Location = new System.Drawing.Point(407, 505);
            this.labelDiscountValue.Name = "labelDiscountValue";
            this.labelDiscountValue.Size = new System.Drawing.Size(87, 28);
            this.labelDiscountValue.TabIndex = 10;
            this.labelDiscountValue.Text = "LKR 0.00";
            // 
            // labelTotalFee
            // 
            this.labelTotalFee.AutoSize = true;
            this.labelTotalFee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalFee.Location = new System.Drawing.Point(110, 566);
            this.labelTotalFee.Name = "labelTotalFee";
            this.labelTotalFee.Size = new System.Drawing.Size(78, 23);
            this.labelTotalFee.TabIndex = 11;
            this.labelTotalFee.Text = "Total Fee";
            // 
            // labelGrossFee
            // 
            this.labelGrossFee.AutoSize = true;
            this.labelGrossFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGrossFee.Location = new System.Drawing.Point(407, 566);
            this.labelGrossFee.Name = "labelGrossFee";
            this.labelGrossFee.Size = new System.Drawing.Size(87, 28);
            this.labelGrossFee.TabIndex = 12;
            this.labelGrossFee.Text = "LKR 0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enrolled Course";
            // 
            // labelEnrolledCourse
            // 
            this.labelEnrolledCourse.AutoSize = true;
            this.labelEnrolledCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnrolledCourse.Location = new System.Drawing.Point(407, 388);
            this.labelEnrolledCourse.Name = "labelEnrolledCourse";
            this.labelEnrolledCourse.Size = new System.Drawing.Size(173, 28);
            this.labelEnrolledCourse.TabIndex = 14;
            this.labelEnrolledCourse.Text = "Select student first";
            // 
            // CourseFeeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 712);
            this.Controls.Add(this.labelEnrolledCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGrossFee);
            this.Controls.Add(this.labelTotalFee);
            this.Controls.Add(this.labelDiscountValue);
            this.Controls.Add(this.labelDiscountAmount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.FeeLabel);
            this.Controls.Add(this.CourseFeeLabel);
            this.Controls.Add(this.SelectStudentLabel);
            this.Controls.Add(this.StudentNamesCombo);
            this.Controls.Add(this.CourseFeeTitle);
            this.Name = "CourseFeeCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseFeeCalculatorForm";
            this.Load += new System.EventHandler(this.CourseFeeCalculatorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseFeeTitle;
        private System.Windows.Forms.ComboBox StudentNamesCombo;
        private System.Windows.Forms.Label SelectStudentLabel;
        private System.Windows.Forms.Label CourseFeeLabel;
        private System.Windows.Forms.Label FeeLabel;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioNoDiscount;
        private System.Windows.Forms.RadioButton radioFiveDiscount;
        private System.Windows.Forms.RadioButton radioTwelveDiscount;
        private System.Windows.Forms.RadioButton radioTenDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelDiscountAmount;
        private System.Windows.Forms.Label labelDiscountValue;
        private System.Windows.Forms.Label labelTotalFee;
        private System.Windows.Forms.Label labelGrossFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEnrolledCourse;
    }
}