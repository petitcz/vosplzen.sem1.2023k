using vosplzen.sem1._2023k.Data;

namespace vosplzen.sem1._2023k.Services
{
    public class StudentService
    {

        public static List<Student> GetData(string orderby = "lastname", string classby = "")
        {
            var students = new List<Student>();

            students.Add(new Student()
            {
                Class = "1A",
                Email = "bohac@vosplzen.cz",
                Name = "Petr",
                LastName = "Boháč"
            });

            students.Add(new Student()
            {
                Class = "1A",
                Email = "zavadska@vosplzen.cz",
                Name = "Marie",
                LastName = "Zavadska"
            });

            students.Add(new Student()
            {
                Class = "3A",
                Email = "fictum@vosplzen.cz",
                Name = "Jiří",
                LastName = "Fictum"
            });

            students.Add(new Student()
            {
                Class = "2B",
                Email = "adina@vosplzen.cz",
                Name = "Adina",
                LastName = "Mandlova"
            });

            students.Add(new Student()
            {
                Class = "2B",
                Email = "mariuscz@vosplzen.cz",
                Name = "Mariuscz",
                LastName = "Szczygieł"
            });


            if (orderby.Equals("lastname"))
            {
                students = students.OrderBy(x => x.LastName).ToList();
            }
            else if (orderby.Equals("email"))
            {
                students = students.OrderBy(x => x.Email).ToList();
            }
            else if (orderby.Equals("name"))
            {
                students = students.OrderBy(x => x.Name).ToList();
            }
            else if (orderby.Equals("class"))
            {
                students = students.OrderBy(x => x.Class).ToList();
            }

            if(classby.Length > 0)
            {
                students = students.Where(x => x.Class.Equals(classby)).ToList();
            }

            return students;
        }

    }
}
