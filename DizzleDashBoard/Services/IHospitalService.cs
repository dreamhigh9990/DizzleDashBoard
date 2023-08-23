using DizzleDashBoard.Models;

namespace DizzleDashBoard.Services
{
    public interface IHospitalService
    {
        Task<List<Hospital>> GetTasksAsync(string url);
    }
}