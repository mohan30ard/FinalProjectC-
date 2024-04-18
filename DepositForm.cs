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
    public partial class DepositForm : Form
    {
        AccountDashboard accountDashboard;
        AccountManager accountManager;
        Account account;
        TransactionManager  transactionManager;
        public DepositForm(AccountDashboard accountDashboard,AccountManager accountManager,Account account, TransactionManager transactionManager)
        {
            InitializeComponent();
            this.accountDashboard = accountDashboard;
            this.accountManager = accountManager;
            this.account = account;
            accountNumber_input.Text = account.AccountNumber.ToString();
            currentBalance_input.Text = account.Balance.ToString();
            this.transactionManager = transactionManager;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(deposit_input.Text, out decimal depositAmount))
            {
                // Ensure the deposit amount is positive
                if (depositAmount > 0)
                {
                    // Update the account balance and close the form
                    accountManager.Deposit(account.Username, depositAmount);
                    DateTime transactionDate = DateTime.Now;
                    Transaction transaction = new Transaction(account.AccountNumber, "Deposit", depositAmount, transactionDate);
                    transactionManager.AddTransaction(transaction);
                    MessageBox.Show("Deposit successful. New balance: " + account.Balance);
                    Close();
                    accountDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Please enter a positive amount to deposit.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric amount to deposit.");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
            accountDashboard.Show();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {

        }
    }
}
