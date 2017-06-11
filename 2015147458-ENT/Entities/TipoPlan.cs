using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class TipoPlan
    {
        private int _NumeroTipoPlan;

        public int TipoPlanId { get; set; }
        public string DescripcionTipoPlan { get; set; }
        public int NumeroTipoPlan
        {
            get {
                return _NumeroTipoPlan;
            }
            set {
                if (value > 0)
                    _NumeroTipoPlan = value;
            }
        }

        public TipoPlan(int numeroTipoPlan)
        {
            NumeroTipoPlan = numeroTipoPlan;
        }
    }
}
