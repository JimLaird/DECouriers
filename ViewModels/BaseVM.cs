namespace DECouriers.ViewModels
{
    public partial class BaseVM : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;

        public bool IsNotBusy => !IsBusy;

        // Changed from field to partial property for AOT compatibility
        [ObservableProperty]
        private string title;
    }
}
