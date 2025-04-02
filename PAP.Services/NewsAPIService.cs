using System;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;

namespace PAP.Services
{
    public interface INewsAPIService
    {
        List<Article> GetNews();
    }

    public class NewsAPIService : INewsAPIService
    {
        private readonly NewsApiClient _newsApiClient;

        public NewsAPIService()
        {
            _newsApiClient = new NewsApiClient("288160bb60cb40f79f75dd80b9715466");
        }

        public List<Article> GetNews()
        {
            var today = DateTime.UtcNow.Date; 

            var response = _newsApiClient.GetEverything(new EverythingRequest
            {
                Q = "Apple",
                SortBy = SortBys.Popularity,
                Language = Languages.EN,
                To = today
            });

            return response.Status == Statuses.Ok ? response.Articles : new List<Article>();
        }

    }


}