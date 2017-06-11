using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class Evaluacion
    {
        private CentroAtencion _CentroAtencion;
        private List<Plan> _Plan;
        private List<LineaTelefonica> _LineaTelefonica;
        private List<Cliente> _Cliente;
        private List<EstadoEvaluacion> _EstadoEvaluacion;
        private List<EquipoCelular> _EquipoCelular;
        private List<TipoEvaluacion> _TipoEvaluacion;
        private int _NumeroEvaluacion;
        public int NumeroTurno { get; private set; }
        

        public int EvaluacionId { get; set; }
        public string NombreEvaluacion { get; set; }


        public int NumeroEvaluacion
        {
            get {
                return _NumeroEvaluacion;
            }
            set {
                if (value > 0)
                    _NumeroEvaluacion = value;
            }
        }

        public Evaluacion(CentroAtencion centroAtencion, int numEstadoEvaluacion, int numEquipoCelular, int numTipoEvaluacion, int numeroEvaluacion, int numeroTurno)
        {
            _CentroAtencion = centroAtencion;
            _EstadoEvaluacion = new List<EstadoEvaluacion>(numEstadoEvaluacion);
            _EquipoCelular = new List<EquipoCelular>(numEquipoCelular);
            _TipoEvaluacion = new List<TipoEvaluacion>(numTipoEvaluacion);
            NumeroEvaluacion = numeroEvaluacion;
            NumeroTurno = numeroTurno;
            
        }

        public List<Plan> Plan
        {
            get {
                return _Plan;
            }
            set {
                if (value.Count == 4)
                    _Plan = value;
            }
        }

        public Evaluacion(List<Plan> plan)
        {
            _Plan = plan;
        }

        public List<LineaTelefonica> LineaTelefonica
        {
            get {
                return _LineaTelefonica;
            }
            set {
                if (value.Count == 4)
                    _LineaTelefonica = value;
            }

        }

        public Evaluacion(List<LineaTelefonica> lineaTelefonoca)
        {
            _LineaTelefonica = lineaTelefonoca;
        }

        public List<Cliente> Cliente
        {
            get {
                return _Cliente;
            }
            set {
                if (value.Count == 4)
                    _Cliente = value;
            }
        }

        public Evaluacion (List<Cliente> cliente)
        {
            _Cliente = cliente;
        }


    }
}
