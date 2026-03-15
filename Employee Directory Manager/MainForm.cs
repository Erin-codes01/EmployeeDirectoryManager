using System;
using System.IO;
using System.Windows.Forms;

namespace EmployeeDirectoryManager
{
    public partial class MainForm : Form
    {
        // Backend
        private EmployeeManager manager = new EmployeeManager();
        private const string FILE_PATH = "employees.csv";

        // Controls
        private TextBox txtId;
        private TextBox txtFullName;
        private TextBox txtDepartment;
        private TextBox txtRole;
        private TextBox txtSalary;
        private DateTimePicker dtpHireDate;
        private DataGridView dgvEmployees;
        private Label lblStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnLoad;
        private Button btnExit;
        private Label lblHireDate;

        public MainForm()
        {
            InitializeComponent();

            // Bind DataGridView
            dgvEmployees.DataSource = manager.Employees;
        }

        // Reads input fields and creates an Employee object
        private Employee ReadEmployeeFromInputs()
        {
            string id = txtId.Text.Trim();
            string name = txtFullName.Text.Trim();
            string dept = txtDepartment.Text.Trim();
            string role = txtRole.Text.Trim();

            if (!double.TryParse(txtSalary.Text, out double salary))
                throw new Exception("Salary must be numeric.");

            DateTime hireDate = dtpHireDate.Value;

            return new Employee(id, name, dept, role, salary, hireDate);
        }

        // Clears input fields
        private void ClearInputs()
        {
            txtId.Clear();
            txtFullName.Clear();
            txtDepartment.Clear();
            txtRole.Clear();
            txtSalary.Clear();
            dtpHireDate.Value = DateTime.Today;
        }

        // ===================== Button Events =====================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = ReadEmployeeFromInputs();
                manager.AddEmployee(emp);
                lblStatus.Text = "Employee added.";
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Failed");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = ReadEmployeeFromInputs();
                manager.UpdateEmployee(emp);
                lblStatus.Text = "Employee updated.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Enter an employee ID.");
                return;
            }

            bool removed = manager.RemoveEmployee(id);
            if (removed)
                lblStatus.Text = "Employee removed.";
            else
                MessageBox.Show("Employee not found.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                manager.SaveToCsv(FILE_PATH);
                lblStatus.Text = "Data saved to employees.csv";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Failed");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(FILE_PATH))
                {
                    MessageBox.Show("employees.csv not found.");
                    return;
                }

                manager.LoadFromCsv(FILE_PATH);
                lblStatus.Text = $"Loaded {manager.Employees.Count} employees.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Failed");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow?.DataBoundItem is Employee emp)
            {
                txtId.Text = emp.Id;
                txtFullName.Text = emp.FullName;
                txtDepartment.Text = emp.Department;
                txtRole.Text = emp.Role;
                txtSalary.Text = emp.Salary.ToString();
                dtpHireDate.Value = emp.HireDate;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Ready";
        }

        // ===================== InitializeComponent =====================

        private void InitializeComponent()
        {
            // TextBoxes
            txtId = new TextBox { Location = new System.Drawing.Point(12, 60), Width = 200 };
            txtFullName = new TextBox { Location = new System.Drawing.Point(252, 60), Width = 200 };
            txtDepartment = new TextBox { Location = new System.Drawing.Point(491, 60), Width = 200 };
            txtRole = new TextBox { Location = new System.Drawing.Point(724, 60), Width = 200 };
            txtSalary = new TextBox { Location = new System.Drawing.Point(967, 60), Width = 200 };

            // DateTimePicker
            dtpHireDate = new DateTimePicker { Location = new System.Drawing.Point(138, 160), Width = 400 };

            // DataGridView
            dgvEmployees = new DataGridView
            {
                Location = new System.Drawing.Point(12, 272),
                Size = new System.Drawing.Size(1100, 300),
                AutoGenerateColumns = true
            };

            // Status Label
            lblStatus = new Label { Location = new System.Drawing.Point(12, 580), Width = 600, Text = "Ready" };

            // Labels
            lblHireDate = new Label { Location = new System.Drawing.Point(12, 165), Text = "Hire Date:", AutoSize = true };

            // Buttons
            btnAdd = new Button { Text = "Add", Location = new System.Drawing.Point(688, 272), Size = new System.Drawing.Size(150, 46) };
            btnUpdate = new Button { Text = "Update", Location = new System.Drawing.Point(919, 272), Size = new System.Drawing.Size(150, 46) };
            btnDelete = new Button { Text = "Delete", Location = new System.Drawing.Point(1167, 272), Size = new System.Drawing.Size(150, 46) };
            btnSave = new Button { Text = "Save", Location = new System.Drawing.Point(688, 382), Size = new System.Drawing.Size(150, 46) };
            btnLoad = new Button { Text = "Load", Location = new System.Drawing.Point(919, 382), Size = new System.Drawing.Size(150, 46) };
            btnExit = new Button { Text = "Exit", Location = new System.Drawing.Point(1176, 382), Size = new System.Drawing.Size(150, 46) };

            // Add controls to form
            Controls.AddRange(new Control[]
            {
                txtId, txtFullName, txtDepartment, txtRole, txtSalary,
                dtpHireDate, dgvEmployees, lblStatus, lblHireDate,
                btnAdd, btnUpdate, btnDelete, btnSave, btnLoad, btnExit
            });

            // Wire up events
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;
            btnLoad.Click += btnLoad_Click;
            btnExit.Click += btnExit_Click;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;

            // Form settings
            ClientSize = new System.Drawing.Size(1428, 650);
            Name = "Form";
            Text = "Employee Directory Manager";
            Load += Form_Load;
        }
    }
}