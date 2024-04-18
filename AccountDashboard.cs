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
    public partial class AccountDashboard : Form
    {
        AccountLogin accountLogin;
        AccountManager accountManager;
        string username;
        Account account;
        TransactionManager transactionManager;

        public AccountDashboard(AccountLogin accountLogin, AccountManager accountManager, string username, TransactionManager transactionManager)
        {
            InitializeComponent();
            this.accountLogin = accountLogin;
            this.accountManager = accountManager;
            this.username = username;
            this.transactionManager = transactionManager;
        }

        private void btnAccountSummary_Click(object sender, EventArgs e)
        {
            manageListBox(true);
            account = accountManager.GetAccount(username);

            label5.Text = "Welcome to Iron Bank \n" +
                        "Name : " + account.Name + "\n" +
                "Account Number : " + account.AccountNumber + "\n" +
                "Address : " + account.Address + "\n" +
                "Email : " + account.Email + "\n" +
                "Phone Number : " + account.PhoneNumber + "\n" +
                "SSN : " + account.SSN + "\n" +
                "Username : " + account.Username + "\n" +
                "Balance : " + account.Balance + "\n" +
                "Locked : " + account.IsLocked + "\n";

        }

        private void AccountDashboard_Load(object sender, EventArgs e)
        {
            btnAccountSummary_Click(sender, e);
            label2.Text = account.Username;
            manageListBox(true);
            transactionGrid.Rows.Clear();
            transactionGrid.Columns.Clear();
            transactionGrid.Columns.Add("TransactionId", "Transaction Id");
            transactionGrid.Columns.Add("AccountNumber", "Account Number");
            transactionGrid.Columns.Add("TransactionType", "Transaction Type");
            transactionGrid.Columns.Add("Amount", "Amount");
            transactionGrid.Columns.Add("Description", "Description");
            
        }

        private void btnFundTransfer_Click(object sender, EventArgs e)
        {
            manageListBox(true);
            FundsTransferForm fundTransfer = new FundsTransferForm(this, accountManager, account , transactionManager);
            fundTransfer.Show();
            Hide();
            AccountDashboard_Load(sender, e);
        }

        private void deposit_button_Click(object sender, EventArgs e)
        {
            manageListBox(true);
            DepositForm depositForm = new DepositForm(this, accountManager, account, transactionManager);
            depositForm.Show();
            Hide();
            AccountDashboard_Load(sender, e);
        }

        private void withdraw_button_Click(object sender, EventArgs e)
        {
            manageListBox(true);
            WithdrawForm withdrawForm = new WithdrawForm(this, accountManager, account ,transactionManager);
            withdrawForm.Show();
            Hide();
            AccountDashboard_Load(sender, e);
        }

        private void transactions_button_Click(object sender, EventArgs e)
        {
            // print all transactions
            List<Transactions> transactions = accountManager.GetTransactions(account.AccountNumber);

            label5.Text = "Transactions" ;
            manageListBox(false);
            transactionGrid.Rows.Clear();
            foreach (Transactions transaction in transactions)
            {
                transactionGrid.Rows.Add(transaction.TransactionID, transaction.AccountNumber, transaction.TransactionType, transaction.Amount, transaction.Description);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            accountLogin.Show();
        }

        private void manageListBox(bool isLocked)
        {
            if (isLocked)
            {
                transactionGrid.Hide();
            }
            else
            {
                transactionGrid.Show();
            }
        }
    }
}
