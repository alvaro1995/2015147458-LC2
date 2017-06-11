using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class TipoEvaluacion
    {
        private int _NumeroTipoEvaluacion;

        public int TipoEvaluacionId { get; set; }
        public string NombreTipoEvaluacion { get; set; }
        public int NumeroTipoEvaluacion
        {
            get {
                return _NumeroTipoEvaluacion;
            }
            set {
                if (value > 0)
                    _NumeroTipoEvaluacion = value;
            }
        }

        public TipoEvaluacion (int numeroTipoEvaluacion)
        {
            NumeroTipoEvaluacion = numeroTipoEvaluacion;
        }
    }
}
