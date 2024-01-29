using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay(decimal price, float tax)
        {
            return Value = price + (price * tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Value ... {ValueToPay(),20:C2}\n\t" +
        }
    }
}
