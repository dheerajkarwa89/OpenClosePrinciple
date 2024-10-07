using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public interface IDiscount
    {
        double Calculate(double amount);
    }

    public class FlatDiscount : IDiscount
    {
        public double Calculate(double amount)
        {
            return amount * 0.9;
        } 
    }

    public class SeasonalDiscount : IDiscount
    {
        public double Calculate(double amount)
        {
            return amount * 0.8;
        }
    }   
}
