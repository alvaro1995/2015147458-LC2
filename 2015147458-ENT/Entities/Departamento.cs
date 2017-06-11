using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class Departamento
    {
        private List<Provincia> _Provincia;

        public int DepartamentoId { get; set; }
        public string NombreDepartamento { get; set; }

        public Departamento(int numProvincia)
        {
            _Provincia = new List<Provincia>(numProvincia);
        }
    }
}
