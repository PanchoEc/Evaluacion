using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    public class VariablePriceProduct : Product
    {
        private String _measurement;
        private float _quantity;

        public string Measurement { get => _measurement; set => _measurement = value; }
        public float Quantity { get => _quantity; set => _quantity = value; }


        /*public Camioneta(string marca, string modelo, int anio, int capacidadCarga)
            : base(marca, modelo, anio)
        {
            CapacidadCarga = ValidateCarga(capacidadCarga);
        }*/
    }
}
