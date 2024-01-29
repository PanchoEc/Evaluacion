using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    public class ComposedProduct : Product
    {
        private float _discount;

        public float Discount { get => _discount; set => _discount = value; }
        public required Product Products { get; set; }
    }
}
