namespace EmployeesProjects.Forms.UI.EmployeeForms
{
    partial class EmployeeDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblName = new Label();
            lblLastName = new Label();
            lblHire = new Label();
            lblNote = new Label();
            lblProjects = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 42);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 93);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 144);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 0;
            label3.Text = "Hire Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 195);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 0;
            label4.Text = "Note";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 246);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 0;
            label5.Text = "Project Dates";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(225, 42);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 0;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(225, 93);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(0, 15);
            lblLastName.TabIndex = 0;
            // 
            // lblHire
            // 
            lblHire.AutoSize = true;
            lblHire.Location = new Point(225, 144);
            lblHire.Name = "lblHire";
            lblHire.Size = new Size(0, 15);
            lblHire.TabIndex = 0;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(225, 195);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(0, 15);
            lblNote.TabIndex = 0;
            // 
            // lblProjects
            // 
            lblProjects.AutoSize = true;
            lblProjects.Location = new Point(225, 246);
            lblProjects.Name = "lblProjects";
            lblProjects.Size = new Size(0, 15);
            lblProjects.TabIndex = 0;
            // 
            // EmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 322);
            Controls.Add(lblProjects);
            Controls.Add(lblNote);
            Controls.Add(label5);
            Controls.Add(lblHire);
            Controls.Add(label4);
            Controls.Add(lblLastName);
            Controls.Add(label3);
            Controls.Add(lblName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeDetails";
            Text = "EmployeeDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblName;
        private Label lblLastName;
        private Label lblHire;
        private Label lblNote;
        private Label lblProjects;
    }
}