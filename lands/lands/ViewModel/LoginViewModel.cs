

namespace lands.ViewModel
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {
        

        #region Atributos
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        private bool isRemenber;
        #endregion

        #region Propiedades
        public string Email 
        {
            get { return email; }
            set { SetValue(ref email, value); }
            
        }

        public string Password
        {
            get { return password; }
            set { SetValue(ref password, value); }
        }

        public bool IsRemenber
        {
            get { return isRemenber; }
            set { SetValue(ref isRemenber, value); }
        }

        public bool IsRunning
        {
            get { return isRunning; }
            set { SetValue(ref isRunning, value); }
        }

        public bool IsEnabled
        {
            get { return isEnabled; }
            set { SetValue(ref isEnabled, value); }
        }

        #endregion

        #region Comands
        public ICommand LoginCommand 
        {
            get
            {
                return new RelayCommand(Login);
            }

        }

     

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "ingresa el email",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "ingresa el password",
                    "Aceptar");
                return;
            }
          
            if (this.Email != "erick@gmail.com" || this.Password != "erick")
            {
                this.IsRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "email oh password incorrectos",
                    "Aceptar");
                this.Email = string.Empty;
                this.Password = string.Empty;
                return;
            }
            this.IsRunning = false;
            this.IsEnabled = true;
            await Application.Current.MainPage.DisplayAlert(
                    "Ok",
                    "succesfull",
                    "Aceptar");
          
        }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsRemenber = true;
            this.IsEnabled = true;
        }
        #endregion
    }
}
