
namespace Student_Enrollment_System
{
    partial class HomePageForm
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
            this.StudentAddFormButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CalculateCourseFeeBtn = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentAddFormButton
            // 
            this.StudentAddFormButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.StudentAddFormButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentAddFormButton.Location = new System.Drawing.Point(703, 102);
            this.StudentAddFormButton.Name = "StudentAddFormButton";
            this.StudentAddFormButton.Size = new System.Drawing.Size(186, 48);
            this.StudentAddFormButton.TabIndex = 0;
            this.StudentAddFormButton.Text = "Student Management";
            this.StudentAddFormButton.UseVisualStyleBackColor = false;
            this.StudentAddFormButton.Click += new System.EventHandler(this.StudentAddFormButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(805, 392);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CalculateCourseFeeBtn
            // 
            this.CalculateCourseFeeBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CalculateCourseFeeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateCourseFeeBtn.Location = new System.Drawing.Point(485, 102);
            this.CalculateCourseFeeBtn.Name = "CalculateCourseFeeBtn";
            this.CalculateCourseFeeBtn.Size = new System.Drawing.Size(169, 48);
            this.CalculateCourseFeeBtn.TabIndex = 2;
            this.CalculateCourseFeeBtn.Text = "Calculate Course Fee";
            this.CalculateCourseFeeBtn.UseVisualStyleBackColor = false;
            this.CalculateCourseFeeBtn.Click += new System.EventHandler(this.CalculateCourceFeeBtn_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(84, 26);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(94, 48);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(340, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Management Home";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.Location = new System.Drawing.Point(829, 685);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 48);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 754);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.CalculateCourseFeeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StudentAddFormButton);
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentAddFormButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CalculateCourseFeeBtn;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitBtn;
    }
}