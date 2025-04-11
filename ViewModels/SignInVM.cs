using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;

namespace DECouriers.ViewModels
{
    public partial class SignInVM : BaseVM
    {
        private readonly FirebaseAuthClient _firebaseAuthClient;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string password;

        public string Username => _firebaseAuthClient.User?.Info?.DisplayName ?? "";

        public SignInVM(FirebaseAuthClient authClient)
        {
            Title = "Sign In";
            _firebaseAuthClient = authClient;
        }

        [RelayCommand]
        private async Task SignIn()
        {
            try
            {
                await _firebaseAuthClient.SignInWithEmailAndPasswordAsync(Email, Password);

                OnPropertyChanged(nameof(Username));

                await Shell.Current.GoToAsync($"//Dashboard");
            }
            catch (FirebaseAuthException ex)
            {
                // Handle authentication errors here
                if (ex.Reason == AuthErrorReason.InvalidEmailAddress)
                {
                    await Shell.Current.DisplayAlert("Error", "Invalid email address.", "OK");
                }
                else if (ex.Reason == AuthErrorReason.WrongPassword)
                {
                    await Shell.Current.DisplayAlert("Error", "Incorrect password.", "OK");
                }
                else
                {
                    await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
                }
            }
            finally
            {
                //
            }
            
        }

        [RelayCommand]
        private async Task NavigateSignUp()
        {
            await Shell.Current.GoToAsync($"//SignUp");
        }

        [RelayCommand]
        private async Task NavigateResetPassword()
        {
            await Shell.Current.GoToAsync($"//ResetPassword");
        }
    }
}
