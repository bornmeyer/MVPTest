using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public class IdGeneratedEvent(Guid data) : IEvent<Guid>
    {
        public Guid Data => data;
    }
}
