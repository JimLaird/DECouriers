using DECouriers.ViewModels;

namespace DECouriers.Pages;

public partial class SignUpView : ContentPage
{
	public SignUpView(SignUpVM viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}