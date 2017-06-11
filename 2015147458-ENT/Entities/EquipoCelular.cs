using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class EquipoCelular
    {
        private int _NumeroEquipoCelular;

        public int EquipoCelularId { get; set; }
        public string NombreEquipoCelular { get; set; }

        public int NumeroEquipoCelular
        {
            get {
                return _NumeroEquipoCelular;
            }
            set {
                if (value > 0)
                    _NumeroEquipoCelular = value;
            }
        }

        public EquipoCelular (int numeroEquipoCelular)
        {
            NumeroEquipoCelular = numeroEquipoCelular;
        }

    }
}
