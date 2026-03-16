namespace EmployeeDirectoryManager
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
            txtId = new TextBox();
            txtFullName = new TextBox();
            txtDepartment = new TextBox();
            txtRole = new TextBox();
            txtSalary = new TextBox();
            lblStatus = new Label();
            dtpHireDate = new DateTimePicker();
            dgvEmployees = new DataGridView();
            label1 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(0, 0);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 39);
            txtId.TabIndex = 0;
            txtId.Text = "Employee ID:";
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(238, 0);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 39);
            txtFullName.TabIndex = 1;
            txtFullName.Text = "Full Name:";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(0, 57);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(200, 39);
            txtDepartment.TabIndex = 2;
            txtDepartment.Text = "Department:";
            txtDepartment.TextChanged += textBox3_TextChanged;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(238, 57);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(200, 39);
            txtRole.TabIndex = 3;
            txtRole.Text = "Role:";
            txtRole.TextChanged += textBox4_TextChanged;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(488, 57);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(200, 39);
            txtSalary.TabIndex = 4;
            txtSalary.Text = "Salary:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(8, 257);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(78, 32);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            lblStatus.Click += label1_Click;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(614, 0);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(400, 39);
            dtpHireDate.TabIndex = 6;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(8, 301);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 82;
            dgvEmployees.Size = new Size(480, 300);
            dgvEmployees.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 3);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 8;
            label1.Text = "Hire Date:";
            label1.Click += label1_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 134);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(194, 134);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(384, 134);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(577, 134);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(769, 134);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(150, 46);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(969, 134);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 613);
            Controls.Add(btnExit);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(dgvEmployees);
            Controls.Add(dtpHireDate);
            Controls.Add(lblStatus);
            Controls.Add(txtSalary);
            Controls.Add(txtRole);
            Controls.Add(txtDepartment);
            Controls.Add(txtFullName);
            Controls.Add(txtId);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtFullName;
        private TextBox txtDepartment;
        private TextBox txtRole;
        private TextBox txtSalary;
        private Label lblStatus;
        private DateTimePicker dtpHireDate;
        private DataGridView dgvEmployees;
        private Label label1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnLoad;
        private Button btnExit;
    }
}