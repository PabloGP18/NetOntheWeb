using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOntheWeb.Models;

namespace Teachers.Pages
{
    public class TeachersModel : PageModel
    {

        public Teacher Sicco = new Teacher(1, "Sicco", 1);
        public Teacher Tim = new Teacher(2, "Tim", 2);
        public Teacher Koen = new Teacher(3, "Koen", 3);
        
        public void OnGet()
        {
        }
    }
}
