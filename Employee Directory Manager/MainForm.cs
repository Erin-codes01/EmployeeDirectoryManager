using System;
using System.IO;
using System.Windows.Forms;

namespace EmployeeDirectoryManager
{
    public partial class Form1 : Form
    {
        private EmployeeManager manager = new EmployeeManager();
        private const string FILE_PATH = "employees.csv";

        public Form1()
        {
            InitializeComponent();

            dgvEmployees.DataSource = manager.Employees;
        }

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

        private void ClearInputs()
        {
            txtId.Clear();
            txtFullName.Clear();
            txtDepartment.Clear();
            txtRole.Clear();
            txtSalary.Clear();
            dtpHireDate.Value = DateTime.Today;
        }

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

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form1
            // 
            ClientSize = new Size(1428, 594);
            Name = "Form1";
            ResumeLayout(false);

        }
    }
}