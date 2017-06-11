using _2015147458_ENT;
using _2015147458_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_PER.Repositories
{
    public class EstadoEvaluacionRepository : Repository<EstadoEvaluacion>, IEstadoEvaluacionRepository
    {
        public EstadoEvaluacionRepository(LineasNuevasDBcontext context) : base(context) { }
    }
}
