using LaundrySystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem
{
    public partial class EmployeeForm : Form
    {
        private DataContext? _context;
        private int? selectEmployeeId;
        private string? dgClick, job;
        private string? operation;
        public EmployeeForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = _context ?? new DataContext();
            _context.Employees.Load();
            _context.Jobs.Load();
            _context.viewManageEmployees.Load();

            lblTime.Text = DateTime.Now.ToString();
            viewManageEmployeeBindingSource.DataSource = _context.viewManageEmployees.Local.ToBindingList();
            dataGridView1.ReadOnly = true;

            cmbSerach.Items.Add("Employee Name");
            cmbSerach.Items.Add("Employee Email");
            cmbSerach.Items.Add("Employee Phone");

            HideTrue();
            btnCancel.Hide();
            btnSave.Hide();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        public void SayHello(string name)
        {
            lblHay.Text = $"Hello {name}";
        }
        private void CmbJob()
        {
            _context.Jobs.Load();
            var data = _context.Jobs.Local.ToList();
            cmbJob.DisplayMember = "NameJob";
            cmbJob.ValueMember = "IdJob";
            cmbJob.DataSource = data;
        }
        private void HideTrue()
        {
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();

            txtName.Hide();
            txtEmail.Hide();
            txtPhone.Hide();
            txtPw.Hide();
            txtConfPw.Hide();
            RTAddress.Hide();
            cmbJob.Hide();
            dateBirth.Hide();
            NUDSalary.Hide();

        }
        private void Show()
        {
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();

            txtName.Show();
            txtEmail.Show();
            txtPhone.Show();
            txtPw.Show();
            txtConfPw.Show();
            RTAddress.Show();
            cmbJob.Show();
            dateBirth.Show();
            NUDSalary.Show();

            dateBirth.Format = DateTimePickerFormat.Custom;
            dateBirth.CustomFormat = "dd : MM : yyyy";
        }
        private void EnabledFalse()
        {
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtPw.Enabled = false;
            txtConfPw.Enabled = false;
            RTAddress.Enabled = false;
            cmbJob.Enabled = false;
            dateBirth.Enabled = false;
            NUDSalary.Enabled = false;
        }

        private void EnabledTrue()
        {
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            txtPw.Enabled = true;
            txtConfPw.Enabled = true;
            RTAddress.Enabled = true;
            cmbJob.Enabled = true;
            dateBirth.Enabled = true;
            NUDSalary.Enabled = true;
        }

        private void ClearedField()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPw.Text = "";
            txtConfPw.Text = "";
            RTAddress.Text = "";
            cmbJob.Text = "";
            dateBirth.Text = "";
            NUDSalary.Text = "";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog(this);
        }

        private void AutoCompleteInSearch_EmployeeName()
        {
            var nameArray = _context.Employees.Local.Select(n => n.NameEmployee).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(nameArray);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void AutoCompleteInSearch_EmployeeEmail()
        {
            var emailArray = _context.Employees.Local.Select(n => n.EmailEmploye).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(emailArray);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void AutoCompleteInSearch_EmployeePhone()
        {
            var phoneArray = _context.Employees.Local.Select(n => n.PhoneNumberEmployee).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(phoneArray);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void Search(object sender, EventArgs e)
        {
            if (cmbSerach.Text == "Employee Name")
            {
                AutoCompleteInSearch_EmployeeName();
            }
            else if (cmbSerach.Text == "Employee Email")
            {
                AutoCompleteInSearch_EmployeeEmail();
            }
            else if (cmbSerach.Text == "Employee Phone")
            {
                AutoCompleteInSearch_EmployeePhone();
            }
            else
            {
                return;
            }
        }

        private async void Search_LeaveFocus(object sender, EventArgs e)
        {
            if (cmbSerach.Text == "Employee Name")
            {
                _context.viewManageEmployees.Load();
                string emName = txtSearch.Text;
                List<ViewManageEmployee>? viewManageEmployee = await _context.viewManageEmployees
                                                            .Where(v => v.NameEmployee == emName)
                                                            .ToListAsync();

                viewManageEmployeeBindingSource.DataSource = viewManageEmployee.ToList();
                dataGridView1.Refresh();
            }
            else if (cmbSerach.Text == "Employee Email")
            {
                _context.viewManageEmployees.Load();
                string emEmail = txtSearch.Text;
                List<ViewManageEmployee>? viewManageEmployee = await _context.viewManageEmployees
                                                            .Where(v => v.EmailEmploye == emEmail)
                                                            .ToListAsync();

                viewManageEmployeeBindingSource.DataSource = viewManageEmployee.ToList();
                dataGridView1.Refresh();
            }
            else if (cmbSerach.Text == "Employee Phone")
            {
                _context.viewManageEmployees.Load();
                string emPhone = txtSearch.Text;
                List<ViewManageEmployee>? viewManageEmployee = await _context.viewManageEmployees
                                                            .Where(v => v.PhoneNumberEmployee == emPhone)
                                                            .ToListAsync();

                viewManageEmployeeBindingSource.DataSource = viewManageEmployee.ToList();
                dataGridView1.Refresh();
            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedEmployee = (ViewManageEmployee)viewManageEmployeeBindingSource.List[index];
            selectEmployeeId = selectedEmployee.IdEmployee;
            dgClick = "Clicked";

            Show();
            txtName.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            txtPhone.Text = row.Cells[6].Value.ToString();
            txtPw.Enabled = false;
            txtConfPw.Enabled = false;
            RTAddress.Text = row.Cells[5].Value.ToString();
            cmbJob.Text = row.Cells[2].Value.ToString();
            dateBirth.Text = row.Cells[7].Value.ToString();
            NUDSalary.Text = row.Cells[8].Value.ToString();
            txtPw.Text = row.Cells[9].Value.ToString();
            job = cmbJob.Text;

            EnabledFalse();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Show();
            btnInsert.Hide();
            btnDelete.Hide();
            btnUpdate.Hide();
            btnSave.Show();
            btnCancel.Show();
            CmbJob();
            EnabledTrue();
            ClearedField();

            operation = "insert";
        }

        private async void actionInsert()
        {
            bool cPhoneNum = int.TryParse(txtPhone.Text, out var phoneNum);
            if (!cPhoneNum || txtName.Text == "" || txtEmail.Text == "" || txtPw.Text == "" || txtConfPw.Text == "" || RTAddress.Text == "" || cmbJob.Text == "" || dateBirth.Text == "" || NUDSalary.Value < 0)
            {
                MessageBox.Show("You must enter data completely", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // get job type
                string job = cmbJob.SelectedItem.ToString();
                int idJob = int.Parse(cmbJob.SelectedValue.ToString());
                Job? jobEm = await _context.Jobs
                                .Where(j => j.IdJob == idJob)
                                .FirstOrDefaultAsync();

                Employee employee = new Employee();
                employee.NameEmployee = txtName.Text;
                employee.EmailEmploye = txtEmail.Text;
                employee.AddressEmployee = RTAddress.Text;
                employee.DateOfBirthEmployee = dateBirth.Value;
                employee.PasswordEmployee = txtPw.Text;
                employee.PhoneNumberEmployee = txtPhone.Text;
                employee.IdJob = jobEm.IdJob;
                employee.SalaryEmployee = Convert.ToInt32(Math.Round(NUDSalary.Value, 0));

                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
                _context.viewManageEmployees.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully inserted new employee data with ID : " + employee.IdEmployee, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "insert":
                    actionInsert();
                    break;
                case "update":
                    actionUpdate();
                    break;
                case "delete":
                    actionDelete();
                    break;
                default:
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Show();
                btnInsert.Hide();
                btnUpdate.Hide();
                btnDelete.Hide();
                btnSave.Show();
                btnCancel.Show();
                CmbJob();
                cmbJob.Text = job;
                EnabledTrue();

                operation = "update";
            }
        }

        private async void actionUpdate()
        {
            if (selectEmployeeId != null)
            {
                // get job id
                string nameJob = cmbJob.SelectedItem.ToString();
                int idJob = int.Parse(cmbJob.SelectedValue.ToString());
                Job? job = await _context.Jobs
                            .Where(j => j.IdJob == idJob)
                            .FirstOrDefaultAsync();

                // get employee id
                Employee? employee = await _context.Employees
                                        .Where(e => e.IdEmployee == selectEmployeeId)
                                        .FirstOrDefaultAsync();

                employee.NameEmployee = txtName.Text;
                employee.IdJob = idJob;
                employee.EmailEmploye = txtEmail.Text;
                employee.AddressEmployee = RTAddress.Text;
                employee.DateOfBirthEmployee = dateBirth.Value;
                employee.SalaryEmployee = Convert.ToInt32(Math.Round(NUDSalary.Value, 0));
                employee.PasswordEmployee = txtPw.Text;
                employee.PhoneNumberEmployee = txtPhone.Text;

                _context.Employees.Update(employee);
                await _context.SaveChangesAsync();
                _context.viewManageEmployees.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully updated employee data with ID : " + employee.IdEmployee, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can't updated, because the data unavaible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnabledFalse();
                btnInsert.Hide();
                btnDelete.Hide();
                btnUpdate.Hide();
                btnSave.Show();
                btnCancel.Show();
                operation = "delete";
            }
        }

        private async void actionDelete()
        {
            if (selectEmployeeId != null)
            {
                var employee = await _context.Employees.Where(m => m.IdEmployee == selectEmployeeId).FirstAsync();

                if (MessageBox.Show("Are you sure you want to delete "+ employee.NameEmployee + " from this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {   
                    _context.Employees.Remove(employee);
                    await _context.SaveChangesAsync();
                    selectEmployeeId = null;
                    _context.viewManageEmployees.Load();
                    dataGridView1.Refresh();
                    MessageBox.Show("Successfully updated employee data with ID : " + employee.IdEmployee, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Can't updated, because the data unavaible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            operation = null;
            btnInsert.Show();
            btnDelete.Show();
            btnUpdate.Show();

            btnSave.Hide();
            btnCancel.Hide();

            EnabledFalse();
        }
    }
}
