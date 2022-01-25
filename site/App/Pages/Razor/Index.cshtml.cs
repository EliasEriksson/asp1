using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Pages.Razor
{
    public class Course
    {
        public string Id { get; }
        public string Name { get; }

        public Course(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

    public class IndexModel : PageModel
    {
        public List<Course>? Courses { get; private set; }
        public DateTime Date { get; private set; }

        public void OnGet()
        {
            this.Date = DateTime.Now;
            this.Courses = new List<Course>
            {
                new ("DG008G", "Typografi och form för webb"),
                new ("DT003G", "Databaser"),
                new ("DT057G", "Webbutveckling I"),
                new ("DT084G", "Introduktion till programmering i JavaScript"),
                new ("DT093G", "Webbutveckling II"),
                new ("DT163G", "Digital bildbehandling för webb"),
                new ("DT173G", "Webbutveckling III"),
                new ("DT071G", "Programmering i C#.NET"),
                new ("DT162G", "Javascriptbaserad webbutveckling"),
                new ("DT191G", "Webbutveckling med .NET")
            };
        }
    }
}