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
    public partial class PackageTransaction : Form
    {
        DataContext? _context;
        private string employeeName;
        private int allPrice, allDuration, idEmployee, idCustomer, idHeaderTrans;
        private int packageId, packPrice, quantity, estimationTime, subTotal;
        private string packageName;
        List<PackageTransactionModel> packagesList = new List<PackageTransactionModel>();
        private PackageTransactionModel getPackage;

        public PackageTransaction()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = _context ?? new DataContext();
            _context.Customers.Load();
            _context.Packages.Load();
            _context.HeaderTransactions.Load();
            _context.DetailTransactions.Load();

            packageTransactionModelBindingSource.DataSource = packagesList.ToList();

            lblTime.Text = DateTime.Now.ToString();
            CmbPackage();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        public void SayHello(string name)
        {
            lblHay.Text = $"Hello, {name}";
            employeeName = name;
        }

        private void CmbPackage()
        {
            _context.Packages.Load();
            var data = _context.Packages.Local.ToList();
            cmbPackage.DisplayMember = "NamePackage";
            cmbPackage.ValueMember = "IdPackage";
            cmbPackage.DataSource = data;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (NUDQuantity.Value < 1)
            {
                MessageBox.Show("The quantity package is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // get value from combobox
                string packName = cmbPackage.SelectedItem.ToString();
                int packId = int.Parse(cmbPackage.SelectedValue.ToString());

                // find data di db
                Package? package = await _context.Packages.Where(p => p.IdPackage == packId).FirstOrDefaultAsync();

                // save data to variable
                packageId = package.IdPackage;
                packageName = package.NamePackage;
                packPrice = (int)package.PricePackage;
                quantity = (int)NUDQuantity.Value;
                estimationTime = (int)package.DurationPackage;
                subTotal = quantity * packPrice;

                // add to list
                packagesList.Add(new PackageTransactionModel { IdPackage = packageId, PackageName = packageName, PackagePrice = packPrice, Quantity = quantity, EstimationTimePerPackage = estimationTime, SubTotal = subTotal });

                // simpan all price and duration to variable
                allPrice += subTotal;
                allDuration += estimationTime;

                // pastikan dgv berjalan sempurna
                packageTransactionModelBindingSource.DataSource = packagesList.ToList();
                dataGridView1.Refresh();

                // ubah text pada label
                lblPay.Text = "Rp. " + allPrice.ToString();
                lblHour.Text = allDuration.ToString() + " hours";
            }
        }

        private void autoCompleteInPhone(object sender, EventArgs e)
        {
            var data = _context.Customers.Local.Select(c => c.PhoneNumberCustomer).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(data);
            txtPhoneNum.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPhoneNum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPhoneNum.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private async void txtPhoneNum_LeaveFocus(object sender, EventArgs e)
        {
            string pNum = txtPhoneNum.Text;
            Customer? customer = await _context.Customers.Where(c => c.PhoneNumberCustomer == pNum).FirstOrDefaultAsync();

            // cek kalo null
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
            else if (packagesList.Count < 1)
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
            DateTime dateTime = dt.AddHours((double)estimationTime);
            headTrans.CompleteEstimationDateTimeHeaderTransaction = dateTime;

            _context.HeaderTransactions.Add(headTrans);
            await _context.SaveChangesAsync();

            // get id header transaction
            idHeaderTrans = headTrans.IdHeaderTransaction;

            // CREATE DETAIL TRANSACTION AND LOOPING LIST
            foreach (var item in packagesList)
            {
                DetailTransaction detailTransaction = new DetailTransaction();
                detailTransaction.IdPackage = item.IdPackage;
                detailTransaction.IdHeaderTransaction = idHeaderTrans;
                detailTransaction.PriceDetailTransaction = item.PackagePrice;
                detailTransaction.TotalUnitTransaction = item.Quantity;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            // get package dari list
            getPackage = packagesList.ElementAt(index);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // ubah label
            lblPay.Text = (allPrice - getPackage.PackagePrice).ToString();
            lblHour.Text = (allDuration - getPackage.EstimationTimePerPackage).ToString();

            // remove dari list
            packagesList.Remove(getPackage);

            packageTransactionModelBindingSource.DataSource = packagesList.ToList();
            dataGridView1.Refresh();
        }
    }
}
