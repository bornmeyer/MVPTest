using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public abstract class PresenterBase<TView> : IPresenter<TView>
        where TView : class
    {
        private TView? _view = null;

        public virtual TView View
        {
            get => _view;
            set
            {
                _view = value;
                WireEvents(_view);
            }
        }

        public virtual void WireEvents(TView view)
        {
            
        }
    }
}
