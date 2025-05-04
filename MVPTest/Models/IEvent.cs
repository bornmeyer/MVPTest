using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public interface IEvent
    {
    }

    public interface IEvent<TEventData>
    {
        TEventData Data { get; }
    }
}
