
namespace CurrencyConverter
{
    partial class Form1
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
            this.acctBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acctCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.withdrawErr = new System.Windows.Forms.Label();
            this.currCombo = new System.Windows.Forms.ComboBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.acctBalance);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.acctCombo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(30, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 354);
            this.panel1.TabIndex = 0;
            // 
            // acctBalance
            // 
            this.acctBalance.AutoSize = true;
            this.acctBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.acctBalance.Location = new System.Drawing.Point(403, 67);
            this.acctBalance.Name = "acctBalance";
            this.acctBalance.Size = new System.Drawing.Size(51, 20);
            this.acctBalance.TabIndex = 5;
            this.acctBalance.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(320, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Balance:";
            // 
            // acctCombo
            // 
            this.acctCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acctCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.acctCombo.FormattingEnabled = true;
            this.acctCombo.Location = new System.Drawing.Point(407, 16);
            this.acctCombo.Name = "acctCombo";
            this.acctCombo.Size = new System.Drawing.Size(121, 28);
            this.acctCombo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(320, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, John Smith!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.withdrawErr);
            this.panel2.Controls.Add(this.currCombo);
            this.panel2.Controls.Add(this.withdrawButton);
            this.panel2.Controls.Add(this.depositButton);
            this.panel2.Controls.Add(this.amountInput);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(27, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 206);
            this.panel2.TabIndex = 0;
            // 
            // withdrawErr
            // 
            this.withdrawErr.AutoSize = true;
            this.withdrawErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawErr.ForeColor = System.Drawing.Color.Red;
            this.withdrawErr.Location = new System.Drawing.Point(75, 21);
            this.withdrawErr.Name = "withdrawErr";
            this.withdrawErr.Size = new System.Drawing.Size(226, 20);
            this.withdrawErr.TabIndex = 5;
            this.withdrawErr.Text = "Withdrawal amount is too large";
            this.withdrawErr.Visible = false;
            // 
            // currCombo
            // 
            this.currCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currCombo.FormattingEnabled = true;
            this.currCombo.Location = new System.Drawing.Point(337, 52);
            this.currCombo.Name = "currCombo";
            this.currCombo.Size = new System.Drawing.Size(75, 28);
            this.currCombo.TabIndex = 4;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.withdrawButton.Location = new System.Drawing.Point(267, 120);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(145, 42);
            this.withdrawButton.TabIndex = 3;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.depositButton.Location = new System.Drawing.Point(103, 119);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(145, 43);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // amountInput
            // 
            this.amountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.amountInput.Location = new System.Drawing.Point(148, 52);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(183, 26);
            this.amountInput.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(75, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 401);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label acctBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label withdrawErr;
        private System.Windows.Forms.ComboBox acctCombo;
        private System.Windows.Forms.ComboBox currCombo;
    }
}

