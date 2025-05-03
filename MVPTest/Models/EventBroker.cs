using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public class EventBroker : IEventBroker
    {
        private readonly ConcurrentDictionary<Type, IEventReceiver> _registered;

        public EventBroker()
        {
            _registered = new ConcurrentDictionary<Type, IEventReceiver>();
        }

        public void Register(IEventReceiver receiver)
        {
            _registered.AddOrUpdate(receiver.GetType(), receiver, (_, _) => receiver);
        }

        public async Task SendEvent<TReceiver>(IEvent toSend)
        {
            if(_registered.TryGetValue(typeof(TReceiver), out var receiver))
                await receiver.ReceiveEvent(toSend);
        }

        public async Task SendEvent<TReceiver, T>(IEvent<T> toSend) where T : class
        {
            if (_registered.TryGetValue(typeof(TReceiver), out var receiver))
                await receiver.ReceiveEvent(toSend);
        }
    }
}
