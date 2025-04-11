using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using DECouriers.Controls;

namespace DECouriers.Services
{
    /// <summary>
    /// Provides various dialog services for displaying toasts, activity indicators, alerts, and confirmation dialogs.
    /// </summary>
    public static class DialogService
    {
        /// <summary>
        /// Shows a short toast message.
        /// </summary>
        /// <param name="text">The text to display in the toast.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public static Task ShowToast(string text)
        {
            var toast = Toast.Make(text, ToastDuration.Short);
            return toast.Show();
        }

        /// <summary>
        /// Shows a busy activity indicator.
        /// </summary>
        /// <returns>An action to close the activity indicator.</returns>
        public static Action ShowActivityIndicator()
        {
            var popup = new BusyPopup();
            Application.Current.MainPage.ShowPopup(popup);
            return () => popup.Close();
        }

        /// <summary>
        /// Shows an alert dialog with a single accept button.
        /// </summary>
        /// <param name="title">The title of the alert.</param>
        /// <param name="message">The message of the alert.</param>
        /// <param name="accept">The text of the accept button.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public static Task ShowAlertAsync(string title, string message, string accept)
        {
            return Application.Current.MainPage.DisplayAlert(title, message, accept);
        }

        /// <summary>
        /// Shows a confirmation dialog with accept and cancel buttons.
        /// </summary>
        /// <param name="title">The title of the confirmation dialog.</param>
        /// <param name="message">The message of the confirmation dialog.</param>
        /// <param name="accept">The text of the accept button.</param>
        /// <param name="cancel">The text of the cancel button.</param>
        /// <returns>A task representing the asynchronous operation, with a boolean result indicating whether the accept button was pressed.</returns>
        public static Task<bool> ShowConfirmationAsync(string title, string message, string accept, string cancel)
        {
            return Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }
    }
}
