namespace MVPTest.Models
{
    public interface IPresenter<TView>
    {
        TView View { get; set; }

        void WireEvents(TView view);
    }
}