namespace EmployeesProjects.Forms.UI.EmployeeProjectForms
{
    partial class EmployeeProjectCreate
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
            txtProjectID = new TextBox();
            txtEmployeeID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtProjectID
            // 
            txtProjectID.Location = new Point(222, 150);
            txtProjectID.Name = "txtProjectID";
            txtProjectID.Size = new Size(150, 31);
            txtProjectID.TabIndex = 0;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(222, 221);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(150, 31);
            txtEmployeeID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 153);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 2;
            label1.Text = "ProjectID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 221);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 3;
            label2.Text = "EmployeeID";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(431, 150);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(142, 102);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // EmployeeProjectCreate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmployeeID);
            Controls.Add(txtProjectID);
            Name = "EmployeeProjectCreate";
            Text = "EmployeeProjectCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProjectID;
        private TextBox txtEmployeeID;
        private Label label1;
        private Label label2;
        private Button btnCreate;
    }
}