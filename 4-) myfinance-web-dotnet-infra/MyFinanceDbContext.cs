using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_domain.Entities;

namespace myfinance_web_dotnet_infra;

public class MyFinanceDbContext : DbContext
{
    public DbSet<PlanoConta> PlanoConta { get; set;}
    public DbSet<Transacao> Transacao { get; set;}



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //banco de dados local => optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=myfinance;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False;");
        optionsBuilder.UseSqlServer(@"Server=meuservidorsqlserver.database.windows.net;Database=myfinance;User Id=User;Password=t.1997.26;");

    }

}
