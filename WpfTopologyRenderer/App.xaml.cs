using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Plc1;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace WpfTopologyRenderer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Plc1TwinController Plc1
        { get; } = new Plc1TwinController(Tc3ConnectorAdapter.Create("172.20.10.110.1.1", 851, true));

        public App()
        {
            TcOpen.Inxton.TcoAppDomain.Current.Builder
               .SetUpLogger(new TcOpen.Inxton.Logging.SerilogAdapter())
               .SetDispatcher(TcoCore.Wpf.Threading.Dispatcher.Get);

            Plc1.Connector.BuildAndStart();
        }
    }
}
