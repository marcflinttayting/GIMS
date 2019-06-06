using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using GIMS.DataLayer.Interfaces;
using GIMS.DataLayer.Repositories;
using GIMS.Domain;
using IContainer = Autofac.IContainer;
using log4net;

namespace GIMS
{
    static class Program
    {
        private static IContainer Container { get; set; }
    

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();

            RegisterComponents();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<Lobby>());
        }

        private static void RegisterComponents()
        {
            var builder = new ContainerBuilder();

            // Register individual components
            builder.RegisterInstance(new SupplierRepository()).As<ISupplierRepository>();
            builder.RegisterInstance(LogManager.GetLogger("GIMS_Logger")).As<ILog>();
            builder.Register(c => new SupplierManager(c.Resolve<ISupplierRepository>()));
            builder.Register(c => new Lobby(c.Resolve<SupplierManager>(), c.Resolve<ILog>()));
            Container = builder.Build();
        }
    }
}
