using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Microsoft.Extensions.Logging;

namespace DECouriers
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            //  Register Pages
            builder.Services.AddSingleton<SignInView>();
            builder.Services.AddSingleton<SignUpView>();
            builder.Services.AddTransient<ResetPasswordView>();
            builder.Services.AddTransient<DashboardView>();

            // Register ViewModels
            builder.Services.AddSingleton<SignInVM>();
            builder.Services.AddSingleton<SignUpVM>();
            builder.Services.AddTransient<ResetPasswordVM>();
            builder.Services.AddTransient<DashboardVM>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyDHg2UkjHmE56QNmIYvX93C-Z9Ws2FjVb0",
                AuthDomain = "decouriers-6eeae.firebaseapp.com",
                Providers = new Firebase.Auth.Providers.FirebaseAuthProvider[]
                { 
                    new EmailProvider()
                },
                UserRepository = new FileUserRepository("DECouriers")
              
            }));

            return builder.Build();
        }
    }
}
