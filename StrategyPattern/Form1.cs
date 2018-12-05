using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer(null);
            cust.BillAmount = Convert.ToDouble(tbBillAmount.Text);
            cust.CustomerName = tbCustomerName.Text;
            var billDate = tbBillDate.Text;
         
            switch (billDate)
            {
                case "Friday":
                    cust.currentStrategy = new FridayCustomer();
                    break;
                case "Monday":
                    cust.currentStrategy = new MondayCustomer();
                    break;
                default:
                    cust.currentStrategy = new NormalCustomer();
                    break;
            }
            var amountDue = cust.currentStrategy.GetFinalBill(cust.BillAmount);
            tbAmountDue.Text = amountDue.ToString("0.00");
        }

        private void tbAmountDue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
