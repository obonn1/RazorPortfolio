using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPortfolio.Classes;
using RazorPortfolio.Models;
using RazorPortfolio.Pages.Projects;

namespace RazorPortfolio.Pages
{
    public class ProjectsModel : PageModel
    {
        public void OnGet()
        {
        }


        [BindProperty]
        public string? CityWeather { get; set; }
        public WeatherViewModel? Weather { get; set; }

        public async Task<IActionResult> OnPostSubmitWeather()
        {
            if (CityWeather is null)
            {
                return Page();
            };

            Weather = new WeatherViewModel(WeatherRequest.GetWeather(CityWeather).Result);

            return Page();
        }
    }
}
