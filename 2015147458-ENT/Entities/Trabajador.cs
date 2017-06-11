using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class Trabajador
    {
        private List<TipoTrabajador> _TipoTrabajador;
        public int TrabajadorId { get; private set; }
        public string NombreTrabajador { get; set; }
        public int NumeroTrabajador { get; private set; }

        public Evaluacion Evaluacion { get; set; }

        public Trabajador(Evaluacion evaluacion) {
            Evaluacion = evaluacion;
        }

        public Trabajador(int numTrabajador, Evaluacion evaluacion, int trabajadorId )
        {
            _TipoTrabajador = new List<TipoTrabajador>(numTrabajador);
            Evaluacion = evaluacion;
            TrabajadorId = trabajadorId;
            
        }

        public Trabajador (int trabajadorId)
        {
            TrabajadorId = trabajadorId;
        }

        public void CalcularTicket()
        {
            NumeroTrabajador = Evaluacion.NumeroTurno;
        }
       
        public Trabajador() { }



    }
}
