

namespace lands.Infraestructura
{
    using lands.ViewModel;

    public class InstanceLocator
    {
        #region propiedades
        public MainViewModel Main 
        { 
            get;
            set; 
        }
        #endregion

        #region constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
