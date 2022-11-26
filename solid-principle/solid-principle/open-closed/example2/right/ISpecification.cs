using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.open_closed.example2.right
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}
