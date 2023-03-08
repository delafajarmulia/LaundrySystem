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
    public partial class ManagePackage : Form
    {
        DataContext? _context;
        private int? selectedPackageId;
        private int estimationDuration;
        private string? operation;
        private string packageName, description, stringPrice;
        public ManagePackage()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = _context ?? new DataContext();
            _context.DetailPackages.Load();
            _context.Packages.Load();
            _context.Services.Load();
            _context.viewManagePackages.Load();

            packageBindingSource.DataSource = _context.Packages.Local.ToBindingList();

            lblTime.Text = DateTime.Now.ToString();
            ServiceHide();
            BtnUIDShow();
            PackageHide();
            CmbService();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void ServiceShow()
        {
            label5.Show();
            label6.Show();
            cmbService.Show();
            NUDTotalUnit.Show();
            btnAdd.Show();
        }

        private void ServiceHide()
        {
            label5.Hide();
            label6.Hide();
            cmbService.Hide();
            NUDTotalUnit.Hide();
            btnAdd.Hide();
        }

        private void PackageHide()
        {
            label2.Hide();
            label3.Hide();
            label4.Hide();
            txtPackName.Hide();
            RTDescription.Hide();
            NUDPrice.Hide();
        }

        private void PackageShow()
        {
            label2.Show();
            label3.Show();
            label4.Show();
            txtPackName.Show();
            RTDescription.Show();
            NUDPrice.Show();
        }

        private void BtnUIDShow()
        {
            btnDelete.Show();
            btnInsert.Show();
            btnUpdate.Show();

            btnSave.Hide();
            btnCancel.Hide();
        }

        private void BtnUIDHide()
        {
            btnDelete.Hide();
            btnInsert.Hide();
            btnUpdate.Hide();

            btnSave.Show();
            btnCancel.Show();
        }

        private void EnabledFalse()
        {
            label2.Enabled = false;
            label4.Enabled = false;
            label3.Enabled = false;
            txtPackName.Enabled = false;
            RTDescription.Enabled = false;
            NUDPrice.Enabled = false;
        }

        private void EnabledTrue()
        {
            label2.Enabled = true;
            label4.Enabled = true;
            label3.Enabled = true;
            txtPackName.Enabled = true;
            RTDescription.Enabled = true;
            NUDPrice.Enabled = true;
        }

        private void CmbService()
        {
            _context.Services.Load();
            var data = _context.Services.Local.ToList();
            cmbService.DisplayMember = "NameService";
            cmbService.ValueMember = "IdService";
            cmbService.DataSource = data;
        }

        private void ClearedField()
        {
            txtPackName.Text = "";
            RTDescription.Text = "";
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

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _context.Packages.Load();
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedPackage = (Package)packageBindingSource.List[index];
            selectedPackageId = selectedPackage.IdPackage;
            estimationDuration = 0;

            ServiceShow();

            packageName = row.Cells[1].Value.ToString();
            description = row.Cells[3].Value.ToString();
            stringPrice = row.Cells[2].Value.ToString();

            List<ViewManagePackage>? viewManagePackage = await _context.viewManagePackages.Where(v => v.IdPackage == selectedPackageId).ToListAsync();
            viewManagePackageBindingSource1.DataSource = viewManagePackage.ToList();
            foreach (var p in viewManagePackage)
            {

                estimationDuration += p.EstimationDurationService;

            }
            dataGridView2.Refresh();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string serName = cmbService.SelectedItem.ToString();
            int serId = int.Parse(cmbService.SelectedValue.ToString());
            DetailPackage? detailPackages = await _context.DetailPackages.Where(d => d.IdPackage == serId).FirstOrDefaultAsync();

            if (NUDTotalUnit.Value < 1)
            {
                MessageBox.Show("Cant add, please cek unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (selectedPackageId != null)
            {
                Package? package = await _context.Packages.Where(p => p.IdPackage == selectedPackageId).FirstOrDefaultAsync();
                DetailPackage detailPackage = new DetailPackage();
                detailPackage.IdPackage = package.IdPackage;
                detailPackage.IdService = serId;
                detailPackage.TotalUnitServiceDetailPackage = Convert.ToInt32(Math.Round(NUDTotalUnit.Value, 0));

                _context.DetailPackages.Add(detailPackage);
                _context.SaveChangesAsync();
                dataGridView2.Refresh();
                MessageBox.Show($"Successfully added service {serName} to {package.NamePackage}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            PackageShow();
            BtnUIDHide();
            EnabledTrue();
            ClearedField();
            ServiceHide();
            operation = "insert";
            lblAction.Text = "Action Insert";
        }

        private async void actionInsert()
        {
            if (txtPackName.Text == "" || RTDescription.Text == "" || NUDPrice.Value < 0)
            {
                MessageBox.Show("You must enter data completely", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Package package = new Package();
                package.NamePackage = txtPackName.Text;
                package.DescriptionPackage = RTDescription.Text;
                package.PricePackage = Convert.ToInt32(Math.Round(NUDPrice.Value, 0));
                package.DurationPackage = estimationDuration;

                _context.Packages.Add(package);
                await _context.SaveChangesAsync();
                _context.Packages.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully inserted new package data with ID : " + package.IdPackage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            BtnUIDShow();
            ClearedField();
            PackageHide();
            ServiceHide();
            dataGridView2.Rows.Clear(); 
            lblAction.Text = "Select Action";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPackageId == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtPackName.Text = packageName.ToString() + txtPackName.Text.ToString();
                RTDescription.Text = description.ToString() + RTDescription.Text.ToString();
                NUDPrice.Value = Convert.ToInt32(stringPrice);
                BtnUIDHide();
                ServiceHide();
                PackageShow();
                EnabledTrue();

                operation = "update";
                lblAction.Text = "Action Update";
            }
        }

        private async void actionUpdate()
        {
            if (selectedPackageId != null)
            {
                Package? package = await _context.Packages.Where(i => i.IdPackage == selectedPackageId).FirstOrDefaultAsync();
                package.DescriptionPackage = RTDescription.Text;
                package.PricePackage = Convert.ToInt32(Math.Round(NUDPrice.Value, 0));
                package.NamePackage = txtPackName.Text;
                package.DurationPackage = estimationDuration;

                _context.Packages.Update(package);
                await _context.SaveChangesAsync();
                _context.Packages.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully updated package data with ID : " + package.IdPackage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can't updated, because the data unavaible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPackageId == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PackageShow();
                EnabledFalse();
                ServiceHide();
                BtnUIDHide();
                operation = "delete";
                lblAction.Text = "Action Delete";
            }
        }

        private async void actionDelete()
        {
            if (selectedPackageId != null)
            {
                Package? package = await _context.Packages.Where(p => p.IdPackage == selectedPackageId).FirstOrDefaultAsync();
                if (MessageBox.Show("Are you sure you want to delete " + package.NamePackage + " from this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    _context.Packages.Remove(package);
                    await _context.SaveChangesAsync();
                    _context.Packages.Load();
                    dataGridView1.Refresh();
                    MessageBox.Show("Successfully updated package data with Name : " + package.NamePackage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Can't deleted, because the data unavaible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            selectedPackageId = null;
            operation = null;
            ClearedField();
            BtnUIDShow();
            PackageHide();
            ServiceHide();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            lblAction.Text = "Canceled Action";
        }
    }
}
