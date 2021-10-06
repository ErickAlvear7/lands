using System;
using System.Collections.Generic;
using System.Text;
using lands.ViewModel;

namespace lands.Infraestructura
{
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
