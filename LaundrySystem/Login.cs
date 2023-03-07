using LaundrySystem.Model;
using Microsoft.EntityFrameworkCore;

namespace LaundrySystem
{
    public partial class Login : Form
    {
        private DataContext? _context;
        public Login()
        {
            InitializeComponent();

            _context = new DataContext();
            _context.Database.EnsureCreated();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = _context ?? new DataContext();
            _context.Employees.Load();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Employee? employee = await _context.Employees
                                  .Where(e => e.EmailEmploye == txtUsername.Text)
                                  .FirstOrDefaultAsync();

            if (employee == null)
            {
                MessageBox.Show("Please try again, your data is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (employee.PasswordEmployee == txtPassword.Text)
                {
                    MainForm mainFrom = new MainForm();
                    mainFrom.SayHello(employee.NameEmployee);
                    mainFrom.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please try again, your password is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}