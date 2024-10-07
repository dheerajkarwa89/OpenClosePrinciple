using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class Discount
    {
        public double Calculate(double amount)
        {
            return amount * 0.9;
        }
    }
}
