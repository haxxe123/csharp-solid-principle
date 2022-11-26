
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.open_closed.example2.right
{
    public class MonitorFilter : IFilter<ComputerMonitor>
    {
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification) =>
            monitors.Where(m => specification.isSatisfied(m)).ToList();
    }
}