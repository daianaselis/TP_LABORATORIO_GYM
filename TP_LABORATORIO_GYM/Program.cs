using Datos;
using MaterialSkin;
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
            //ESTE ES EL METODO QUE CONFIGURA LAS DEEPENDENCIAS PARA HACER LA INYECCION DE DEPENDENCIAS
            //CUANDO EXISTAN DEPENDENCIAS, SE RESOLVERAN SEGUN ESTE CONFIGURADO EN ESTE METODO


            //ESTE BLOQUE DE CODIGO SE ENCARGA DE ARMAR LA CONFIGURACION A PARTIR DEL APPSETTINGS.JSON
            //POR AHORA LO UNICO QUE AGARRAMOS DEL APPSETTINGS ES EL CONNECTION STRING
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();

            var connectionString = root.GetSection("ConnectionStrings").GetSection("MOMO").Value;

            //ESTE BLOQUE DE CODIGO CONFIGURA LAS DEPENDENCIAS
            //TE DICE COMO SE RESUELVEN LOS FORMULARIOS, LOS SERVICIOS, Y EL CONTEXTO DE LA BASE DE DATOS
            //RECORDEMOS: EL CONTEXTO ESTA PARA CONECTARSE A LA BASE DE DATOS
            //LOS SERVICIOS USAN EL CONTEXTO PARA TRAER LOS DATOS, SUBIR DATOS NUEVOS, Y LLEVAR A CABO TODA LA LOGICA DE NEGOCIO
            //EL MODELO TIENE LAS ENTIDADES DEL PROBLEMA (EMPLEADO, CLIENTE, ETC.)
            //Y POR ULTIMO LOS FORMULARIOS PRESENTAN TODA ESTA INFORMACION AL USUARIO Y LLAMAN A LOS SERVICIOS
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    //NOTA: SCOPED SIGNIFICA QUE LOS SERVICIOS SE CREAN CUANDO SE LOS NECESITA Y CUANDO NO SE LOS USE MAS SE DESTRUYEN
                    //https://www.netmentor.es/entrada/inyeccion-dependencias-scoped-transient-singleton

                    //Configuracion de contexto
                    if (connectionString != null)
                    {
                        services.AddDbContext<Contexto>(options =>
                        {
                            options.UseSqlServer(connectionString);
                        });
                    }

                    //Configuracion de servicios
                    services.AddScoped<IServicioCliente, ServicioCliente>();
                    services.AddScoped<IServicioCuotas, ServicioCuotas>();
                    services.AddScoped<IServicioEmpleado, ServicioEmpleado>();

                    //Agregar Todos los Formularios
                    services.AddScoped<ABMClientes>();
                    services.AddScoped<MenuPrincipal>();
                    services.AddScoped<Pagos>();
                    services.AddScoped<Login>();
                    services.AddScoped<IngresoGym>();
                });
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Este bloque de codigo crea el host, osea llama la funcion de arriba.
            //El host se encarga de manejar los servicios y resolver las dependencias segun este configurado.
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            //Este bloque de codigo corre las migraciones pendientes :)
            var context = ServiceProvider.GetRequiredService<Contexto>();
            if (context != null)
            {
                context.Database.Migrate();
            }

            //Manejar el tema de Material, colores, y demas
            StateManager.MaterialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            StateManager.MaterialSkinManager.ColorScheme = new ColorScheme(
                (Primary)0x88acf2, 
                (Primary)0x88acf2, 
                (Primary)0x88acf2, 
                (Accent)0xf298bc, 
                TextShade.WHITE
            );

            //Por fin, esto corre la aplicacion
            Application.Run(ServiceProvider.GetRequiredService<Login>());
        }
    }
}