using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;

namespace DECouriers.ViewModels
{
    public partial class SignUpVM : BaseVM
    {
        private readonly FirebaseAuthClient _firebaseAuthClient;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        public SignUpVM(FirebaseAuthClient authClient)
        {
            Title = "Sign Up";
            _firebaseAuthClient = authClient;
        }

        [RelayCommand]
        private async Task SignUp()
        {
            await _firebaseAuthClient.CreateUserWithEmailAndPasswordAsync(Email, Password, Username);
            await Shell.Current.GoToAsync($"//SignIn");

        }

        [RelayCommand]
        private async Task NavigateSignIn()
        {
            await Shell.Current.GoToAsync($"//SignIn");
        }
    }
}
