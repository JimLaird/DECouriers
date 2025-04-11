namespace DECouriers.Pages;

public partial class ResetPasswordView : ContentPage
{
	public ResetPasswordView(ResetPasswordVM viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}