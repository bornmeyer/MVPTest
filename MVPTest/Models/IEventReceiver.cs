using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public interface IEventReceiver
    {
        Task ReceiveEvent(IEvent receivedEvent);

        Task ReceiveEvent<TEventData>(IEvent<TEventData> receivedEvent);

    }
}
