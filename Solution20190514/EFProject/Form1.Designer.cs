namespace EFProject
{
    partial class Form1
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
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.btnFillStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(12, 50);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(235, 21);
            this.cmbStudent.TabIndex = 0;
            // 
            // btnFillStudents
            // 
            this.btnFillStudents.Location = new System.Drawing.Point(85, 12);
            this.btnFillStudents.Name = "btnFillStudents";
            this.btnFillStudents.Size = new System.Drawing.Size(75, 23);
            this.btnFillStudents.TabIndex = 1;
            this.btnFillStudents.Text = "Fill";
            this.btnFillStudents.UseVisualStyleBackColor = true;
            this.btnFillStudents.Click += new System.EventHandler(this.btnFillStudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 450);
            this.Controls.Add(this.btnFillStudents);
            this.Controls.Add(this.cmbStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Button btnFillStudents;
    }
}

