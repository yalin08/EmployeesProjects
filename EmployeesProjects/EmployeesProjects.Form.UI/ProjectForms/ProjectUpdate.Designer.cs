namespace EmployeesProjects.Forms.UI.ProjectForms
{
    partial class ProjectUpdate
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
            lblEndDate = new Label();
            lblStartDate = new Label();
            lblDescription = new Label();
            lblName = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            txtDescription = new TextBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(241, 335);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(68, 274);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(70, 20);
            lblEndDate.TabIndex = 16;
            lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(68, 202);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(76, 20);
            lblStartDate.TabIndex = 15;
            lblStartDate.Text = "Start Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(68, 124);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(68, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(209, 269);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 12;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(209, 197);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(241, 121);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(241, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 9;
            // 
            // ProjectUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 434);
            Controls.Add(btnUpdate);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Name = "ProjectUpdate";
            Text = "ProjectUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label lblEndDate;
        private Label lblStartDate;
        private Label lblDescription;
        private Label lblName;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private TextBox txtDescription;
        private TextBox txtName;
    }
}