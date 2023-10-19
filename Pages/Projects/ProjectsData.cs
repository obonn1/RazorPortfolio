using RazorPortfolio.Models;

namespace RazorPortfolio.Pages.Projects;

public static class ProjectsData
{
    public static IReadOnlyList<Project> Projects { get; } = new List<Project>
    {
        new()
        {
            Id = 1,
            ImgUrl = @"images\projects\Onitama.JPG",
            ImgAlt = "A picture of a digital board game with figures dressed in blue and red on opposing sides.",
            Title = "Onitama",
            Body = "A full conversion of one of my favorite 1v1 board games into a Windows app. Feel free to try it out or browse the code in my github.",
            LinkUrl = "https://github.com/obonn1/Onitama",
            Keywords = "C#"
        },
        new()
        {
            Id = 2,
            ImgUrl = @"images\projects\Exercism-logo.svg",
            ImgAlt = "The logo for the exercism website, a smiley face made of brackets and parentheses followed by the word exercism.",
            Title = "Exercism",
            Body = "This is where I learned most of my back-end development basics, starting with C# and onto Javascript. Visit my profile to see my coding in a wide variety of exercises.",
            LinkUrl = "https://exercism.org/profiles/obonn/solutions?order=newest_first",
            Keywords = "C#, Javascript"
        },
        new()
        {
            Id = 3,
            ImgUrl = @"images\projects\Portfolio.JPG",
            ImgAlt = "A screenshot of the home page for this portfolio. Links to the views at the top and a partial capture of Omar's selfie.",
            Title = "Professional Portfolio",
            Body = "This is where you are now! Click here to look under the hood at the code for this portfolio, through my Github.",
            LinkUrl = "https://github.com/obonn1/RazorPortfolio",
            Keywords = "C#, HTML, Razor, Bootstrap"
        },
        new()
        {
            Id = 4,
            ImgUrl = @"images/projects/Blackjack.JPG",
            ImgAlt = "A screenshot of a text console-based blackjack game.",
            Title = "Blackjack",
            Body = "A Java project I completed in my full stack bootcamp for wcci. Good display of my understanding of clean coding.",
            LinkUrl = "https://github.com/obonn1/Blackjack",
            Keywords = "Java, junit, Console"
        }
    };
}