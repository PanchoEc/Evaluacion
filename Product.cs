using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Evaluacion
{
    public abstract class Product
    {
        private String _description;
        private int _id;
        private decimal _price;
        private float _tax;
        private float _value;

        public Product(string description, int id, decimal price, float tax)
        {
            Description = description;
            Id = id;
            Price = price;
            Tax = tax;
        }

        public string Description { get => _description; set => _description = value; }
        public int Id { get => _id; set => _id = value; }
        public decimal Price { get => _price; set => _price = value; }
        public float Tax { get => _tax; set => _tax = value; }
        public float Value { get => _value; set => _value = value; }

        public abstract decimal ValueToPay(decimal price, float tax);
        public override string ToString()
        {
            return $"Description.....{_description,50}\n\t" +
                   $"Id: ...........{_id,4}\n\t" +
                   $"Price.....{_price,20}\n\t" +
                   $"Tax....{_tax,20:C2}\n\t";
        }
    }
}
