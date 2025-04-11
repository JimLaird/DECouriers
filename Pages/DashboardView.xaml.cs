namespace DECouriers.Pages;

public partial class DashboardView : ContentPage
{
	public DashboardView(DashboardVM viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}