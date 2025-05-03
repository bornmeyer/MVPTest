using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public interface IDetailsView : IView
    {
        String Id { get; set; }

        Boolean IsVisible {  get; set; }
    }
}
