using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vosplzen.sem1._2023k.Data;

namespace vosplzen.sem1._2023k.Pages
{

    public class QuestionnaireModel : PageModel
    {
        [BindProperty]
        public Questionnaire Questionnaire { get; set; } = new Questionnaire();

        public string Message { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Message = string.Empty;
                return Page();
            }

            Message = $"Dìkujeme za vyplnìní dotazníku. Vaše hodnocení je: {Questionnaire.Rating}.";

            Questionnaire = new Questionnaire();
            ModelState.Clear();

            return Page();

        }

        public void OnGet()
        {
        }
    }
}
