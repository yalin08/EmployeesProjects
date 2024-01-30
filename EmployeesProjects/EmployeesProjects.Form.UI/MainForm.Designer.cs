namespace EmployeesProjects.Forms.UI
{
    partial class MainForm
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
            btnEmployee = new Button();
            btnProjects = new Button();
            btnEmpProj = new Button();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(74, 93);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(138, 51);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employees";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnProjects
            // 
            btnProjects.Location = new Point(288, 93);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(138, 51);
            btnProjects.TabIndex = 0;
            btnProjects.Text = "Projects";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // btnEmpProj
            // 
            btnEmpProj.Location = new Point(502, 93);
            btnEmpProj.Name = "btnEmpProj";
            btnEmpProj.Size = new Size(138, 51);
            btnEmpProj.TabIndex = 0;
            btnEmpProj.Text = "EmployeeProjects";
            btnEmpProj.UseVisualStyleBackColor = true;
            btnEmpProj.Click += btnEmpProj_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEmpProj);
            Controls.Add(btnProjects);
            Controls.Add(btnEmployee);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployee;
        private Button btnProjects;
        private Button btnEmpProj;
    }
}