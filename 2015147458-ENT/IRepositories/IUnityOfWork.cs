using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAdministradorEquipoRepository AdministradorEquipo { get; }
        IAdministradorLineaRepository AdministradorLinea { get; }
        ICentroAtencionRepository CentroAtencion { get; }
        IClienteRepository Cliente { get; }
        IContratoRepository Contrato { get; }
        IDepartamentoRepository Departamento { get; }
        IDireccionRepository Direccion { get; }
        IEquipoCelularRepository EquipoCelular { get; }
        IEstadoEvaluacionRepository EstadoEvaluacion { get; }
        IEvaluacionRepository Evaluacion { get; }
        ITipoLineaRepository TipoLinea { get; }
        ILineaTelefonicaRepository LineaTelefonica { get; }
        IDistritoRepository Distrito { get; }
        IProvinciaRepository Provincia { get; }
        IUbigeoRepository Ubigeo { get; }
        IPlanRepository Plan { get; }
        ITipoPlanRepository TipoPlan { get; }
        IVentaRepository Venta { get; }
        ITipoTrabajadorRepository TipoTrabajador { get; }
        ITrabajadorRepository Trabajador { get; }
        ITipoEvaluacionRepository TipoEvaluacion { get; }
        ITipoPagoRepository TipoPago { get; }
        int SaveChanges();

        void StateModified(object entity);
    }
}
