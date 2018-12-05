using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FridayCustomer : IGetBill
    {
        public double GetFinalBill(double BillAmount)
        {
            return BillAmount - (BillAmount * 0.5);
        }
    }
    class MondayCustomer : IGetBill
    {
        public double GetFinalBill(double BillAmount)
        {
            return BillAmount - (BillAmount * 0.1);
        }
    }
    class NormalCustomer : IGetBill
    {
        public double GetFinalBill(double BillAmount)
        {
            return BillAmount;
        }
    }
}
