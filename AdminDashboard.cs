using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phase_1
{
    public partial class AdminDashboard : Form
    {
        AccountLogin accountLogin;
        AccountManager accountManager;
        bool approvalRequestsSelected = false;
        bool deletionRequestsSelected = false;
        bool updateRequestsSelected = false;
        public AdminDashboard(AccountLogin accountLogin, AccountManager accountManager, TransactionManager transactionManager)
        {
            InitializeComponent();
            this.accountLogin = accountLogin;
            this.accountManager = accountManager;
            SetDefaultFlags();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            approvalRequestsSelected = true;
            deletionRequestsSelected = false;
            updateRequestsSelected = false;
            RefreshListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deletionRequestsSelected = true;
            approvalRequestsSelected = false;
            updateRequestsSelected = false;
            RefreshListBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateRequestsSelected = true;
            approvalRequestsSelected = false;
            deletionRequestsSelected = false;
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            listBox1.Items.Clear();
            if (approvalRequestsSelected)
            {
                accountManager.ApprovalRequests.ForEach(account =>
                {
                    listBox1.Items.Add(accountManager.AddtoListBox(account));
                });
            }
            else if (deletionRequestsSelected)
            {
                accountManager.DeletionRequests.ForEach(account =>
                {
                    listBox1.Items.Add(accountManager.AddtoListBox(account));
                });
            }
            else if (updateRequestsSelected)
            {
                accountManager.Accounts.ForEach(account =>
                {
                    listBox1.Items.Add(accountManager.AddtoListBox(account));
                });
            }
            else
            {
                MessageBox.Show("Please select an option from the list");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (approvalRequestsSelected)
                {
                    Account selectedAccount = accountManager.ApprovalRequests[listBox1.SelectedIndex];
                    AccountRequest account = new AccountRequest(this, accountManager, selectedAccount, "APPROVE");
                    account.Show();
                    Hide();
                }
                else if (deletionRequestsSelected)
                {
                    Account selectedAccount = accountManager.DeletionRequests[listBox1.SelectedIndex];
                    AccountRequest account = new AccountRequest(this, accountManager, selectedAccount, "DELETE");
                    account.Show();
                    Hide();
                }
                else if (updateRequestsSelected)
                {
                    Account selectedAccount = accountManager.Accounts[listBox1.SelectedIndex];
                    AccountRequest account = new AccountRequest(this, accountManager, selectedAccount, "UPDATE");
                    account.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Please select an account from the list");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ViewAccounts viewAccounts = new ViewAccounts(this, accountManager);
            viewAccounts.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
            accountLogin.Show();
        }

        public void SetDefaultFlags()
        {
            approvalRequestsSelected = false;
            deletionRequestsSelected = false;
            updateRequestsSelected = false;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
