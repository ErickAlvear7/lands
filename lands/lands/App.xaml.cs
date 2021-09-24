

namespace lands
{
    using lands.Views;
    using Xamarin.Forms;

    public partial class App : Application
    {
        #region Constructor 
        public App()
        {
            InitializeComponent();

            this.MainPage = new LoginPage();
        }
        #endregion

        #region metodos
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        #endregion
    }
}
