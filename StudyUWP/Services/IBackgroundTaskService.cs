using System.Threading.Tasks;

using Windows.ApplicationModel.Background;

namespace StudyUWP.Services
{
    internal interface IBackgroundTaskService
    {
        Task RegisterBackgroundTasksAsync();

        void Start(IBackgroundTaskInstance taskInstance);
    }
}
