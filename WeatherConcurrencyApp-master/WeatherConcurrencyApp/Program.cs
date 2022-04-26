using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherConcurrencyApp.Infrastructure.Repository;
using WeatherConcurrentApp.Domain.Interfaces;

namespace WeatherConcurrencyApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new ContainerBuilder();
            builder.RegisterType<BinaryWeatherRepository>().As<IWeatherModel>();
            var container = builder.Build();
            Application.Run(new FrmMain(container.Resolve<IWeatherModel>()));
        }
    }
}
