using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.open_closed.example2.wrong
{
    class Main
    {
        public Main()
        {
            var monitors = new List<ComputerMonitor>
                {
                    new ComputerMonitor { Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.OLED },
                    new ComputerMonitor { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.LCD },
                    new ComputerMonitor { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.LED },
                    new ComputerMonitor { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.OLED },
                    new ComputerMonitor { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.LCD }
                };

            var filter = new MonitorFilter();
            var lcdMonitors = filter.FilterByType(monitors, MonitorType.LCD);
            Console.WriteLine("All LCD monitors");
            foreach (var monitor in lcdMonitors)
            {
                Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }

            // Now we want to add a new filter on the ScreenType => we want to add a new  filter  FilterByScreen
            // this violate OCP because we need to modify the code !

        }
    }
}
