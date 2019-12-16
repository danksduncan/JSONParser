namespace JSONParser
{
    partial class StudentInfoForm
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.tbDegree = new System.Windows.Forms.TextBox();
            this.tbHobbies = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(31, 28);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(166, 29);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(31, 73);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(94, 29);
            this.lblDegree.TabIndex = 1;
            this.lblDegree.Text = "Degree";
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHobbies.Location = new System.Drawing.Point(31, 129);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(104, 29);
            this.lblHobbies.TabIndex = 2;
            this.lblHobbies.Text = "Hobbies";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(203, 32);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(344, 26);
            this.tbStudentName.TabIndex = 3;
            // 
            // tbDegree
            // 
            this.tbDegree.Location = new System.Drawing.Point(203, 73);
            this.tbDegree.Name = "tbDegree";
            this.tbDegree.Size = new System.Drawing.Size(260, 26);
            this.tbDegree.TabIndex = 4;
            // 
            // tbHobbies
            // 
            this.tbHobbies.Location = new System.Drawing.Point(36, 170);
            this.tbHobbies.Multiline = true;
            this.tbHobbies.Name = "tbHobbies";
            this.tbHobbies.Size = new System.Drawing.Size(558, 167);
            this.tbHobbies.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(217, 343);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(151, 53);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Create JSON File";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 442);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbHobbies);
            this.Controls.Add(this.tbDegree);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.lblStudentName);
            this.MaximizeBox = false;
            this.Name = "StudentInfoForm";
            this.Text = "Student Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.TextBox tbDegree;
        private System.Windows.Forms.TextBox tbHobbies;
        private System.Windows.Forms.Button btnSubmit;
    }
}

