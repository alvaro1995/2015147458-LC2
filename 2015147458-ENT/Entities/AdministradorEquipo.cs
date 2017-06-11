using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class AdministradorEquipo
    {
        private List<EquipoCelular> _EquipoCelular;

        public int AdministradorEquipoId { get; set; }
        public string NombreAdministrador { get; set; }
        public AdministradorEquipo(int numEquipoCelular)
        {
            _EquipoCelular = new List<EquipoCelular>(numEquipoCelular);
        }
    }
}
