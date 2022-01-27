using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Pages.Razor
{
    /**
     * class for storing courses
     */
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