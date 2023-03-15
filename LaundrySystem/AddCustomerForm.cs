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
    public partial class AddCustomerForm : Form
    {
        DataContext? _context;
        public AddCustomerForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = _context ?? new DataContext();
            _context.Customers.Load();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void ClearedField()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            RTAddress.Text = "";
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "" || RTAddress.Text == "")
            {
                MessageBox.Show("Can't add, please check your identity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Customer newcustomer = new Customer();
                newcustomer.NameCostumer = txtName.Text;
                newcustomer.PhoneNumberCustomer = txtPhone.Text;
                newcustomer.AddressCostumer = RTAddress.Text;

                _context.Customers.Add(newcustomer);
                await _context.SaveChangesAsync();
                MessageBox.Show("Customer Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearedField();
            }
        }
    }
}
