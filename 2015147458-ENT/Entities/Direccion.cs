using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class Direccion
    {
        private List<Ubigeo> _Ubigeo;
        private int _NumeroDireccion;

        public int DireccionId { get; set; }
        public string NombreDireccion { get; set; }

        public Direccion(int numUbigeo, int numeroDireccion)
        {
            _Ubigeo = new List<Ubigeo>(numUbigeo);
            NumeroDireccion = numeroDireccion;
        }

        public int NumeroDireccion
        {
            get
            {
                return _NumeroDireccion;
            }
            set
            {
                if (value > 0)
                    _NumeroDireccion = value;
            }
        }
    }
}
