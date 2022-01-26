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
        public void OnGet()
        {
            
        }
    }
}