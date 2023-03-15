using LaundrySystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem
{
    public partial class ManageCustomer : Form
    {
        DataContext? _context;
        private int? selectedCustomerId;
        private string? dgClick, operation;
        public ManageCustomer()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = _context ?? new DataContext();
            _context.Customers.Load();
            customerBindingSource.DataSource = _context.Customers.Local.ToBindingList();

            lblTime.Text = DateTime.Now.ToString();
            Hide();
            BtnUIDShow();
            cmbSerach.Items.Add("Name");
            cmbSerach.Items.Add("Address");
            cmbSerach.Items.Add("Phone Number");
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void autoCompleteByName()
        {
            var name = _context.Customers.Local.Select(n => n.NameCostumer).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(name);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void autoCompleteByAddress()
        {
            var address = _context.Customers.Local.Select(n => n.AddressCostumer).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(address);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void autoCompleteByPhoneNumber()
        {
            var phoneNum = _context.Customers.Local.Select(n => n.PhoneNumberCustomer).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(phoneNum);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void Search(object sender, EventArgs e)
        {
            switch (cmbSerach.Text)
            {
                case "Name":
                    autoCompleteByName(); break;
                case "Address":
                    autoCompleteByAddress(); break;
                case "Phone Number":
                    autoCompleteByPhoneNumber(); break;
                default: break;
            }
        }

        private async void txtSearch_LeaveFocus(object sender, EventArgs e)
        {
            if (cmbSerach.Text == "Name")
            {
                _context.Customers.Load();
                string name = txtSearch.Text;
                List<Customer>? services = await _context.Customers.Where(v => v.NameCostumer.Contains(name)).ToListAsync();
                customerBindingSource.DataSource = services.ToList();
                dataGridView1.Refresh();
            }
            else if (cmbSerach.Text == "Address")
            {
                _context.Customers.Load();
                string address = txtSearch.Text;
                List<Customer>? services = await _context.Customers.Where(v => v.AddressCostumer.Contains(address)).ToListAsync();
                customerBindingSource.DataSource = services.ToList();
                dataGridView1.Refresh();
            }
            else if (cmbSerach.Text == "Phone Number")
            {
                _context.Customers.Load();
                string phonNum = txtSearch.Text;
                List<Customer>? services = await _context.Customers.Where(v => v.PhoneNumberCustomer.Contains(phonNum)).ToListAsync();
                customerBindingSource.DataSource = services.ToList();
                dataGridView1.Refresh();
            }
            else
            {
                return;
            }
        }

        public void SayHello(string name)
        {
            lblHay.Text = $"Hello {name}";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void Hide()
        {
            txtName.Hide();
            txtPhoneNumber.Hide();
            RTAddress.Hide();

            label2.Hide();
            label3.Hide();
            label4.Hide();
        }

        private void Show()
        {
            txtName.Show();
            txtPhoneNumber.Show();
            RTAddress.Show();

            label2.Show();
            label3.Show();
            label4.Show();
        }

        private void BtnUIDHide()
        {
            btnInsert.Hide();
            btnDelete.Hide();
            btnUpdate.Hide();

            btnSave.Show();
            btnCancel.Show();
        }

        private void BtnUIDShow()
        {
            btnInsert.Show();
            btnDelete.Show();
            btnUpdate.Show();

            btnSave.Hide();
            btnCancel.Hide();
        }

        private void EnabledTrue()
        {
            txtName.Enabled = true;
            txtPhoneNumber.Enabled = true;
            RTAddress.Enabled = true;
        }

        private void EnabledFalse()
        {
            txtName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            RTAddress.Enabled = false;
        }

        private void ClearedField()
        {
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            RTAddress.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedCustomer = (Customer)customerBindingSource.List[index];
            selectedCustomerId = selectedCustomer.IdCustomer;
            dgClick = "Clicked!";

            Show();
            EnabledFalse();
            BtnUIDShow();

            txtName.Text = row.Cells[1].Value.ToString();
            txtPhoneNumber.Text = row.Cells[2].Value.ToString();
            RTAddress.Text = row.Cells[3].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Show();
            EnabledTrue();
            ClearedField();
            BtnUIDHide();
            operation = "insert";
        }

        private void actionInsert()
        {
            bool cekPhonNum = int.TryParse(txtPhoneNumber.Text, out int phonNum);
            if (!cekPhonNum || txtName.Text == "" || RTAddress.Text == "")
            {
                MessageBox.Show("You must enter data completely", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Customer newCustomer = new Customer();
                newCustomer.NameCostumer = txtName.Text;
                newCustomer.PhoneNumberCustomer = txtPhoneNumber.Text;
                newCustomer.AddressCostumer = RTAddress.Text;

                _context.Customers.Add(newCustomer);
                _context.SaveChangesAsync();
                //_context.Customers.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully inserted new employee data with ID : " + newCustomer.IdCustomer, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                BtnUIDHide();
                Show();
                EnabledTrue();
                operation = "update";
            }
        }

        private async void actionUpdate()
        {
            if (selectedCustomerId != null)
            {
                Customer? customer = await _context.Customers.Where(c => c.IdCustomer == selectedCustomerId).FirstOrDefaultAsync();
                customer.NameCostumer = txtName.Text;
                customer.PhoneNumberCustomer = txtPhoneNumber.Text;
                customer.AddressCostumer = RTAddress.Text;

                _context.Customers.Update(customer);
                _context.SaveChangesAsync();
                //_context.Customers.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully updated customer data with ID : " + customer.IdCustomer, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Show();
                EnabledFalse();
                BtnUIDHide();
                operation = "delete";
            }
        }

        private async void actionDelete()
        {
            if (selectedCustomerId != null)
            {
                Customer? customer = await _context.Customers.Where(c => c.IdCustomer == selectedCustomerId).FirstOrDefaultAsync();
                if (MessageBox.Show("Are you sure want to delete " + customer.NameCostumer + " from database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    _context.Customers.Remove(customer);
                    _context.SaveChangesAsync();
                    selectedCustomerId = null;
                    dataGridView1.Refresh();
                    MessageBox.Show("Successfully updated employee data with Name : " + customer.NameCostumer, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Can't updated, because the data unavaible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "insert":
                    actionInsert(); break;
                case "update":
                    actionUpdate(); break;
                case "delete":
                    actionDelete(); break;
                default: break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            operation = null;
            Show();
            EnabledTrue();
            BtnUIDShow();
            ClearedField();
        }
    }
}
