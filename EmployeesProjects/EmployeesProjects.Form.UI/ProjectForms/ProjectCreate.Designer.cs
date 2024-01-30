namespace EmployeesProjects.Forms.UI.ProjectForms
{
    partial class ProjectCreate
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
            txtName = new TextBox();
            txtDescription = new TextBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lblName = new Label();
            lblDescription = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(257, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(257, 105);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(225, 181);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(225, 253);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(84, 51);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(84, 108);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(84, 186);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(76, 20);
            lblStartDate.TabIndex = 6;
            lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(84, 258);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(70, 20);
            lblEndDate.TabIndex = 7;
            lblEndDate.Text = "End Date";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(257, 319);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(125, 29);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // ProjectCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 399);
            Controls.Add(btnCreate);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Name = "ProjectCreate";
            Text = "ProjectCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDescription;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label lblName;
        private Label lblDescription;
        private Label lblStartDate;
        private Label lblEndDate;
        private Button btnCreate;
    }
}