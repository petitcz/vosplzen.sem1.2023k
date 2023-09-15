using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vosplzen.sem1._2023k.Data;

namespace vosplzen.sem1._2023k.Pages
{
    public class StudentsModel : PageModel
    {

        public List<Student> Students { get; set; } = new List<Student>();

        public void OnGet(string orderby = "lastname")
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

            if (orderby.Equals("lastname"))
            {
                Students = Students.OrderBy(x => x.LastName).ToList();
            }
            else if (orderby.Equals("email"))
            {
                Students = Students.OrderBy(x => x.Email).ToList();
            }
            else if (orderby.Equals("name"))
            {
                Students = Students.OrderBy(x => x.Name).ToList();
            }
            else if (orderby.Equals("class"))
            {
                Students = Students.OrderBy(x => x.Class).ToList();
            }
        }
    }
}
