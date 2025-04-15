using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using PAP.Models.Models;

namespace PAP.Services.Services.Shared
{
    public static class ConfigurationFetcher
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task FetchConfiguration(dynamic viewBag)
        {
            Configuration config = new Configuration
            {
                Font = "Arial",
                Color = "#000000",
                FontSize = 14
            };

            config = await _httpClient.GetFromJsonAsync<Configuration>("https://localhost:7027/api/configurationapi/all");

            viewBag.Font = config.Font;
            viewBag.Color = config.Color;
            viewBag.FontSize = config.FontSize;
        }
    }
}
