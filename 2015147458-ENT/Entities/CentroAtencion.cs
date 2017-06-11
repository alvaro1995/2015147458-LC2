using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class CentroAtencion
    {
        private List<Direccion> _Direccion;



        public int CentroAtencionId { get; private set; }
        public string NombreCentro { get; set; }
        public string Nombre { get; set; }

        public int NumeroCentroAtencion{ get; private set; }
        public Venta Venta { get; set; }

        public CentroAtencion()
        {

        }


        public Evaluacion _Evaluacion { get; set; }
        
        public CentroAtencion(Venta venta)
        {
            Venta = venta;
        }
        public CentroAtencion(Evaluacion evaluacion, int numDireccion, int centroAtencionId)
        {
            _Evaluacion = evaluacion;
            _Direccion = new List<Direccion>(numDireccion);
            CentroAtencionId = centroAtencionId;
            
        }


        public void CalcularCentroAtencion()
        {
            NumeroCentroAtencion = Venta.NumVenta1;
        }
    }
}
