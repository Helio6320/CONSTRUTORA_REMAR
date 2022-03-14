using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace UC_08_PI_ATV_06.Models
{
    public class UC_08_PI_ATV_06Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {                   
            optionsBuilder.UseMySql("Server=localhost;DataBase=CONSTRUTORA_REMAR;Uid=root;");
        }

        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Funcionario> Funcionarios {get; set;}
    }
}
