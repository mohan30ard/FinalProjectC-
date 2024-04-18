namespace phase_1
{
    partial class AccountDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.transactions_button = new System.Windows.Forms.Button();
            this.withdraw_button = new System.Windows.Forms.Button();
            this.deposit_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFundTransfer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccountSummary = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.transactionGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.transactions_button);
            this.panel1.Controls.Add(this.withdraw_button);
            this.panel1.Controls.Add(this.deposit_button);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnFundTransfer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAccountSummary);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 786);
            this.panel1.TabIndex = 0;
            // 
            // transactions_button
            // 
            this.transactions_button.FlatAppearance.BorderSize = 0;
            this.transactions_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactions_button.Font = new System.Drawing.Font("Yu Gothic UI Light", 7F, System.Drawing.FontStyle.Italic);
            this.transactions_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transactions_button.Location = new System.Drawing.Point(8, 595);
            this.transactions_button.Margin = new System.Windows.Forms.Padding(4);
            this.transactions_button.Name = "transactions_button";
            this.transactions_button.Size = new System.Drawing.Size(232, 44);
            this.transactions_button.TabIndex = 23;
            this.transactions_button.Text = "View Transactions";
            this.transactions_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactions_button.UseVisualStyleBackColor = true;
            this.transactions_button.Click += new System.EventHandler(this.transactions_button_Click);
            // 
            // withdraw_button
            // 
            this.withdraw_button.FlatAppearance.BorderSize = 0;
            this.withdraw_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdraw_button.Font = new System.Drawing.Font("Yu Gothic UI Light", 7F, System.Drawing.FontStyle.Italic);
            this.withdraw_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.withdraw_button.Location = new System.Drawing.Point(16, 434);
            this.withdraw_button.Margin = new System.Windows.Forms.Padding(4);
            this.withdraw_button.Name = "withdraw_button";
            this.withdraw_button.Size = new System.Drawing.Size(232, 44);
            this.withdraw_button.TabIndex = 20;
            this.withdraw_button.Text = "Withdraw";
            this.withdraw_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.withdraw_button.UseVisualStyleBackColor = true;
            this.withdraw_button.Click += new System.EventHandler(this.withdraw_button_Click);
            // 
            // deposit_button
            // 
            this.deposit_button.FlatAppearance.BorderSize = 0;
            this.deposit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposit_button.Font = new System.Drawing.Font("Yu Gothic UI Light", 7F, System.Drawing.FontStyle.Italic);
            this.deposit_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deposit_button.Location = new System.Drawing.Point(16, 372);
            this.deposit_button.Margin = new System.Windows.Forms.Padding(4);
            this.deposit_button.Name = "deposit_button";
            this.deposit_button.Size = new System.Drawing.Size(232, 44);
            this.deposit_button.TabIndex = 19;
            this.deposit_button.Text = "Deposit";
            this.deposit_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deposit_button.UseVisualStyleBackColor = true;
            this.deposit_button.Click += new System.EventHandler(this.deposit_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Light", 5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(28, 572);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Servuces";
            // 
            // btnFundTransfer
            // 
            this.btnFundTransfer.FlatAppearance.BorderSize = 0;
            this.btnFundTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFundTransfer.Font = new System.Drawing.Font("Yu Gothic UI Light", 7F, System.Drawing.FontStyle.Italic);
            this.btnFundTransfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFundTransfer.Location = new System.Drawing.Point(16, 492);
            this.btnFundTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFundTransfer.Name = "btnFundTransfer";
            this.btnFundTransfer.Size = new System.Drawing.Size(232, 44);
            this.btnFundTransfer.TabIndex = 13;
            this.btnFundTransfer.Text = "Fund Transfer";
            this.btnFundTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFundTransfer.UseVisualStyleBackColor = true;
            this.btnFundTransfer.Click += new System.EventHandler(this.btnFundTransfer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Light", 5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(28, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Transactions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(28, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Accounts";
            // 
            // btnAccountSummary
            // 
            this.btnAccountSummary.FlatAppearance.BorderSize = 0;
            this.btnAccountSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSummary.Font = new System.Drawing.Font("Yu Gothic UI Light", 7F, System.Drawing.FontStyle.Italic);
            this.btnAccountSummary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccountSummary.Location = new System.Drawing.Point(16, 213);
            this.btnAccountSummary.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccountSummary.Name = "btnAccountSummary";
            this.btnAccountSummary.Size = new System.Drawing.Size(232, 44);
            this.btnAccountSummary.TabIndex = 8;
            this.btnAccountSummary.Text = "Account Summary";
            this.btnAccountSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSummary.UseVisualStyleBackColor = true;
            this.btnAccountSummary.Click += new System.EventHandler(this.btnAccountSummary_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 181);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(62, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "UserName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::phase_1.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(84, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Light", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(90, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Light", 7F, System.Drawing.FontStyle.Italic);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(13, 675);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 44);
            this.button1.TabIndex = 26;
            this.button1.Text = "Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.transactionGrid);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(248, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1652, 786);
            this.panel3.TabIndex = 2;
            // 
            // transactionGrid
            // 
            this.transactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGrid.Location = new System.Drawing.Point(20, 194);
            this.transactionGrid.Name = "transactionGrid";
            this.transactionGrid.RowHeadersWidth = 82;
            this.transactionGrid.RowTemplate.Height = 33;
            this.transactionGrid.Size = new System.Drawing.Size(1556, 525);
            this.transactionGrid.TabIndex = 2;
            // 
            // AccountDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1900, 786);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountDashboard";
            this.Load += new System.EventHandler(this.AccountDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccountSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFundTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button withdraw_button;
        private System.Windows.Forms.Button deposit_button;
        private System.Windows.Forms.Button transactions_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView transactionGrid;
    }
}