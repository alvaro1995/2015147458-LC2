using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class TipoLinea
    {
        private int _NumeroTipoLinea;

        public int TipoLineaId { get; set; }
        public string NombreTipoLinea { get; set; }
        public int NumeroTipoLinea
        {
            get {
                return _NumeroTipoLinea;
            }
            set {
                if (value > 0)
                    _NumeroTipoLinea = value;
            }
        }

        public TipoLinea (int numeroTipoLinea)
        {
            NumeroTipoLinea = numeroTipoLinea;
        }
    }
}
