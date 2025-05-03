using MVPTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPTest
{
    public partial class DetailsForm : FormBase, IDetailsView
    {

        private readonly IDetailsPresenter presenter;

        public DetailsForm(IDetailsPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
            presenter.View = this;
        }

        public string Id { get => IdTextBox.Text; set => IdTextBox.Text = value; }
        //public bool IsVisible
        //{
        //    get { return this.Visible; }
        //    set
        //    {
        //        if (value)
        //            this.Show();
        //        else
        //            this.Hide();
        //    }
        //}

    }
}
