using DECouriers.ViewModels;

namespace DECouriers.Pages;

public partial class SignInView : ContentPage
{
	public SignInView(SignInVM viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}