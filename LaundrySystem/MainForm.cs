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
    public partial class MainForm : Form
    {
        public string employeeName;
        private DataContext? _context;
        public MainForm()
        {
            InitializeComponent();

            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = _context ?? new DataContext();

            lblTime.Text = DateTime.Now.ToString();
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
            employeeName = name;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnManEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.SayHello(employeeName);
            employeeForm.ShowDialog();
        }

        private void btnManageSevice_Click(object sender, EventArgs e)
        {
            ManageService manageService = new ManageService();
            manageService.SayHello(employeeName);
            manageService.ShowDialog();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomer = new ManageCustomer();
            manageCustomer.SayHello(employeeName);
            manageCustomer.ShowDialog();
        }
    }
}
