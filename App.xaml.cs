using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Data;
using System.Windows;
using Temp.Services;
using Temp.ViewModels;
using Temp.Views;

namespace Temp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            host.Start();
            App app = new App();
            app.InitializeComponent();
            app.MainWindow = host.Services.GetRequiredService<MainView>();
            app.MainWindow.Visibility = Visibility.Visible;
            app.Run();
            
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureServices(services =>
            {

                services.AddHostedService<DemoBackgroundService>();
                services.AddSingleton<MainView>();
                services.AddSingleton<MainViewModel>();
            });
        }
    }

}
