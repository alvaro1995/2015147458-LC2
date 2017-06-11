using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT
{
    public class Ubigeo
    {
        private List<Departamento> _Departamento;
        private List<Provincia> _Provincia;
        private List<Distrito> _Distrito;
        private int _NumeroUbigeo;

        public int UbigeoId { get; set; }
        public string NombreUbigeo { get; set; }

        public int NumeroUbigeo
        {
            get {
                return _NumeroUbigeo;
            }
            set {
                if (value > 0)
                    _NumeroUbigeo = value;
            }
        }


        public Ubigeo(int numeroUbigeo)
        {
            NumeroUbigeo = numeroUbigeo;
        }


        public List<Departamento> Departamento
        {
            get {
                return _Departamento;
            }
            set {
                if (value.Count == 4)
                    _Departamento = value;
            }
        }

        public Ubigeo(List<Departamento> departamento)
        {
            Departamento = departamento;
        }


        public List<Provincia> Provincia
        {
            get {
                return _Provincia;
            }
            set {
                if (value.Count == 4)
                    _Provincia = value;
            }
        }

        public Ubigeo(List<Provincia> provincia)
        {
            Provincia = provincia;
        }

        public List<Distrito> Distrito
        {
            get {
                return _Distrito;
            }
            set {
                if (value.Count == 4)
                    _Distrito = value;
            }

        }

        public Ubigeo (List<Distrito> distrito)
        {
            Distrito = distrito;
        }
    }
}
