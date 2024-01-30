namespace EmployeesProjects.Forms.UI.EmployeeForms
{
    partial class EmployeeUpdate
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
            btnUpdate = new Button();
            txtNote = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(39, 221);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(299, 62);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(138, 144);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(200, 23);
            txtNote.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(138, 93);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 150);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 4;
            label3.Text = "Note(Optional)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 97);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 54);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // EmployeeUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 391);
            Controls.Add(btnUpdate);
            Controls.Add(txtNote);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "EmployeeUpdate";
            Text = "EmployeeUpdate";
            Load += EmployeeUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox txtNote;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}