using RazorPortfolio.Models;

namespace RazorPortfolio.Pages.Projects;

public record ProjectsData
{
    public static List<Project> Projects { get; set; } = new List<Project>()
    {
        new Project()
        {
            Id = 1,
            ImgUrl = ".\\images\\projects\\Onitama.JPG",
            ImgAlt = "A picture of a digital board game with figures dressed in blue and red on opposing sides.",
            Title = "Onitama",
            Body = "A full conversion of one of my favorite 1v1 board games into a Windows app. Feel free to try it out or browse the code in my github.",
            LinkUrl = "https://github.com/obonn1/Onitama",
            Platform = "C#"
        },
        new Project()
        {
            Id = 2,
            ImgUrl = ".\\images\\projects\\Exercism-logo.svg",
            ImgAlt = "The logo for the exercism website, a smiley face made of brackets and parentheses followed by the word exercism.",
            Title = "Exercism",
            Body = "This is where I learned most of my back-end development basics, starting with C# and onto Javascript. Visit my profile to see my coding in a wide variety of exercises.",
            LinkUrl = "https://exercism.org/profiles/obonn/solutions?order=newest_first",
            Platform = "C#, Javascript"
        },
    };
}