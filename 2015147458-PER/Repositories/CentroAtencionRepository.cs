﻿using _2015147458_ENT;
using _2015147458_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_PER.Repositories
{
    public class CentroAtencionRepository : Repository<CentroAtencion>, ICentroAtencionRepository
    {
        public CentroAtencionRepository(LineasNuevasDBcontext context) : base(context) { }
    }
}
