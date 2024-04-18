using phase_1.ServiceLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace phase_1
{
    public partial class AccountCreationRequest : Form
    {
        Main main;
        AccountManager accountManager;
        private readonly IAccountService accountService;
        public AccountCreationRequest(Main main, AccountManager accountManager, TransactionManager transactionManager)
        {
            InitializeComponent();
            this.main = main;
            this.accountManager = accountManager;
        }

        private void AccountCreationForm_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string address = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();
            string phoneNumber = textBox4.Text.Trim();
            string ssnText = textBox5.Text.Trim();
            string password = textBox6.Text;
            string confirmPassword = textBox7.Text;
            string initialBalanceText = textBox8.Text.Trim();

            // Validate name
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            // Validate address
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter your address.");
                return;
            }

            // Validate email
            if (string.IsNullOrEmpty(email) )
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Validate phone number
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            // Validate SSN
            if (!long.TryParse(ssnText, out long ssn) || ssnText.Length != 9)
            {
                MessageBox.Show("Please enter a valid 9-digit SSN number.");
                return;
            }

            // Validate password and confirm password
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match or are empty.");
                return;
            }

            // Validate initial balance
            if (!decimal.TryParse(initialBalanceText, out decimal initialBalance) || initialBalance < 0 || initialBalance > 1000)
            {
                MessageBox.Show("Please enter a valid initial balance between (0 - 1000)");
                return;
            }

            
            // Create the account
            Account account = accountManager.CreateAccount(name, address, email, phoneNumber, ssn, password, initialBalance);

            MessageBox.Show("Account Creation Request Submitted Successfully" +
                "\n Please Contact to Approve your Account" +
                "\nAccount Details" + accountManager.Display(account));
            Close();
            main.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            main.Show();
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
