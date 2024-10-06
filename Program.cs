using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StoreApp.Data;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddDbContext<StoreDbContext>(options =>options.UseSqlServer("workstation id=hattoriq1.mssql.somee.com;packet size=4096;\r\n                                        user id=hattori_SQLLogin_1;\r\n                                        pwd=9s2l522m2p;\r\n                                        data source=hattoriq1.mssql.somee.com;persist security info=False;\r\n                                        initial catalog=hattoriq1;\r\n                                        TrustServerCertificate=True"));
        var provider = services.BuildServiceProvider();
        var context = provider.GetRequiredService<StoreDbContext>();
        context.Database.Migrate();
        Console.WriteLine("Database setup complete.");
    }
}