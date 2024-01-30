namespace EmployeesProjects.Forms.UI.ProjectForms
{
    partial class ProjectList
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
            dvgGetAll = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgGetAll).BeginInit();
            SuspendLayout();
            // 
            // dvgGetAll
            // 
            dvgGetAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgGetAll.Dock = DockStyle.Bottom;
            dvgGetAll.Location = new Point(0, 109);
            dvgGetAll.Name = "dvgGetAll";
            dvgGetAll.RowHeadersWidth = 51;
            dvgGetAll.RowTemplate.Height = 29;
            dvgGetAll.Size = new Size(800, 341);
            dvgGetAll.TabIndex = 0;
            dvgGetAll.CellClick += dvgGetAll_CellClick;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(122, 34);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(330, 34);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(556, 34);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ProjectList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dvgGetAll);
            Name = "ProjectList";
            Text = "ProjectList";
            Load += ProjectList_Load;
            ((System.ComponentModel.ISupportInitialize)dvgGetAll).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgGetAll;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
    }
}