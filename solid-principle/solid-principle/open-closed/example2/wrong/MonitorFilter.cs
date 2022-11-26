using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.open_closed.example2.wrong
{
    public class MonitorFilter
    {
        public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, MonitorType type) =>
                monitors.Where(m => m.Type == type).ToList();

       /// <summary>
       /// This is violating OCP => the class has been modified with this new Filter ! we need to make the code extendable with interfaces
       /// </summary>
       /// <param name="monitors"></param>
       /// <param name="screen"></param>
       /// <returns></returns>
        public List<ComputerMonitor> FilterByScreen(IEnumerable<ComputerMonitor> monitors, Screen screen) =>
      monitors.Where(m => m.Screen == screen).ToList();
    }
}