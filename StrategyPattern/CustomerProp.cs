using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public double BillAmount { get; set; }

        public IGetBill currentStrategy;

        public Customer(IGetBill newStrategy)
        {
            currentStrategy = newStrategy;
        }

        public double GetFinalBill()
        {
            return currentStrategy.GetFinalBill(this.BillAmount);
        }

    }
}
