using LaundrySystem.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaundrySystem
{
    public partial class ServiceTransaction : Form
    {
        DataContext? _context;
        private string employeeName, serviceName;
        DataTable dt = new DataTable();
        private int allPrice, allDuration;
        private int idCustomer, idEmployee, idHeaderTrans;
        private int price, unit, duration, subTotal, serviceId;
        List<ServiceTransactionModel> servicesList = new List<ServiceTransactionModel>();
        private ServiceTransactionModel getService;
        private int index;

        public ServiceTransaction()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = _context ?? new DataContext();
            _context.Customers.Load();
            _context.HeaderTransactions.Load();
            _context.DetailTransactions.Load();

            serviceTransactionModelBindingSource.DataSource = servicesList.ToList();

            lblTime.Text = DateTime.Now.ToString();
            CmbServices();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        public void SayHey(string name)
        {
            lblHay.Text = $"Hello, {name}";
            employeeName = name;
        }

        private void CmbServices()
        {
            _context.Services.Load();
            var data = _context.Services.Local.ToList();
            cmbService.DisplayMember = "NameService";
            cmbService.ValueMember = "IdService";
            cmbService.DataSource = data;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (NUDTotalUnit.Value < 1)
            {
                MessageBox.Show("The number of service units is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // get value combobox
                string serName = cmbService.SelectedItem.ToString();
                int serId = int.Parse(cmbService.SelectedValue.ToString());

                // find data di db
                Service? service = await _context.Services.Where(s => s.IdService == serId).FirstOrDefaultAsync();

                // simpan data ke var
                serviceId = service.IdService;
                serviceName = service.NameService;
                price = service.PriceUnitService;
                duration = service.EstimationDurationService;
                unit = (int)NUDTotalUnit.Value;
                subTotal = price * unit;

                // add to list
                servicesList.Add(new ServiceTransactionModel { IdService = serviceId, ServiceName = serviceName, ServicePrice = price, TotalUnit = unit, EstimationTimePerService = duration, SubTotal = subTotal });

                // bikin variable buat nyimpen all price dan duration
                allPrice += subTotal;
                allDuration += duration;

                serviceTransactionModelBindingSource.DataSource = servicesList.ToList();
                dataGridView1.Refresh();

                // ubah text pada label
                lblPay.Text = "Rp. " + allPrice.ToString();
                lblHour.Text = allDuration.ToString() + " hours";
            }
        }

        private void autoCompleteInPhone(object sender, EventArgs e)
        {
            var phoneNum = _context.Customers.Local.Select(c => c.PhoneNumberCustomer).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(phoneNum);
            txtPhoneNum.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPhoneNum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPhoneNum.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private async void txtPhone_LeaveFocus(object sender, EventArgs e)
        {
            string pNum = txtPhoneNum.Text;
            Customer? customer = await _context.Customers.Where(c => c.PhoneNumberCustomer == pNum).FirstOrDefaultAsync();

            //cek kalo null
            if (customer == null) return;
            else
            {
                txtName.Text = customer.NameCostumer;
                RTAddress.Text = customer.AddressCostumer;
                idCustomer = customer.IdCustomer;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPhoneNum.Text == "")
            {
                MessageBox.Show("Please cek your identity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (servicesList.Count < 1)
            {
                MessageBox.Show("You have to add service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                await SaveDbHeader();
            }
        }

        private async Task SaveDbHeader()
        {
            // GET ID EMPLOYEE
            Employee? employee = await _context.Employees.Where(e => e.NameEmployee == employeeName).FirstOrDefaultAsync();
            idEmployee = employee.IdEmployee;

            // CREATE HEADER TRANSACTION
            HeaderTransaction headTrans = new HeaderTransaction();
            headTrans.IdCostumer = idCustomer;
            headTrans.IdEmployee = idEmployee;
            headTrans.TransactionDateTimeHeaderTransaction = DateTime.Now;

            DateTime dt = DateTime.Now;
            DateTime dateTime = dt.AddHours((double)duration);
            headTrans.CompleteEstimationDateTimeHeaderTransaction = dateTime;

            _context.HeaderTransactions.Add(headTrans);
            await _context.SaveChangesAsync();
            // get id header transaction
            idHeaderTrans = headTrans.IdHeaderTransaction;

            // CREATE DETAIL TRANSACTION AND LOOPING LIST
            foreach (var item in servicesList)
            {
                DetailTransaction detailTransaction = new DetailTransaction();
                detailTransaction.IdService = item.IdService;
                detailTransaction.IdHeaderTransaction = idHeaderTrans;
                detailTransaction.PriceDetailTransaction = item.ServicePrice;
                detailTransaction.TotalUnitTransaction = item.TotalUnit;
                detailTransaction.CompletedDatetimeDetailTransaction = DateTime.Now;

                // SAVE KE DB
                _context.DetailTransactions.Add(detailTransaction);
                await _context.SaveChangesAsync();
            }

            // KASIH ALERT
            MessageBox.Show("Transaction Added", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            linkAdd.LinkVisited = true;
            addCustomerForm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // ubah label pay & hour
            lblPay.Text = (allPrice - getService.ServicePrice).ToString();
            lblHour.Text = (allDuration - getService.EstimationTimePerService).ToString();
            
            // remove from list
            servicesList.Remove(getService);

            // refresh dgv
            serviceTransactionModelBindingSource.DataSource = servicesList.ToList();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            
            // get service dari list
            getService = servicesList.ElementAt(index);
        }
    }
}
