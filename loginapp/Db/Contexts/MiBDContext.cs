using loginapp.Db.Tables;
using Microsoft.EntityFrameworkCore;

namespace loginapp.Db.Contexts { 

    public class MiBDContext: DbContext
    {
        public MiBDContext(DbContextOptions<MiBDContext> options) : base(options)
        { }

        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<RolModel> Roles { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ProductoModel> Productos { get; set; }

        public DbSet<ImagenModel> Imagenes { get; set; }


    }


}