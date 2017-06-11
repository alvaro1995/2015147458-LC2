using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class Distrito
    {
        private int _NumeroDistrito;

        public int DistritoId { get; set; }
        public string NombreDistrito { get; set; }
        public int NumeroDistrito
        {
            get {
                return _NumeroDistrito;
            }
            set {
                if (value > 0)
                    _NumeroDistrito = value;
            }
        }

        public Distrito(int numeroDistrito)
        {
            NumeroDistrito = numeroDistrito;
        }
    }
}
