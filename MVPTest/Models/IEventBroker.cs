using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public interface IEventBroker
    {
        void Register(IEventReceiver receiver);

        Task SendEvent<TReceiver>(IEvent toSend);

        Task SendEvent<TReceiver, T>(IEvent<T> toSend) where T : class;
    }
}
