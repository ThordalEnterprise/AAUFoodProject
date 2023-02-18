using System;
using System.Threading.Tasks;
using AAUFoodProject.Services;
using AAUFoodProject.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AAUFoodProject.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _Username;
        public string Username
        {
            set
            {
                this._Username = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Username;
            }
        }
        private string Staff_Username;
        public string StaffUsername
        {
            set
            {
                this.Staff_Username = "Staff123";
                OnPropertyChanged();
            }
            get
            {
                return this.Staff_Username;
            }
        }
        private string _Password;
        public string Password
        {
            set
            {
                this._Password = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Password;
            }
        }
        private string Staff_Password;
        public string StaffPassword
        {
            set
            {
                this.Staff_Password = "Staff123";
                OnPropertyChanged();
            }
            get
            {
                return this.Staff_Password;
            }
        }



        private string Admin_Password;
        public string AdminPassword
        {
            set
            {
                this.Admin_Password = "Admin123";
                OnPropertyChanged();
            }
            get
            {
                return this.Admin_Password;
            }
        }

        private string Admin_Username;
        public string AdminUsername
        {
            set
            {
                this.Admin_Username = "Admin123";
                OnPropertyChanged();
            }
            get
            {
                return this.Admin_Username;
            }
        }





        private bool _IsBusy;
        public bool IsBusy
        {
            set
            {
                this._IsBusy = value;
                OnPropertyChanged();
            }
            get
            {
                return this._IsBusy;
            }
        }
        private bool _Result;
        public bool Result
        {
            set
            {
                this._Result = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Result;
            }
        }
        private bool _Disable;
        public bool Disable
        {
            set
            {
                _Disable = value;
                OnPropertyChanged();
            }

            get
            {
                return _Disable;
            }
        }

        public Command AdminCommand { get; set; }
        public Command StaffCommand { get; set; }
        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }


        public LoginViewModel()
        {
            Disable = false;
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());
            AdminCommand = new Command(async () => await AdminCommandAsync());
            StaffCommand = new Command(async () => await StaffCommandAsync());

        }
        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.RegisterUser(Username, Password);
                if (Result)
                    await Application.Current.MainPage.DisplayAlert("Success", "User Registered", "OK");
                else
                    await Application.Current.MainPage.DisplayAlert("Error",
                        "User already exists with this credentials", "OK");

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
        private async Task LoginCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.LoginUser(Username, Password);

                if( Result)
                {
                    Preferences.Set("Username", Username);
                    await Application.Current.MainPage.Navigation.PushModalAsync(new ProductsView());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Invalid Username or Password", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
        private async Task AdminCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.LoginAdminUser(Username, Password);

                if (Result)
                {
                    Preferences.Set("Username", Username);
                    await Application.Current.MainPage.Navigation.PushModalAsync(new SettingsPage());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Invalid Username or Password", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
        private async Task StaffCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.LoginStaffUser(Username, Password);
            

              if (Result)
            {
                Preferences.Set("Username", Username);
                await Application.Current.MainPage.Navigation.PushModalAsync(new StaffManagePage());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid Username or Password", "OK");
            }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }







        }
    }
}
