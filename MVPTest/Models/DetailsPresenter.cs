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

        public Task ReceiveEvent<TEventData>(IEvent<TEventData> receivedEvent) where TEventData : class
        {
            throw new NotImplementedException();
        }

        private async Task UpdateAsync()
        {   
            View!.IsVisible = true;
            View!.Id = (await userIdService.CreateIdAsync()).ToString();
        }
    }
}
