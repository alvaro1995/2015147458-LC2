using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class TipoTrabajador
    {
        private int _NumeroTipoTrabajador;

        public int TipoTrabajadorId { get; set; }
        public string NombreTipoTrabajador{ get; set; }
        public int NumeroTipoTrabajador
        {
            get {
                return _NumeroTipoTrabajador;
            }
            set {
                if (value > 0)
                    _NumeroTipoTrabajador = value;
            }
        }

        public TipoTrabajador(int numeroTipoTrabajador)
        {
            NumeroTipoTrabajador = numeroTipoTrabajador;
        }
    }
}
