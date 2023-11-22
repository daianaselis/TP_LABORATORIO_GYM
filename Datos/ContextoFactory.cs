using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(string[] args)
        {
            //este es el creador del contexto desde la linea de comandos. solo tiene que hacer 3 cosas
            //1. armar la configuracion
            //2. poner el connection string
            //3. crear el contexto
            var optionsBuilder = new DbContextOptionsBuilder<Contexto>();

            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();

            var connectionString = root.GetSection("ConnectionStrings").GetSection("MOMO").Value;
            Console.WriteLine("ConnectionString:" + connectionString);

            optionsBuilder.UseSqlServer(connectionString);

            return new Contexto(optionsBuilder.Options);
        }
    }
}
