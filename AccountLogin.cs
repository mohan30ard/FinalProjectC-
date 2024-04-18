using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phase_1
{
    public partial class AccountLogin : Form
    {
        Main main;
        AccountManager accountManager;
        private Dictionary<string, string> users;
        TransactionManager transactionManager;
        
        public AccountLogin(Main main,AccountManager accountManager, TransactionManager transactionManager)
        {
            InitializeComponent();
            this.main = main;
            this.accountManager = accountManager;
            users = accountManager.Users;
            this.transactionManager = transactionManager;
        }

        private void AccountLogin_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (users.ContainsKey(username) && users[username] == password)
            {
                if (username == "admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard(this, accountManager, transactionManager);
                    adminDashboard.Show();
                }
                else if(accountManager.IsAccountLocked(username))
                {
                    MessageBox.Show("Account is locked");
                }
                else
                {
                    AccountDashboard customerForm = new AccountDashboard(this,accountManager,username , transactionManager);
                    customerForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }
    }
}
