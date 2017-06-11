﻿using _2015147458_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_PER.EntitiesConfigurations
{
    public class TipoLineaConfiguration : EntityTypeConfiguration<TipoLinea>
    {
        public TipoLineaConfiguration()
        {
            //Table Configurations
            ToTable("TipoLinea");
            HasKey(a => a.TipoLineaId);
        }
    }
}
