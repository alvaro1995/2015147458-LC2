using _2015147458_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly LineasNuevasDBcontext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IAdministradorEquipoRepository AdministradorEquipo { get; private set; }
        
        public IAdministradorLineaRepository AdministradorLinea { get; private set; }

        public ICentroAtencionRepository CentroAtencion { get; private set; }
        public IClienteRepository Cliente { get; private set; }

        public IContratoRepository Contrato { get; private set; }

        public IDepartamentoRepository Departamento { get; private set; }

        public IDireccionRepository Direccion { get; private set; }
        public ITipoEvaluacionRepository TipoEvaluacion { get; private set; }
        public IDistritoRepository Distrito { get; private set; }
        public ITrabajadorRepository Trabajador { get; private set; }
        public IEquipoCelularRepository EquipoCelular { get; private set; }
        public IEstadoEvaluacionRepository EstadoEvaluacion { get; private set; }
        public IEvaluacionRepository Evaluacion { get; private set; }
        public ITipoTrabajadorRepository TipoTrabajador { get; private set; }
        public ITipoLineaRepository TipoLinea { get; private set; }
        public ITipoPagoRepository TipoPago { get; private set; }
        public ILineaTelefonicaRepository LineaTelefonica { get; private set; }

        public IVentaRepository Venta { get; private set; }

        public IProvinciaRepository Provincia { get; private set; }

        public IUbigeoRepository Ubigeo { get; private set; }

        public IPlanRepository Plan { get; private set; }

        public ITipoPlanRepository TipoPlan { get; private set; }

        public UnityOfWork() {
            _Context = new LineasNuevasDBcontext();

            AdministradorEquipo = new AdministradorEquipoRepository(_Context);
            AdministradorLinea = new AdministradorLineaRepository(_Context);
            CentroAtencion = new CentroAtencionRepository(_Context);
            Cliente=new ClienteRepository(_Context);
            Contrato = new ContratoRepository(_Context);
            Departamento = new DepartamentoRepository(_Context);
            Direccion = new DireccionRepository(_Context);
            EquipoCelular = new EquipoCelularRepository(_Context);
            EstadoEvaluacion = new EstadoEvaluacionRepository(_Context);
            Evaluacion = new EvaluacionRepository(_Context);
            TipoLinea = new TipoLineaRepository(_Context);
            LineaTelefonica = new LineaTelefonicaRepository(_Context);
            Distrito = new DistritoRepository(_Context);
            Provincia = new ProvinciaRepository(_Context);
            Ubigeo = new UbigeoRepository(_Context);
            Plan = new PlanRepository(_Context);
            TipoPlan = new TipoPlanRepository(_Context);
            TipoEvaluacion = new TipoEvaluacionRepository(_Context);
            Venta = new VentaRepository(_Context);
            TipoTrabajador = new TipoTrabajadorRepository(_Context);
            Trabajador = new TrabajadorRepository(_Context);
            TipoPago = new TipoPagoRepository(_Context);
        }

        public static UnityOfWork Instance
        {
            get {
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }
                return _Instance;
            }
        }

        


        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
