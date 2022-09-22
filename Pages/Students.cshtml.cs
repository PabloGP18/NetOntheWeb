using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOntheWeb.Models;

namespace Students.Pages
{
    public class StudentsModel : PageModel
    {
        
        public Student Pablo = new(1,"Pablo",1 );
        public Student Melao = new(1,"Melao",1 );
        public string Message { get; set; } = "In page model: ";

        public void OnGet()
        {
        }
    }
}
