using System.Threading.Tasks;

namespace StudyUWP.Services
{
    public interface IFirstRunDisplayService
    {
        Task ShowIfAppropriateAsync();
    }
}
