namespace MisOfertas.CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nueva : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Productoes", "Categoria_IdCategoria", "dbo.Categorias");
            DropForeignKey("dbo.Locals", "Empresa_IdEmpresa", "dbo.Empresas");
            DropForeignKey("dbo.EncargadoVentas", "Empresa_IdEmpresa", "dbo.Empresas");
            DropForeignKey("dbo.Productoes", "EncargadoVentas_IdEncargadoVentas", "dbo.EncargadoVentas");
            DropForeignKey("dbo.Productoes", "Local_IdLocal", "dbo.Locals");
            DropForeignKey("dbo.Opinions", "Producto_IdProducto", "dbo.Productoes");
            DropForeignKey("dbo.Opinions", "Usuario_IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Puntos", "Usuario_IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "IdTipoUsuario", "dbo.TipoUsuarios");
            DropIndex("dbo.Productoes", new[] { "Categoria_IdCategoria" });
            DropIndex("dbo.Productoes", new[] { "EncargadoVentas_IdEncargadoVentas" });
            DropIndex("dbo.Productoes", new[] { "Local_IdLocal" });
            DropIndex("dbo.EncargadoVentas", new[] { "Empresa_IdEmpresa" });
            DropIndex("dbo.Locals", new[] { "Empresa_IdEmpresa" });
            DropIndex("dbo.Opinions", new[] { "Producto_IdProducto" });
            DropIndex("dbo.Opinions", new[] { "Usuario_IdUsuario" });
            DropIndex("dbo.Usuarios", new[] { "IdTipoUsuario" });
            DropIndex("dbo.Puntos", new[] { "Usuario_IdUsuario" });
            RenameColumn(table: "dbo.Usuarios", name: "IdTipoUsuario", newName: "TipoUsuario_IdTipoUsuario");
            AddColumn("dbo.Usuarios", "Password", c => c.String());
            AddColumn("dbo.Usuarios", "Comuna", c => c.String());
            AddColumn("dbo.Usuarios", "Suscrito", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Puntos", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "TipoUsuario_IdTipoUsuario", c => c.Int());
            CreateIndex("dbo.Usuarios", "TipoUsuario_IdTipoUsuario");
            AddForeignKey("dbo.Usuarios", "TipoUsuario_IdTipoUsuario", "dbo.TipoUsuarios", "IdTipoUsuario");
            DropColumn("dbo.Usuarios", "Contrasena");
            DropColumn("dbo.Usuarios", "RespuestaSecreta");
            DropTable("dbo.Categorias");
            DropTable("dbo.Productoes");
            DropTable("dbo.EncargadoVentas");
            DropTable("dbo.Empresas");
            DropTable("dbo.Locals");
            DropTable("dbo.Opinions");
            DropTable("dbo.Puntos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Puntos",
                c => new
                    {
                        IdPuntos = c.Int(nullable: false, identity: true),
                        CantidadPuntos = c.Int(nullable: false),
                        Usuario_IdUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.IdPuntos);
            
            CreateTable(
                "dbo.Opinions",
                c => new
                    {
                        IdOpinion = c.Int(nullable: false, identity: true),
                        Valoracion = c.Double(nullable: false),
                        Imagen = c.String(),
                        FechaPublicacion = c.DateTime(nullable: false),
                        ProductoId = c.Int(),
                        UsuarioId = c.Int(),
                        Producto_IdProducto = c.Int(),
                        Usuario_IdUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.IdOpinion);
            
            CreateTable(
                "dbo.Locals",
                c => new
                    {
                        IdLocal = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Direccion = c.String(),
                        EmpresaId = c.Int(nullable: false),
                        Empresa_IdEmpresa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdLocal);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        IdEmpresa = c.Int(nullable: false, identity: true),
                        Rut = c.String(),
                        Logo = c.String(),
                        Correo = c.String(),
                        Direccion = c.String(),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEmpresa);
            
            CreateTable(
                "dbo.EncargadoVentas",
                c => new
                    {
                        IdEncargadoVentas = c.Int(nullable: false, identity: true),
                        Rut = c.String(),
                        Nombre = c.String(),
                        Apellidos = c.String(),
                        Correo = c.String(),
                        Contrasena = c.String(),
                        RespuestaSecreta = c.String(),
                        Telefono = c.Int(nullable: false),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Empresa_IdEmpresa = c.Int(),
                    })
                .PrimaryKey(t => t.IdEncargadoVentas);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        CompraMinima = c.Int(nullable: false),
                        CompraMaxima = c.Int(nullable: false),
                        FechaPublicacion = c.DateTime(nullable: false),
                        Valor = c.Int(nullable: false),
                        Descuento = c.Double(nullable: false),
                        Stock = c.Int(nullable: false),
                        EncargadoVentasId = c.Int(),
                        LocalId = c.Int(),
                        CategoriaId = c.Int(),
                        Categoria_IdCategoria = c.Int(),
                        EncargadoVentas_IdEncargadoVentas = c.Int(),
                        Local_IdLocal = c.Int(),
                    })
                .PrimaryKey(t => t.IdProducto);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.IdCategoria);
            
            AddColumn("dbo.Usuarios", "RespuestaSecreta", c => c.String());
            AddColumn("dbo.Usuarios", "Contrasena", c => c.String());
            DropForeignKey("dbo.Usuarios", "TipoUsuario_IdTipoUsuario", "dbo.TipoUsuarios");
            DropIndex("dbo.Usuarios", new[] { "TipoUsuario_IdTipoUsuario" });
            AlterColumn("dbo.Usuarios", "TipoUsuario_IdTipoUsuario", c => c.Int(nullable: false));
            DropColumn("dbo.Usuarios", "Puntos");
            DropColumn("dbo.Usuarios", "Suscrito");
            DropColumn("dbo.Usuarios", "Comuna");
            DropColumn("dbo.Usuarios", "Password");
            RenameColumn(table: "dbo.Usuarios", name: "TipoUsuario_IdTipoUsuario", newName: "IdTipoUsuario");
            CreateIndex("dbo.Puntos", "Usuario_IdUsuario");
            CreateIndex("dbo.Usuarios", "IdTipoUsuario");
            CreateIndex("dbo.Opinions", "Usuario_IdUsuario");
            CreateIndex("dbo.Opinions", "Producto_IdProducto");
            CreateIndex("dbo.Locals", "Empresa_IdEmpresa");
            CreateIndex("dbo.EncargadoVentas", "Empresa_IdEmpresa");
            CreateIndex("dbo.Productoes", "Local_IdLocal");
            CreateIndex("dbo.Productoes", "EncargadoVentas_IdEncargadoVentas");
            CreateIndex("dbo.Productoes", "Categoria_IdCategoria");
            AddForeignKey("dbo.Usuarios", "IdTipoUsuario", "dbo.TipoUsuarios", "IdTipoUsuario", cascadeDelete: true);
            AddForeignKey("dbo.Puntos", "Usuario_IdUsuario", "dbo.Usuarios", "IdUsuario");
            AddForeignKey("dbo.Opinions", "Usuario_IdUsuario", "dbo.Usuarios", "IdUsuario");
            AddForeignKey("dbo.Opinions", "Producto_IdProducto", "dbo.Productoes", "IdProducto");
            AddForeignKey("dbo.Productoes", "Local_IdLocal", "dbo.Locals", "IdLocal");
            AddForeignKey("dbo.Productoes", "EncargadoVentas_IdEncargadoVentas", "dbo.EncargadoVentas", "IdEncargadoVentas");
            AddForeignKey("dbo.EncargadoVentas", "Empresa_IdEmpresa", "dbo.Empresas", "IdEmpresa");
            AddForeignKey("dbo.Locals", "Empresa_IdEmpresa", "dbo.Empresas", "IdEmpresa", cascadeDelete: true);
            AddForeignKey("dbo.Productoes", "Categoria_IdCategoria", "dbo.Categorias", "IdCategoria");
        }
    }
}
