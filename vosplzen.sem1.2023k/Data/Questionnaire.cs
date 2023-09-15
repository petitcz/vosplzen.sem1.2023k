using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace vosplzen.sem1._2023k.Data
{
    public class Questionnaire
    {

        [DisplayName("Jméno")]
        [Required(ErrorMessage = "Toto pole je povinné."), MaxLength(30)]
        public string Name { get; set; }

        [DisplayName("Příjmení")]
        [Required(ErrorMessage = "Toto pole je povinné."), MaxLength(30)]
        public string LastName { get; set; }

        [DisplayName("Hodnocení")]
        public int Rating { get; set; }

        public string FullName { get { return $"{LastName} {Name}"; } }
    }
}
