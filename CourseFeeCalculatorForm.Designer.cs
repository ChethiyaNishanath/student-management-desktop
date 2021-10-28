
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
            this.SuspendLayout();
            // 
            // CourseFeeTitle
            // 
            this.CourseFeeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CourseFeeTitle.AutoSize = true;
            this.CourseFeeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CourseFeeTitle.Location = new System.Drawing.Point(303, 38);
            this.CourseFeeTitle.Name = "CourseFeeTitle";
            this.CourseFeeTitle.Size = new System.Drawing.Size(239, 31);
            this.CourseFeeTitle.TabIndex = 0;
            this.CourseFeeTitle.Text = "Course Fee Calculator";
            // 
            // StudentNamesCombo
            // 
            this.StudentNamesCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudentNamesCombo.FormattingEnabled = true;
            this.StudentNamesCombo.Location = new System.Drawing.Point(337, 173);
            this.StudentNamesCombo.Name = "StudentNamesCombo";
            this.StudentNamesCombo.Size = new System.Drawing.Size(239, 28);
            this.StudentNamesCombo.TabIndex = 2;
            // 
            // SelectStudentLabel
            // 
            this.SelectStudentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectStudentLabel.AutoSize = true;
            this.SelectStudentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectStudentLabel.Location = new System.Drawing.Point(110, 174);
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
            this.CourseFeeLabel.Location = new System.Drawing.Point(110, 278);
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
            this.FeeLabel.Location = new System.Drawing.Point(414, 273);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(87, 28);
            this.FeeLabel.TabIndex = 5;
            this.FeeLabel.Text = "LKR 0.00";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculateBtn.Location = new System.Drawing.Point(414, 365);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(94, 48);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // CourseFeeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 527);
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
    }
}