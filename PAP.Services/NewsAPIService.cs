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
                Sources = new List<string> { "bbc-news", "cnn", "the-new-york-times", "the-wall-street-journal" },
                SortBy = SortBys.PublishedAt,
                Language = Languages.EN,
                
            });

            return response.Status == Statuses.Ok ? response.Articles.Take(20).ToList() : new List<Article>();

            
        }

    }


}