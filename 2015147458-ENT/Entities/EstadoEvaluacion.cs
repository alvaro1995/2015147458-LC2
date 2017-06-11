using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class EstadoEvaluacion
    {
        private int _NumeroEstadoEvaluacion;

        public int EstadoEvaluacionId { get; set; }
        public string NombreEstado{ get; set; }
        public int NumeroEstadoEvakuacion
        {
            get {
                return _NumeroEstadoEvaluacion;
            }
            set {
                if (value > 0)
                    _NumeroEstadoEvaluacion = value;
            }
        }

        public EstadoEvaluacion (int numeroEstadoEvaluacion)
        {
            NumeroEstadoEvakuacion = numeroEstadoEvaluacion;
        }
    }
}
