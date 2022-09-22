using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorld.Pages
{
    public class HelloWebModel : PageModel
    {
        public void OnGet()
        {
        }
        public string Message { get; set; } = "In page model: ";
    }
}
