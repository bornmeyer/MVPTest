using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MVPTest.Models;

namespace MVPTest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            //var x = host.Services.GetRequiredService <MainForm>();
            Application.Run(host.Services.GetRequiredService<MainForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    //services.AddScoped<TInterface, TImplementation>();
                    services.AddTransient<IMainPresenter, MainPresenter>();
                    services.AddTransient<IDetailsPresenter, DetailsPresenter>();

                    services.AddTransient<IUserIdService, UserIdService>();
                    services.AddSingleton<IEventBroker, EventBroker>();
                    services.AddSingleton<IDetailsView, DetailsForm>();

                    services.AddSingleton<MainForm>();
                });
        }
    }
}