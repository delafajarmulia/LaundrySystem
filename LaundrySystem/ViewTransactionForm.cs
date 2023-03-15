using LaundrySystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem
{
    public partial class ViewTransactionForm : Form
    {
        DataContext? _context;
        DataTable dt = new DataTable();
        private int selectedIdHeader;
        
        public ViewTransactionForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = _context ?? new DataContext();
            _context.viewHeaderTransactions.Load();
            _context.viewDetailTransactions.Load();
            viewHeaderTransactionBindingSource.DataSource = _context.viewHeaderTransactions.Local.ToList();

            lblTime.Text = DateTime.Now.ToString();
            dt.Columns.Add("Name");
            dt.Columns.Add("Type");
            dt.Columns.Add("Price per Unit");
            dt.Columns.Add("Total Unit");
            dt.Columns.Add("Complete Time");
            dataGridView2.DataSource = dt;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        public void SayHelllo(string name)
        {
            lblHay.Text = $"Hello, {name}";
        }

        private async Task loadDetailTransDG(int? headerId)
        {
            // atur di dgview
            DataRow dr = dt.NewRow();

            List<ViewDetailTransaction>? detail = await _context.viewDetailTransactions.Where(d => d.IdHeaderTransaction == headerId).ToListAsync();

            // foreach
            foreach (var item in detail)
            {
                dr[0] = item.IdPackage == null ? item.NameService : item.NamePackage;
                dr[1] = item.IdPackage == null ? "Service" : "Package";
                dr[2] = item.IdPackage == null ? item.PriceUnitService : item.PricePackage;
                dr[3] = item.TotalUnitTransaction;

                dt.Rows.Add(dr.ItemArray);
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
            }
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _context.viewManagePackages.Load();
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedTrans = (ViewHeaderTransaction)viewHeaderTransactionBindingSource[index];
            selectedIdHeader = selectedTrans.IdHeaderTransaction;

            await loadDetailTransDG(selectedIdHeader);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Action")
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView2.Rows[index];
                row.Cells[5].Value = DateTime.Now.ToString();
            }
        }
    }
}
