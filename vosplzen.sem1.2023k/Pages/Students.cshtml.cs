using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vosplzen.sem1._2023k.Data;

namespace vosplzen.sem1._2023k.Pages
{
    public class StudentsModel : PageModel
    {

        public List<Student> Students { get; set; } = new List<Student>();

        public void OnGet()
        {
            Students.Add(new Student()
            {
                Class = "1A",
                Email = "bohac@vosplzen.cz",
                Name = "Petr",
                LastName = "Boháè"
            });

            Students.Add(new Student()
            {
                Class = "1A",
                Email = "zavadska@vosplzen.cz",
                Name = "Marie",
                LastName = "Zavadska"
            });

            Students.Add(new Student()
            {
                Class = "3A",
                Email = "fictum@vosplzen.cz",
                Name = "Jiøí",
                LastName = "Fictum"
            });


        }
    }
}
