using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOntheWeb.Models;

namespace Students.Pages
{
    public class StudentsModel : PageModel
    {
        
        public Student Pablo = new(1,"Pablo",1 );
        public Student Zeno = new(2,"Zeno",2 );
        public Student Michael = new(3,"MichaeL",3 );
        public Student Shiva = new(4,"Shiva",1 );
        public Student Lucas = new(5,"Lucas",2 );
        public Student Snehal = new(6,"Snehal",3 );
        public Student Besart = new(7,"Besart",1 );
        public Student Mo = new(8,"Mo",2 );
        public Student Brian = new(9,"Brain",3 );
        public string Message { get; set; } = "In page model: ";

        public void OnGet()
        {
        }
    }
}
