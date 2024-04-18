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
    public partial class WithdrawForm : Form
    {
        AccountDashboard accountDashboard;
        AccountManager accountManager;
        Account account;
        public WithdrawForm(AccountDashboard accountDashboard, AccountManager accountManager,Account account, TransactionManager transactionManager)
        {
            InitializeComponent();
            this.accountDashboard = accountDashboard;
            this.accountManager = accountManager;
            this.account = account;
            accountNumber_input.Text = account.AccountNumber.ToString();
            currentBalance_input.Text = account.Balance.ToString();
        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ClearForm()
        {
            accountNumber_input.Text = "";
            currentBalance_input.Text = "";
            withdraw_input.Text = "";
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(withdraw_input.Text, out decimal withdrawAmount))
            {
               
                if (withdrawAmount < account.Balance)
                {
                    accountManager.Withdraw(account.Username, withdrawAmount);
                    MessageBox.Show("Withdraw successful. New balance: " + account.Balance);
                    Close();
                    accountDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Insufficient Funds");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric amount to withdraw.");
            }

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
            accountDashboard.Show();
        }
    }
}
