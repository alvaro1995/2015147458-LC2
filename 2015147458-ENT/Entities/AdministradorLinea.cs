using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class AdministradorLinea
    {
        private List<LineaTelefonica> _LineaTelefonica;

        public int AdministradorLineaId { get; set; }
        public string NombreLinea { get; set; }
        public AdministradorLinea(int numLineaTelefonica)
        {
            _LineaTelefonica = new List<LineaTelefonica>(numLineaTelefonica);
        }
    }
}
