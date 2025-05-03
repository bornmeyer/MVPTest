using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public class MainPresenter : PresenterBase<IMainView>, IMainPresenter, IEventReceiver
    {
        private readonly IEventBroker _eventBroker;

        public MainPresenter(IEventBroker eventBroker)
        {
            _eventBroker = eventBroker;
            _eventBroker.Register(this);
        }

        public Task ReceiveEvent(IEvent receivedEvent)
        {
            throw new NotImplementedException();
        }

        public Task ReceiveEvent<TEventData>(IEvent<TEventData> receivedEvent) where TEventData : class
        {
            throw new NotImplementedException();
        }

        public override void WireEvents(IMainView view)
        {
            view!.OnCreateIdClicked += OnCreateId;
        }

        private async void OnCreateId()
        {
            await _eventBroker.SendEvent<DetailsPresenter>(new UpdateIdEvent());
            await _eventBroker.SendEvent<DetailsPresenter>(new UnknownEvent());
        }
    }
}
