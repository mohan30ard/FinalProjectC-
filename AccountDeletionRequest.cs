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
    public partial class AccountDeletionRequest : Form
    {
        private string username;

        public AccountDeletionRequest()
        {
            InitializeComponent();
        }

        public AccountDeletionRequest(string username)
        {
            this.username = username;
        }

        private void AccountDeletionRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
