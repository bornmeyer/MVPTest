using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public class DetailsPresenter : PresenterBase<IDetailsView>, IDetailsPresenter, IEventReceiver
    {
        private readonly IUserIdService userIdService;
        private readonly IEventBroker _eventBroker;

        public DetailsPresenter(IUserIdService userIdService, IEventBroker eventBroker)
        {
            this.userIdService = userIdService;
            _eventBroker = eventBroker;
            _eventBroker.Register(this);
        }

        public async Task ReceiveEvent(IEvent receivedEvent)
        {
            var task = receivedEvent switch
            {
                UpdateIdEvent => UpdateAsync(),
                _ => Task.CompletedTask
            };
            await task;
        }

        public async Task ReceiveEvent<TEventData>(IEvent<TEventData> receivedEvent) 
        {
            var task = receivedEvent switch
            {
                _ => Task.CompletedTask
            };
            await task;
        }

        private async Task UpdateAsync()
        {
            var newId = await userIdService.CreateIdAsync();
            View!.IsVisible = true;
            View!.Id = newId.ToString();
            await _eventBroker!.Broadcast(new IdGeneratedEvent(newId));
        }
    }
}
