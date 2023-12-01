using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Modelo;
using Modelo.Interfaces;
using Servicios;

namespace TP_LABORATORIO_GYM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();

            var connectionString = root.GetSection("ConnectionStrings").GetSection("MOMO").Value;

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    if (connectionString != null)
                    {
                        services.AddDbContext<Contexto>(options =>
                        {
                            options.UseSqlServer(connectionString);
                        });
                    }
                    services.AddScoped<IServicioCliente, ServicioCliente>();
                    services.AddScoped<IServicioCuotas, ServicioCuotas>();
                    services.AddScoped<IServicioEmpleado, ServicioEmpleado>();

                    //Agregar Todos los Formularios
                    services.AddScoped<ABMClientes>();
                    services.AddScoped<MenuPrincipal>();
                    services.AddScoped<Pagos>();
                    services.AddScoped<Login>();
                });
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var context = ServiceProvider.GetRequiredService<Contexto>();
            if (context != null)
            {
                context.Database.Migrate();
            }

            Application.Run(ServiceProvider.GetRequiredService<Login>());
        }
    }
}