

namespace lands.ViewModel
{
    using System.Windows.Input;

    public class LoginViewModel
    {
        #region Propiedades
        public string Email 
        { get;
          set; 
        }

        public string Password
        {
            get;
            set;
        }

        public bool IsRemenber
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        #endregion

        #region Comands
        public ICommand LoginCommand 
        { 
           get; 
           set; 
        }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsRemenber = true;
        }
        #endregion
    }
}
