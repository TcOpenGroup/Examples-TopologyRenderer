using Plc1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTopologyRenderer
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {

        }
        public Plc1TwinController Plc1 { get; } = App.Plc1;

    }
}
