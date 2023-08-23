using DizzleDashBoard.Models;

namespace DizzleDashBoard.Services
{
    public class HospitalService : IHospitalService
    {
        IRestService _restService;

        public HospitalService(IRestService service)
        {
            _restService = service;
        }

        public Task<List<Hospital>> GetTasksAsync(string url)
        {
            return _restService.RefreshDataAsync(url);
        }

    }
}
