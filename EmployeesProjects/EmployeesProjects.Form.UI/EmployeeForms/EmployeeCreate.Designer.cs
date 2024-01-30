namespace EmployeesProjects.Forms.UI.EmployeeForms
{
    partial class EmployeeCreate
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
            txtName = new TextBox();
            dtHire = new DateTimePicker();
            btnCreate = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLastName = new TextBox();
            txtNote = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 62);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(167, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // dtHire
            // 
            dtHire.Location = new Point(167, 143);
            dtHire.Name = "dtHire";
            dtHire.Size = new Size(200, 23);
            dtHire.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(68, 269);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(299, 62);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create Employee";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 148);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 0;
            label2.Text = "Hire Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 191);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 0;
            label3.Text = "Note(Optional)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 105);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 0;
            label4.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(167, 101);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(167, 185);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(200, 23);
            txtNote.TabIndex = 1;
            // 
            // EmployeeCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 392);
            Controls.Add(btnCreate);
            Controls.Add(dtHire);
            Controls.Add(txtNote);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "EmployeeCreate";
            Text = "EmployeeCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private DateTimePicker dtHire;
        private Button btnCreate;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLastName;
        private TextBox txtNote;
    }
}