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
    public partial class ViewAccounts : Form
    {
        AdminDashboard adminDashboard;
        AccountManager accountManager;
        public ViewAccounts(AdminDashboard adminDashboard, AccountManager accountManager)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
            this.accountManager = accountManager;
            AccountGrid.Columns.Add("AccountNumber", "Account Number");
            AccountGrid.Columns.Add("Name", "Name");
            AccountGrid.Columns.Add("Address", "Address");
            AccountGrid.Columns.Add("Email", "Email");
            AccountGrid.Columns.Add("PhoneNumber", "Phone Number");
            AccountGrid.Columns.Add("SSN", "SSN");
            AccountGrid.Columns.Add("Username", "Username");
            AccountGrid.Columns.Add("Balance", "Balance");
            //add checkbox for isLocked
            DataGridViewCheckBoxColumn isLockedColumn = new DataGridViewCheckBoxColumn();
            isLockedColumn.HeaderText = "Is Locked";
            isLockedColumn.Name = "IsLocked";
            AccountGrid.Columns.Add(isLockedColumn);
            UpdateAccountsGrid();
        }

        private void UpdateAccountsGrid()
        {
            AccountGrid.Rows.Clear();
            foreach (Account account in accountManager.Accounts)
            {
                AccountGrid.Rows.Add(account.AccountNumber, account.Name, account.Address, account.Email, account.PhoneNumber, account.SSN, account.Username, account.Balance, account.IsLocked);
            }
            
        }

        private void ViewAccounts_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            adminDashboard.Show();
        }
    }
}
