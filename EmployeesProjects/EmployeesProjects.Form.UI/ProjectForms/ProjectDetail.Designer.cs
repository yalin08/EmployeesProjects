namespace EmployeesProjects.Forms.UI.ProjectForms
{
    partial class ProjectDetail
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblName = new Label();
            lblDesc = new Label();
            lblStart = new Label();
            lblEnd = new Label();
            lblEmpName = new Label();
            label11 = new Label();
            lblEmpLastName = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 244);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 1;
            label5.Text = "Employee Names";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 196);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "End Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 148);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 100);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 52);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(283, 52);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(283, 100);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(63, 15);
            lblDesc.TabIndex = 4;
            lblDesc.Text = "Last Name";
            // 
            // lblHire
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(283, 148);
            lblStart.Name = "lblHire";
            lblStart.Size = new Size(56, 15);
            lblStart.TabIndex = 3;
            lblStart.Text = "Hire Date";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(283, 196);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(33, 15);
            lblEnd.TabIndex = 2;
            lblEnd.Text = "Note";
            // 
            // lblEmpName
            // 
            lblEmpName.AutoSize = true;
            lblEmpName.Location = new Point(283, 244);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(76, 15);
            lblEmpName.TabIndex = 1;
            lblEmpName.Text = "Project Dates";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(110, 292);
            label11.Name = "label11";
            label11.Size = new Size(123, 15);
            label11.TabIndex = 1;
            label11.Text = "Employee Last Names";
            // 
            // lblEmpLastName
            // 
            lblEmpLastName.AutoSize = true;
            lblEmpLastName.Location = new Point(283, 292);
            lblEmpLastName.Name = "lblEmpLastName";
            lblEmpLastName.Size = new Size(76, 15);
            lblEmpLastName.TabIndex = 1;
            lblEmpLastName.Text = "Project Dates";
            // 
            // ProjectDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 338);
            Controls.Add(lblEmpLastName);
            Controls.Add(label11);
            Controls.Add(lblEmpName);
            Controls.Add(label5);
            Controls.Add(lblEnd);
            Controls.Add(label4);
            Controls.Add(lblStart);
            Controls.Add(label3);
            Controls.Add(lblDesc);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProjectDetail";
            Text = "ProjectDetail";
            Load += ProjectDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblName;
        private Label lblDesc;
        private Label lblStart;
        private Label lblEnd;
        private Label lblEmpName;
        private Label label11;
        private Label lblEmpLastName;
    }
}