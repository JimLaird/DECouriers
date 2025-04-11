using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;

namespace DECouriers.ViewModels
{
    public partial class  ResetPasswordVM : BaseVM
    {
        private readonly FirebaseAuthClient _firebaseAuthClient;

        [ObservableProperty]
        private string email;

        public ResetPasswordVM(FirebaseAuthClient authClient)
        {
            Title = "Reset Password";
            _firebaseAuthClient = authClient;
        }

        [RelayCommand]
        private async Task ResetPassword()
        {
            await _firebaseAuthClient.ResetEmailPasswordAsync(Email);
            await Shell.Current.GoToAsync($"//SignIn");
        }
    }
}
