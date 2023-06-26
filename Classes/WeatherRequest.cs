using Newtonsoft.Json;
using RazorPortfolio.Models;
using RestSharp;

namespace RazorPortfolio.Classes
{
    public static class WeatherRequest
    {
        public static async Task<WeatherData> GetWeather(string city)
        {
            var APIkey = "f035faea065c30dea65aaf8d6b70c76f";
            var OpenWeatherUrl = $"http://api.weatherstack.com/current?access_key={APIkey}&query={city}";
            var client = new RestClient(OpenWeatherUrl);
            var test = await client.GetJsonAsync<WeatherData>("");
            return test;
        }
    }
}
