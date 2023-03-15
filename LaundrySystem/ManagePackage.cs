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
        private string packageName;
        private string description;
        private string stringPrice;

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
            cmbSerach.Items.Add("Name Package");
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void autoCompleteByName(object sender, EventArgs e)
        {
            var namePack = _context.Packages.Local.Select(p => p.NamePackage).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(namePack);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private async void txtSearch_LeaveFocus(object sender, EventArgs e)
        {
            _context.Packages.Load();
            string name = txtSearch.Text;
            List<Package>? packages = await _context.Packages.Where(v => v.NamePackage.Contains(name)).ToListAsync();

            packageBindingSource.DataSource = packages.ToList();
            dataGridView1.Refresh();
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

        private async Task loadServiceDG(int? packageId)
        {
            List<ViewManagePackage>? viewManagePackage = await _context.viewManagePackages.Where(v => v.IdPackage == packageId).ToListAsync();
            viewManagePackageBindingSource1.DataSource = viewManagePackage.ToList();
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


            ServiceShow();

            packageName = row.Cells[1].Value.ToString();
            description = row.Cells[3].Value.ToString();
            stringPrice = row.Cells[2].Value.ToString();

            await loadServiceDG(selectedPackageId);

        }

        private async void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Delete")
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView2.Rows[index];
                var selectedService = (ViewManagePackage)viewManagePackageBindingSource1.List[index];
                int selectedServiceId = (int)selectedService.IdService;
                int idDEtailPack = (int)selectedService.IdDetailPackage;
                int esDurSer = (int)selectedService.EstimationDurationService;
                int idPack = (int)selectedService.IdPackage;

                if (MessageBox.Show("Are you sure want to delete this service?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Menghapus detail package dari db berdasarkan id dari package
                    DetailPackage? detailPackage = await _context.DetailPackages.Where(i => i.IdDetailPackage == idDEtailPack).FirstOrDefaultAsync();
                    _context.DetailPackages.Remove(detailPackage);

                    Package? package = await _context.Packages.Where(p => p.IdPackage == idPack).FirstOrDefaultAsync();
                    package.DurationPackage = package.DurationPackage - esDurSer;
                    await _context.SaveChangesAsync();
                    _context.Packages.Load();
                    dataGridView1.Refresh();

                    await loadServiceDG(selectedPackageId);
                    MessageBox.Show("Successfully deleted service", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else return;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string serName = cmbService.SelectedItem.ToString();
            int serId = int.Parse(cmbService.SelectedValue.ToString());

            if (NUDTotalUnit.Value < 1)
            {
                MessageBox.Show("Cant add, please cek unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (selectedPackageId != null)
            {
                // get package
                Package? package = await _context.Packages.Where(p => p.IdPackage == selectedPackageId).FirstOrDefaultAsync();

                // create new detail package
                DetailPackage detailPackage = new DetailPackage();
                detailPackage.IdPackage = package.IdPackage;
                detailPackage.IdService = serId;
                detailPackage.TotalUnitServiceDetailPackage = Convert.ToInt32(Math.Round(NUDTotalUnit.Value, 0));
                _context.DetailPackages.Add(detailPackage);

                // untuk menambahkan duratioon package sesuai dgn service yg baru
                Service? service = await _context.Services.Where(p => p.IdService == serId).FirstOrDefaultAsync();
                package.DurationPackage = package.DurationPackage + service.EstimationDurationService;
                _context.Packages.Update(package);

                // save ke db
                await _context.SaveChangesAsync();
                // lload package dan refresh dgview
                _context.Packages.Load();
                dataGridView1.Refresh();
                await loadServiceDG(selectedPackageId);


                MessageBox.Show("Successfully added service " + service.NameService +" to "+package.NamePackage , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async Task actionInsert()
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var cek = RTDescription.Text;
            switch (operation)
            {
                case "insert":
                    await actionInsert(); break;
                case "update":
                    await actionUpdate(); break;
                case "delete":
                    await actionDelete(); break;
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
                txtPackName.Text = packageName;
                RTDescription.Text = description;
                NUDPrice.Value = Convert.ToInt32(stringPrice);
                BtnUIDHide();
                ServiceHide();
                PackageShow();
                EnabledTrue();

                operation = "update";
                lblAction.Text = "Action Update";
            }
        }

        private async Task actionUpdate()
        {
            if (selectedPackageId != null)
            {
                Package? package = await _context.Packages.Where(i => i.IdPackage == selectedPackageId).FirstOrDefaultAsync();
                var des = RTDescription.Text;
                string name = txtPackName.Text;
                package.DescriptionPackage = des;
                package.PricePackage = Convert.ToInt32(Math.Round(NUDPrice.Value, 0));
                package.NamePackage = name;
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

        private async Task actionDelete()
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
                    MessageBox.Show("Successfully deleted package data with Name : " + package.NamePackage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
