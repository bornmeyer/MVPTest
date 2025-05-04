using MVPTest.Models;

namespace MVPTest
{
    public partial class MainForm : Form, IMainView
    {
        private readonly IMainPresenter presenter;

        public string Title { get => Text; set => Text = value; }

        public event Action? OnCreateIdClicked;


        public MainForm(IMainPresenter presenter, IDetailsView detailsView)
        {
            InitializeComponent();
            this.presenter = presenter;
            presenter.View = this;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            OnCreateId();
        }

        private void OnCreateId()
        {
            OnCreateIdClicked?.Invoke();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OnCreateId();
        }
    }
}
