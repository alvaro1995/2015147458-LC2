using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class Provincia
    {
        private List<Distrito> _Distrito;
        private int _NumeroProvincia;

        public int ProvinciaId { get; set; }
        public string NombreProvincia { get; set; }

        public Provincia (int numDistritos, int numeroProvincia)
        {
            _Distrito = new List<Distrito>(numDistritos);
            NumeroProvincia = numeroProvincia;
        }

        public int NumeroProvincia
        {
            get {
                return _NumeroProvincia;
            }
            set {
                if (value > 0)
                    _NumeroProvincia = value;
            }
        }

        


    }
}
