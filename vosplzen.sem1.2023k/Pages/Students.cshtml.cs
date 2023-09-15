using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vosplzen.sem1._2023k.Data;
using vosplzen.sem1._2023k.Services;

namespace vosplzen.sem1._2023k.Pages
{
    public class StudentsModel : PageModel
    {

        public List<Student> Students { get; set; } = new List<Student>();

        public string Orderby { get; set; } = string.Empty;

        public string ClassBy { get; set; } = string.Empty;

        public void OnGet(string orderby = "lastname", string classby = "")
        {
            Orderby = orderby;
            ClassBy = classby;

            Students = StudentService.GetData(Orderby, ClassBy);      
        }
    }
}
