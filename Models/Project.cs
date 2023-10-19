using System.ComponentModel.DataAnnotations;

namespace RazorPortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ImgUrl { get; set; }
        public string? ImgAlt { get; set; }
        public string? LinkUrl { get; set; }
        public string? Body { get; set; }
        public string? Keywords { get; set; }

    }
}
