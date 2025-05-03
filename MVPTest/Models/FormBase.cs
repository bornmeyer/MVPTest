using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public class FormBase : Form
    {
        private bool isVisible;

        public virtual bool IsVisible
        {
            get => isVisible;
            set
            {
                isVisible = value;
                if (value) this.Show();
                else this.Hide();
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(IsVisible ? value : IsVisible);
        }
    }
}
