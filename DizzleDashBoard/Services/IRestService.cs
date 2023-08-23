using DizzleDashBoard.Models;

namespace DizzleDashBoard.Services
{
    public interface IRestService
    {
        Task<List<Hospital>> RefreshDataAsync(string url);
    }
}