using Firebase.Auth;
namespace DECouriers
{
    public partial class App : Application
    {
        private readonly FirebaseAuthClient _firebaseAuthClient;

        public App(FirebaseAuthClient firebaseAuthClient)
        {
            _firebaseAuthClient = firebaseAuthClient;
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell(_firebaseAuthClient));
        }
    }
}