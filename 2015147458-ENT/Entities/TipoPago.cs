using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class TipoPago
    {
        private int _NumeroTipoPago;

        public int TipoPagoId { get; set; }
        public string DescripcionTipoPago { get; set; }
        public int NumeroTipoPago
        {
            get {
                return _NumeroTipoPago;
            }
            set {
                if (value > 0)
                    _NumeroTipoPago = value;
            }
        }

        public TipoPago (int numeroTipoPago)
        {
            NumeroTipoPago = numeroTipoPago;
        }

    }
}
