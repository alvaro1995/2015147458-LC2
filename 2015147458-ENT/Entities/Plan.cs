using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class Plan
    {
        private List<TipoPlan> _TipoPlan;
        public int PlanId { get; set; }
        public string NombrePlan { get; set; }
        public string Descripcion { get; set; }

        public Plan(int numTipoPlan)
        {
            _TipoPlan = new List<TipoPlan>(numTipoPlan);
        }
    }
}
