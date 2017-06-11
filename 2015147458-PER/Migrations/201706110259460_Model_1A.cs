namespace _2015147458_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Model_1A : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdministradorEquipoes",
                c => new
                    {
                        AdministradorEquipoId = c.Int(nullable: false, identity: true),
                        NombreAdministrador = c.String(),
                    })
                .PrimaryKey(t => t.AdministradorEquipoId);
            
            CreateTable(
                "dbo.AdministradorLineas",
                c => new
                    {
                        AdministradorLineaId = c.Int(nullable: false, identity: true),
                        NombreLinea = c.String(),
                    })
                .PrimaryKey(t => t.AdministradorLineaId);
            
            CreateTable(
                "dbo.CentroAtencions",
                c => new
                    {
                        CentroAtencionId = c.Int(nullable: false, identity: true),
                        NombreCentro = c.String(),
                        Nombre = c.String(),
                        NumeroCentroAtencion = c.Int(nullable: false),
                        _Evaluacion_EvaluacionId = c.Int(),
                        Venta_VentaId = c.Int(),
                    })
                .PrimaryKey(t => t.CentroAtencionId)
                .ForeignKey("dbo.Evaluacions", t => t._Evaluacion_EvaluacionId)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaId)
                .Index(t => t._Evaluacion_EvaluacionId)
                .Index(t => t.Venta_VentaId);
            
            CreateTable(
                "dbo.Evaluacions",
                c => new
                    {
                        EvaluacionId = c.Int(nullable: false, identity: true),
                        NumeroTurno = c.Int(nullable: false),
                        NombreEvaluacion = c.String(),
                        NumeroEvaluacion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EvaluacionId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        TipoCliente = c.String(),
                        Evaluacion_EvaluacionId = c.Int(),
                        Venta_VentaId = c.Int(),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Evaluacions", t => t.Evaluacion_EvaluacionId)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaId)
                .Index(t => t.Evaluacion_EvaluacionId)
                .Index(t => t.Venta_VentaId);
            
            CreateTable(
                "dbo.LineaTelefonicas",
                c => new
                    {
                        LineaTelefonicaId = c.Int(nullable: false, identity: true),
                        NombreLinea = c.String(),
                        TipoDeLinea = c.String(),
                        NumeroLineaTelefonica = c.Int(nullable: false),
                        Evaluacion_EvaluacionId = c.Int(),
                    })
                .PrimaryKey(t => t.LineaTelefonicaId)
                .ForeignKey("dbo.Evaluacions", t => t.Evaluacion_EvaluacionId)
                .Index(t => t.Evaluacion_EvaluacionId);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        PlanId = c.Int(nullable: false, identity: true),
                        NombrePlan = c.String(),
                        Descripcion = c.String(),
                        Evaluacion_EvaluacionId = c.Int(),
                    })
                .PrimaryKey(t => t.PlanId)
                .ForeignKey("dbo.Evaluacions", t => t.Evaluacion_EvaluacionId)
                .Index(t => t.Evaluacion_EvaluacionId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        NumeroVenta = c.Int(nullable: false),
                        NumVenta1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VentaId);
            
            CreateTable(
                "dbo.Contratoes",
                c => new
                    {
                        ContratoId = c.Int(nullable: false, identity: true),
                        NombreContrato = c.String(),
                        NumeroContrato = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContratoId);
            
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                        NombreDepartamento = c.String(),
                        Ubigeo_UbigeoId = c.Int(),
                    })
                .PrimaryKey(t => t.DepartamentoId)
                .ForeignKey("dbo.Ubigeos", t => t.Ubigeo_UbigeoId)
                .Index(t => t.Ubigeo_UbigeoId);
            
            CreateTable(
                "dbo.Direccions",
                c => new
                    {
                        DireccionId = c.Int(nullable: false, identity: true),
                        NombreDireccion = c.String(),
                        NumeroDireccion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DireccionId);
            
            CreateTable(
                "dbo.Distritoes",
                c => new
                    {
                        DistritoId = c.Int(nullable: false, identity: true),
                        NombreDistrito = c.String(),
                        NumeroDistrito = c.Int(nullable: false),
                        Ubigeo_UbigeoId = c.Int(),
                    })
                .PrimaryKey(t => t.DistritoId)
                .ForeignKey("dbo.Ubigeos", t => t.Ubigeo_UbigeoId)
                .Index(t => t.Ubigeo_UbigeoId);
            
            CreateTable(
                "dbo.EquipoCelulars",
                c => new
                    {
                        EquipoCelularId = c.Int(nullable: false, identity: true),
                        NombreEquipoCelular = c.String(),
                        NumeroEquipoCelular = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EquipoCelularId);
            
            CreateTable(
                "dbo.EstadoEvaluacions",
                c => new
                    {
                        EstadoEvaluacionId = c.Int(nullable: false, identity: true),
                        NombreEstado = c.String(),
                        NumeroEstadoEvakuacion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstadoEvaluacionId);
            
            CreateTable(
                "dbo.Provincias",
                c => new
                    {
                        ProvinciaId = c.Int(nullable: false, identity: true),
                        NombreProvincia = c.String(),
                        NumeroProvincia = c.Int(nullable: false),
                        Ubigeo_UbigeoId = c.Int(),
                    })
                .PrimaryKey(t => t.ProvinciaId)
                .ForeignKey("dbo.Ubigeos", t => t.Ubigeo_UbigeoId)
                .Index(t => t.Ubigeo_UbigeoId);
            
            CreateTable(
                "dbo.TipoEvaluacions",
                c => new
                    {
                        TipoEvaluacionId = c.Int(nullable: false, identity: true),
                        NombreTipoEvaluacion = c.String(),
                        NumeroTipoEvaluacion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoEvaluacionId);
            
            CreateTable(
                "dbo.TipoLineas",
                c => new
                    {
                        TipoLineaId = c.Int(nullable: false, identity: true),
                        NombreTipoLinea = c.String(),
                        NumeroTipoLinea = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoLineaId);
            
            CreateTable(
                "dbo.TipoPagoes",
                c => new
                    {
                        TipoPagoId = c.Int(nullable: false, identity: true),
                        DescripcionTipoPago = c.String(),
                        NumeroTipoPago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoPagoId);
            
            CreateTable(
                "dbo.TipoPlans",
                c => new
                    {
                        TipoPlanId = c.Int(nullable: false, identity: true),
                        DescripcionTipoPlan = c.String(),
                        NumeroTipoPlan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoPlanId);
            
            CreateTable(
                "dbo.TipoTrabajadors",
                c => new
                    {
                        TipoTrabajadorId = c.Int(nullable: false, identity: true),
                        NombreTipoTrabajador = c.String(),
                        NumeroTipoTrabajador = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoTrabajadorId);
            
            CreateTable(
                "dbo.Trabajadors",
                c => new
                    {
                        TrabajadorId = c.Int(nullable: false, identity: true),
                        NombreTrabajador = c.String(),
                        NumeroTrabajador = c.Int(nullable: false),
                        Evaluacion_EvaluacionId = c.Int(),
                    })
                .PrimaryKey(t => t.TrabajadorId)
                .ForeignKey("dbo.Evaluacions", t => t.Evaluacion_EvaluacionId)
                .Index(t => t.Evaluacion_EvaluacionId);
            
            CreateTable(
                "dbo.Ubigeos",
                c => new
                    {
                        UbigeoId = c.Int(nullable: false, identity: true),
                        NombreUbigeo = c.String(),
                        NumeroUbigeo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UbigeoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Provincias", "Ubigeo_UbigeoId", "dbo.Ubigeos");
            DropForeignKey("dbo.Distritoes", "Ubigeo_UbigeoId", "dbo.Ubigeos");
            DropForeignKey("dbo.Departamentoes", "Ubigeo_UbigeoId", "dbo.Ubigeos");
            DropForeignKey("dbo.Trabajadors", "Evaluacion_EvaluacionId", "dbo.Evaluacions");
            DropForeignKey("dbo.CentroAtencions", "Venta_VentaId", "dbo.Ventas");
            DropForeignKey("dbo.Clientes", "Venta_VentaId", "dbo.Ventas");
            DropForeignKey("dbo.CentroAtencions", "_Evaluacion_EvaluacionId", "dbo.Evaluacions");
            DropForeignKey("dbo.Plans", "Evaluacion_EvaluacionId", "dbo.Evaluacions");
            DropForeignKey("dbo.LineaTelefonicas", "Evaluacion_EvaluacionId", "dbo.Evaluacions");
            DropForeignKey("dbo.Clientes", "Evaluacion_EvaluacionId", "dbo.Evaluacions");
            DropIndex("dbo.Trabajadors", new[] { "Evaluacion_EvaluacionId" });
            DropIndex("dbo.Provincias", new[] { "Ubigeo_UbigeoId" });
            DropIndex("dbo.Distritoes", new[] { "Ubigeo_UbigeoId" });
            DropIndex("dbo.Departamentoes", new[] { "Ubigeo_UbigeoId" });
            DropIndex("dbo.Plans", new[] { "Evaluacion_EvaluacionId" });
            DropIndex("dbo.LineaTelefonicas", new[] { "Evaluacion_EvaluacionId" });
            DropIndex("dbo.Clientes", new[] { "Venta_VentaId" });
            DropIndex("dbo.Clientes", new[] { "Evaluacion_EvaluacionId" });
            DropIndex("dbo.CentroAtencions", new[] { "Venta_VentaId" });
            DropIndex("dbo.CentroAtencions", new[] { "_Evaluacion_EvaluacionId" });
            DropTable("dbo.Ubigeos");
            DropTable("dbo.Trabajadors");
            DropTable("dbo.TipoTrabajadors");
            DropTable("dbo.TipoPlans");
            DropTable("dbo.TipoPagoes");
            DropTable("dbo.TipoLineas");
            DropTable("dbo.TipoEvaluacions");
            DropTable("dbo.Provincias");
            DropTable("dbo.EstadoEvaluacions");
            DropTable("dbo.EquipoCelulars");
            DropTable("dbo.Distritoes");
            DropTable("dbo.Direccions");
            DropTable("dbo.Departamentoes");
            DropTable("dbo.Contratoes");
            DropTable("dbo.Ventas");
            DropTable("dbo.Plans");
            DropTable("dbo.LineaTelefonicas");
            DropTable("dbo.Clientes");
            DropTable("dbo.Evaluacions");
            DropTable("dbo.CentroAtencions");
            DropTable("dbo.AdministradorLineas");
            DropTable("dbo.AdministradorEquipoes");
        }
    }
}
