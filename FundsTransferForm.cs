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
    public partial class FundsTransferForm : Form
    {
        AccountDashboard accountDashboard;
            AccountManager accountManager;
        Account account;

        public FundsTransferForm(AccountDashboard accountDashboard, AccountManager accountManager , Account account, TransactionManager transactionManager)
        {
            InitializeComponent();
            this.accountDashboard = accountDashboard;
            this.accountManager = accountManager;
            this.account = account;
        }

        private void FundsTransferForm_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Transfer funds
            if(int.TryParse(textBox1.Text, out int accountNumber) && decimal.TryParse(textBox2.Text, out decimal amount))
            {
                if(accountNumber != account.AccountNumber)
                {
                    if(amount > 0 && amount < account.Balance)
                    {
                        if(accountManager.TransferFunds(account, accountNumber, amount))
                        {
                            MessageBox.Show("Funds transferred successfully.");
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to transfer funds. Please check the account number and try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a positive amount to transfer.");
                    }
                }
                else
                {
                    MessageBox.Show("You cannot transfer funds to the same account.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid account number and amount to transfer.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            accountDashboard.Show();
        }
    }
}
