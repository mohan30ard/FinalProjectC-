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
    public partial class Main : Form
    {
        AccountManager accountManager = new AccountManager(new AccountDB());
        TransactionManager transactionManager = new TransactionManager(new TransactionDB());
        public Main()
        {
            InitializeComponent();
        }

        private void load_ui()
        {
            label1.Text = "Welcome to the Iron Bank";
            label2.Text = "New to Iron Bank \nClick Here to Register";
            label3.Text = "Already a member \nClick Here to Login";
            button1.Text = "Register";
            button2.Text = "Login";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountCreationRequest accountCreationRequest = new AccountCreationRequest(this,accountManager ,transactionManager);
            accountCreationRequest.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountLogin accountLogin = new AccountLogin(this, accountManager, transactionManager);
            accountLogin.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            load_ui();
            LoadDummies();
        }

        private void LoadDummies()
        {
            accountManager.CreateAccount("Alice Johnson", "789 Elm St", "alice.johnson@example.com", "111-222-3333", 787899098, "password", 500.75m);
            accountManager.CreateAccount("Jane Smith", "456 Oak St", "jane.smith@example.com", "987-654-3210", 987654321, "password", 2500.50m);
            accountManager.CreateAccount("Bob Johnson", "321 Pine St", "bob.johnson@example.com", "555-666-7777", 555666777, "password", 10000.00m);
        }
    }
}
