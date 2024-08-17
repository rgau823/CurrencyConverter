using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        private Controller currController;
        public Form1()
        {
            InitializeComponent();
            currController = new Controller();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            int accountId = Convert.ToInt32(acctCombo.Text);
            double deposit = Convert.ToDouble(amountInput.Text);
            string targetCurr = currCombo.Text;
            currController.deposit(targetCurr, deposit, accountId);
            acctBalance.Text = currController.getBalance().ToString("C");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            int accountId = Convert.ToInt32(acctCombo.Text);
            double withdraw = Convert.ToDouble(amountInput.Text);
            string targetCurr = currCombo.Text;
            currController.withdraw(targetCurr, withdraw, accountId);
            acctBalance.Text = currController.getBalance().ToString("C");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> ids = currController.getAccts();
            foreach(int id in ids) {
                acctCombo.Items.Add(id);
            }

            List<string> currency = currController.getCurrency();
            foreach(string curr in currency)
            {
                currCombo.Items.Add(curr);
            }

            acctBalance.Text = currController.getBalance().ToString("C");

            acctCombo.SelectedIndex = 0;
        }
    }
}
