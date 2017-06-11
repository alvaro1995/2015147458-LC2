using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class Contrato
    {
        private int _NumeroContrato;

        public int ContratoId { get; set; }
        public string NombreContrato { get; set; }

        public int NumeroContrato
        {
            get {
                return _NumeroContrato;
            }
            set {
                if (value > 0)
                    _NumeroContrato = value;
            }
        }

        public Contrato (int numeroContrato)
        {
            NumeroContrato = numeroContrato;
        }

    }
}
