namespace phase_1
{
    partial class DepositForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.deposit_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentBalance_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNumber_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.cancel_button.Location = new System.Drawing.Point(480, 421);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(180, 56);
            this.cancel_button.TabIndex = 30;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submit_button.Location = new System.Drawing.Point(218, 421);
            this.submit_button.Margin = new System.Windows.Forms.Padding(2);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(184, 56);
            this.submit_button.TabIndex = 29;
            this.submit_button.Text = "Deposit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // deposit_input
            // 
            this.deposit_input.BackColor = System.Drawing.Color.White;
            this.deposit_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deposit_input.Location = new System.Drawing.Point(480, 298);
            this.deposit_input.Margin = new System.Windows.Forms.Padding(2);
            this.deposit_input.Name = "deposit_input";
            this.deposit_input.Size = new System.Drawing.Size(198, 24);
            this.deposit_input.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(89, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 37);
            this.label4.TabIndex = 27;
            this.label4.Text = "Enter Amount to Deposit:";
            // 
            // currentBalance_input
            // 
            this.currentBalance_input.BackColor = System.Drawing.Color.White;
            this.currentBalance_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentBalance_input.Enabled = false;
            this.currentBalance_input.Location = new System.Drawing.Point(480, 191);
            this.currentBalance_input.Margin = new System.Windows.Forms.Padding(2);
            this.currentBalance_input.Name = "currentBalance_input";
            this.currentBalance_input.ReadOnly = true;
            this.currentBalance_input.Size = new System.Drawing.Size(198, 24);
            this.currentBalance_input.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(200, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 37);
            this.label2.TabIndex = 25;
            this.label2.Text = "Current Balance:";
            // 
            // accountNumber_input
            // 
            this.accountNumber_input.BackColor = System.Drawing.Color.White;
            this.accountNumber_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountNumber_input.Enabled = false;
            this.accountNumber_input.Location = new System.Drawing.Point(480, 107);
            this.accountNumber_input.Margin = new System.Windows.Forms.Padding(2);
            this.accountNumber_input.Name = "accountNumber_input";
            this.accountNumber_input.ReadOnly = true;
            this.accountNumber_input.Size = new System.Drawing.Size(198, 24);
            this.accountNumber_input.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(190, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "Account Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 22;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(949, 576);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.deposit_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentBalance_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountNumber_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DepositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositForm";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.TextBox deposit_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentBalance_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountNumber_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}