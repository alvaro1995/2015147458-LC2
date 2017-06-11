using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class LineaTelefonica
    {
        private List<TipoLinea> _TipoLinea;
        private int _NumeroLineaTelefonica;
        public int LineaTelefonicaId { get; set; }
        public string NombreLinea { get; set; }
        public string TipoDeLinea { get; set; }

        public int NumeroLineaTelefonica
        {
            get
            {
                return _NumeroLineaTelefonica;
            }

            set
            {
                if (value > 0)
                    _NumeroLineaTelefonica = value;
            }
        }

        public LineaTelefonica (int numeroLineaTelefonica, int numTipoLinea)
        {
            NumeroLineaTelefonica = numeroLineaTelefonica;
            _TipoLinea = new List<TipoLinea>(numTipoLinea);
        }
    }
}
