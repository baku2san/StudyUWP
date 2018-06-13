using Windows.UI.Notifications;

namespace StudyUWP.Services
{
    internal partial class ToastNotificationsService : IToastNotificationsService
    {
        public void ShowToastNotification(ToastNotification toastNotification)
        {
            ToastNotificationManager.CreateToastNotifier().Show(toastNotification);
        }
    }
}
