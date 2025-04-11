using Firebase.Auth;

namespace DECouriers
{
    public partial class AppShell : Shell
    {
        private readonly FirebaseAuthClient _firebaseAuthClient;

        public AppShell(FirebaseAuthClient firebaseAuth)
        {
            InitializeComponent();
            _firebaseAuthClient = firebaseAuth;
        }

        private async void MenuItem_LogoutClicked(object sender, EventArgs e)
        {
            // Perform logout logic here
            _firebaseAuthClient.SignOut();
            await Shell.Current.GoToAsync("//SignIn");
        }
    }
}
