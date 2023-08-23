using DizzleDashBoard.Models;
using System.Diagnostics;
using System.Text.Json;
using System.Text;

namespace DizzleDashBoard.Services
{
    public class RestService : IRestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        public List<Hospital> Items { get; private set; }

        public RestService(IHttpsClientHandlerService service)
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<List<Hospital>> RefreshDataAsync(string url)
        {
            Items = new List<Hospital>();

            Uri uri = new Uri(string.Format(url, string.Empty));
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Items = JsonSerializer.Deserialize<List<Hospital>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }

    }
}