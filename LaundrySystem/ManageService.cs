using LaundrySystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaundrySystem
{
    public partial class ManageService : Form
    {
        DataContext? _context;
        private string? operation, clicked, category, unit;
        private int? selectedServiceId;
        public ManageService()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = _context ?? new DataContext();
            _context.Categories.Load();
            _context.Services.Load();
            _context.Units.Load();
            _context.viewManageServices.Load();

            lblTime.Text = DateTime.Now.ToString();
            viewManageServiceBindingSource.DataSource = _context.viewManageServices.Local.ToBindingList();

            Hide();
            btnCancel.Hide();
            btnSave.Hide();
            cmbSerach.Items.Add("Name Service");
            cmbSerach.Items.Add("Unit");
            //cmbSerach.Items.Add("Price");
            cmbSerach.Items.Add("Category");
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void autoCompleteByName()
        {
            var name = _context.Services.Local.Select(n => n.NameService).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(name);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void autoCompleteByUnit()
        {
            var unit = _context.Units.Local.Select(n => n.NameUnit).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(unit);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        /*private void autoCompleteByPrice()
        {
            var price = _context.Services.Local.Select(n => n.PriceUnitService).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(Convert.ToInt32(Math.Round(price, 0)));
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }*/

        private void autoCompleteByCategory()
        {
            var category = _context.Categories.Local.Select(n => n.NameCategory).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(category);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void Search(object sender, EventArgs e)
        {
            if (cmbSerach.Text == "Name Service")
            {
                autoCompleteByName();
            }
            else if (cmbSerach.Text == "Unit")
            {
                autoCompleteByUnit();
            }
            else if (cmbSerach.Text == "Category")
            {
                autoCompleteByCategory();
            }
            else
            {
                return;
            }
        }

        private async void txtSearch_LeaveFocus(object sender, EventArgs e)
        {
            if (cmbSerach.Text == "Name Service")
            {
                _context.viewManageServices.Load();
                string name = txtSearch.Text;
                List<ViewManageService>? viewManageServices = await _context.viewManageServices
                                                                .Where(v => v.NameService == name)
                                                                .ToListAsync();

                viewManageServiceBindingSource.DataSource = viewManageServices.ToList();
                dataGridView1.Refresh();
            }
            else if (cmbSerach.Text == "Unit")
            {
                _context.viewManageServices.Load();
                string unit = txtSearch.Text;
                List<ViewManageService>? viewManageServices = await _context.viewManageServices
                                                                .Where(v => v.NameUnit == unit)
                                                                .ToListAsync();

                viewManageServiceBindingSource.DataSource = viewManageServices.ToList();
                dataGridView1.Refresh();
            }
            else if (txtSearch.Text == "Category")
            {
                _context.viewManageServices.Load();
                string category = txtSearch.Text;
                List<ViewManageService>? viewManageServices = await _context.viewManageServices
                                                                .Where(v => v.NameCategory == category)
                                                                .ToListAsync();

                viewManageServiceBindingSource.DataSource = viewManageServices.ToList();
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
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();

            txtServiceName.Hide();
            cmbCategory.Hide();
            cmbUnit.Hide();
            NUDPrice.Hide();
            NUDDuration.Hide();
        }

        private void Show()
        {
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();

            txtServiceName.Show();
            cmbCategory.Show();
            cmbUnit.Show();
            NUDPrice.Show();
            NUDDuration.Show();
        }
        private void EnabledFalse()
        {
            txtServiceName.Enabled = false;
            cmbCategory.Enabled = false;
            cmbUnit.Enabled = false;
            NUDPrice.Enabled = false;
            NUDDuration.Enabled = false;
        }

        private void EnabledTrue()
        {
            txtServiceName.Enabled = true;
            cmbCategory.Enabled = true;
            cmbUnit.Enabled = true;
            NUDPrice.Enabled = true;
            NUDDuration.Enabled = true;
        }

        private void ClearedField()
        {
            txtServiceName.Text = "";
            cmbCategory.Text = "";
            cmbUnit.Text = "";
            NUDPrice.Text = "";
            NUDDuration.Text = "";
        }

        private void CmbCategory()
        {
            _context.Categories.Load();
            var data = _context.Categories.Local.ToList();
            cmbCategory.DisplayMember = "NameCategory";
            cmbCategory.ValueMember = "IdCategory";
            cmbCategory.DataSource = data;
        }

        private void CmbUnit()
        {
            _context.Units.Load();
            var data = _context.Units.Local.ToList();
            cmbUnit.DisplayMember = "NameUnit";
            cmbUnit.ValueMember = "IdUnit";
            cmbUnit.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedService = (ViewManageService)viewManageServiceBindingSource.List[index];
            selectedServiceId = selectedService.IdService;
            clicked = "click";

            Show();
            EnabledFalse();

            txtServiceName.Text = row.Cells[4].Value.ToString();
            cmbCategory.Text = row.Cells[0].Value.ToString();
            cmbUnit.Text = row.Cells[7].Value.ToString();
            NUDDuration.Text = row.Cells[6].Value.ToString();
            NUDPrice.Text = row.Cells[5].Value.ToString();

            category = row.Cells[0].Value.ToString();
            unit = row.Cells[7].Value.ToString();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Show();
            EnabledTrue();
            ClearedField();
            btnInsert.Hide();
            btnDelete.Hide();
            btnUpdate.Hide();
            btnSave.Show();
            btnCancel.Show();
            CmbCategory();
            CmbUnit();

            operation = "insert";
        }

        private async void actionInsert()
        {
            if (txtServiceName.Text == "" || cmbCategory.Text == "" || cmbUnit.Text == "" || NUDDuration.Value < 0 || NUDPrice.Value < 0)
            {
                MessageBox.Show("You must enter data completely", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // get category type
                string catText = cmbCategory.SelectedItem.ToString();
                int catId = int.Parse(cmbCategory.SelectedValue.ToString());
                Category? categories = await _context.Categories
                                        .Where(c => c.IdCategory == catId)
                                        .FirstOrDefaultAsync();

                // get Unit type
                string unText = cmbUnit.SelectedItem.ToString();
                int unId = int.Parse(cmbUnit.SelectedValue.ToString());
                Unit? units = await _context.Units
                                        .Where(c => c.IdUnit == unId)
                                        .FirstOrDefaultAsync();

                Service service = new Service();
                service.NameService = txtServiceName.Text;
                service.IdCategory = catId;
                service.IdUnit = unId;
                service.PriceUnitService = Convert.ToInt32(Math.Round(NUDPrice.Value, 0));
                service.EstimationDurationService = Convert.ToInt32(Math.Round(NUDDuration.Value, 0));

                _context.Services.Add(service);
                await _context.SaveChangesAsync();
                _context.viewManageServices.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully inserted new employee data with ID : " + service.IdService, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clicked == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Show();
                btnInsert.Hide();
                btnDelete.Hide();
                btnUpdate.Hide();
                EnabledTrue();
                btnSave.Show();
                btnCancel.Show();
                CmbCategory();
                cmbCategory.Text = category;
                CmbUnit();
                cmbUnit.Text = unit;

                operation = "update";
            }
        }

        private async void actionUpdate()

        {
            if (selectedServiceId != null)
            {
                // get service id
                Service? service = await _context.Services.Where(e => e.IdService == selectedServiceId).FirstOrDefaultAsync();

                // get category type
                string catName = cmbCategory.SelectedItem.ToString();
                int catId = int.Parse(cmbCategory.SelectedValue.ToString());
                Category? categories = await _context.Categories
                                        .Where(c => c.IdCategory == catId)
                                        .FirstOrDefaultAsync();

                // get unit type
                string unText = cmbCategory.SelectedItem.ToString();
                int unId = int.Parse(cmbCategory.SelectedValue.ToString());
                Unit? units = await _context.Units
                                        .Where(c => c.IdUnit == unId)
                                        .FirstOrDefaultAsync();

                service.NameService = txtServiceName.Text;
                service.IdCategory = catId;
                service.IdUnit = unId;
                service.PriceUnitService = Convert.ToInt32(Math.Round(NUDPrice.Value, 0));
                service.EstimationDurationService = Convert.ToInt32(Math.Round(NUDDuration.Value, 0));

                _context.Services.Update(service);
                await _context.SaveChangesAsync();
                _context.viewManageServices.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully updated employee data with ID : " + service.IdService, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can't updated, because the data unavaible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clicked == null)
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
            if (selectedServiceId != null)
            {
                Service? service = await _context.Services.Where(s => s.IdService == selectedServiceId).FirstOrDefaultAsync();
                if (MessageBox.Show("Are you sure you want to delete " + service.NameService + " from this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    _context.Services.Remove(service);
                    await _context.SaveChangesAsync();
                    selectedServiceId = null;
                    _context.viewManageServices.Load();
                    dataGridView1.Refresh();
                    MessageBox.Show("Successfully updated employee data with Name : " + service.NameService, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ClearedField();

            btnSave.Hide();
            btnCancel.Hide();

            EnabledTrue();
        }
    }
}
