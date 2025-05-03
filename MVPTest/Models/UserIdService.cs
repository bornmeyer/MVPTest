using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public class UserIdService : IUserIdService
    {
        public async Task<Guid> CreateIdAsync()
        {
            await Task.Delay(20);
            return Guid.NewGuid();
        }
    }
}
