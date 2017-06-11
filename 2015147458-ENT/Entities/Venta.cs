using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class Venta
    {
        //El centro de atencion atiende varias ventas y evalua a varios clientes
        //Un centro y n ventas
        private List<Cliente> _Cliente;
        private List<Evaluacion> _Evaluacion;
        private List<LineaTelefonica> _LineaTelefonica;
        private List<TipoPago> _TipoPago;
        private List<Contrato> _Contrato;
        public int NumeroVenta { get; private set; }
        public int NumVenta1 { get; private set; }

        public int VentaId { get; private set; }


        

        public Venta() { }


        

        public Venta(int numEvaluacion, int numLineaTelefonica, int numTipoPago, int numContrato, int numVenta)
        {
            _Evaluacion = new List<Evaluacion>(numEvaluacion);
            _LineaTelefonica = new List<LineaTelefonica>(numLineaTelefonica);
            _TipoPago = new List<TipoPago>(numTipoPago);
            _Contrato = new List<Contrato>(numContrato);
            NumVenta1 = numVenta;
           
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

        public Venta(List<Cliente> cliente)
        {
            Cliente = cliente;
        }
    }
}
