using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOntheWeb.Models;

namespace Students.Pages
{
    public class StudentsModel : PageModel
    {
        
        public Student Pablo = new(1,"Pablo",1 );
        public Student Zeno = new(1,"Zeno",2 );
        public Student Michael = new(1,"MichaeL",3 );
        public Student Shiva = new(2,"Shiva",1 );
        public Student Lucas = new(2,"Lucas",2 );
        public Student Snehal = new(2,"Snehal",3 );
        public Student Besart = new(3,"Besart",1 );
        public Student Mo = new(3,"Mo",2 );
        public Student Brian = new(3,"Brain",3 );
        public string Message { get; set; } = "In page model: ";

        public void OnGet()
        {
        }
    }
}
