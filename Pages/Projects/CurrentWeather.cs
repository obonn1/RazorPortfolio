using RazorPortfolio.Classes;
using RazorPortfolio.Models;

namespace RazorPortfolio.Pages.Projects
{
    public record CurrentWeather
    {
        public static WeatherViewModel? Data { get; set; }
    }
}
