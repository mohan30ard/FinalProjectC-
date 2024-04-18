using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phase_1
{
    public partial class AccountRequest : Form
    {
        AdminDashboard adminDashboard;
        AccountManager accountManager;
        Account selectedAccount;
        private string mode;

        public AccountRequest(AdminDashboard adminDashboard,AccountManager accountManager, Account selectedAccount, string mode)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
            this.accountManager = accountManager;
            this.selectedAccount = selectedAccount;
            this.mode = mode;
            LoadInputs();
        }

        private void LoadInputs()
        {
            textBox1.Text = selectedAccount.Name;
            textBox2.Text = selectedAccount.Address;
            textBox3.Text = selectedAccount.Email;
            textBox4.Text = selectedAccount.PhoneNumber;
            textBox5.Text = selectedAccount.AccountNumber.ToString();
            textBox7.Text = selectedAccount.SSN.ToString();
            textBox6.Text = selectedAccount.Username;
            textBox8.Text = selectedAccount.Balance.ToString();

            if(mode == "UPDATE")
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox7.Enabled = true;
                button1.Text = "Update Account";


                button2.Visible = false;
            }else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox7.Enabled = false;
                button1.Text = "Approve Account";

                button2.Visible = true;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(mode == "UPDATE")
            {
                //selectedAccount.Name = textBox1.Text;

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Address cannot be empty.");
                    return;
                }

                if (!IsValidEmail(textBox3.Text))
                {
                    MessageBox.Show("Invalid email format. Please enter a valid email address.");
                    return;
                }

                if (!long.TryParse(textBox7.Text, out long ssn))
                {
                    MessageBox.Show("Invalid SSN. Please enter a valid number.");
                    return;
                }



                selectedAccount.Address = textBox2.Text;
                selectedAccount.Email = textBox3.Text;
                selectedAccount.PhoneNumber = textBox4.Text;
                selectedAccount.SSN = long.Parse(textBox7.Text);

                accountManager.UpdateAccount(selectedAccount);
                MessageBox.Show("Account Update Request Approved Successfully");
                Close();
                adminDashboard.Show();
            }
            else if(mode == "APPROVE")
            {
                accountManager.ApproveAccountCreationRequest(selectedAccount);
                MessageBox.Show("Account Creation Request Approved Successfully");
                Close();
                adminDashboard.Show();
            }else if(mode == "DELETE")
            {
                accountManager.ApproveAccountDeletionRequest(selectedAccount);
                MessageBox.Show("Account Deletion Request Approved Successfully");
                Close();
                adminDashboard.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(mode == "APPROVE")
            {
                accountManager.RejectAccountCreationRequest(selectedAccount);
                MessageBox.Show("Account Creation Request Rejected Successfully");
                Close();
                adminDashboard.Show();
            }else if(mode == "DELETE")
            {
                accountManager.RejectAccountDeletionRequest(selectedAccount);
                MessageBox.Show("Account Deletion Request Rejected Successfully");
                Close();
                adminDashboard.Show();
            }
        }

        private void AccountRequest_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            adminDashboard.Show();
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }

    }
}
