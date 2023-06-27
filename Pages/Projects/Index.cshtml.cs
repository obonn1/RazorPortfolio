using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPortfolio.Classes;
using RazorPortfolio.Pages.Projects;
using RazorPortfolio.Weather;

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

            Weather = new WeatherViewModel(await WeatherService.GetWeather(CityWeather));

            return Page();
        }
    }
}
