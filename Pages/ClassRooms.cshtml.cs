using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOntheWeb.Models;

namespace ClassRooms.Pages
{
    public class ClassRoomsModel : PageModel
    {
        public ClassRoom Ant_Lamar = new ClassRoom(1, "Ant Lamar");
        public ClassRoom Gent = new ClassRoom(2, "Gent");
        public ClassRoom Brussel = new ClassRoom(3, "Brussel");
        
        public void OnGet()
        {
        }
    }
}
