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

        public async Task ReceiveEvent<TEventData>(IEvent<TEventData> receivedEvent)
        {
            var task = receivedEvent switch
            {
                IdGeneratedEvent {  Data: var data } => UpdateTitle(data),
                _ => Task.CompletedTask
            };
            await task;
        }

        private async Task UpdateTitle(Guid id) => View!.Title = $"{id}";

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
