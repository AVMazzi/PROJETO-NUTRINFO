using Microsoft.EntityFrameworkCore;
using NutrInfo.Domain;


namespace NutrInfo.Persistence.Contextos
{
    public class NutrInfoContext : DbContext
    {
        public NutrInfoContext() { }
        public NutrInfoContext(DbContextOptions<NutrInfoContext> options) 
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AutorMap());
            //modelBuilder.ApplyConfiguration(new AssuntoMap());
            //modelBuilder.ApplyConfiguration(new LivroMap());

            //modelBuilder.Entity<Livro>().HasMany(s => s.Assuntos);
            //modelBuilder.Entity<Livro>().HasMany(s => s.Autores);
        }


        public DbSet<Departamento>? Departamentos { get; set; }
        public DbSet<Endereco>? Enderecos { get; set; }
        public DbSet<Estado>? Estados { get; set; }
        public DbSet<Funcionario>? Funcionarios { get; set; }
        public DbSet<Login>? Logins { get; set; }
        public DbSet<Permissao>? Permissoes { get; set; }
    }
}