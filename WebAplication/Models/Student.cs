using System.ComponentModel.DataAnnotations;

namespace WebAplication.Models
{
    public class Student
    {
        [Key]

        public int id_Student { get; set; }

        public string Name { get; set; }

        public string Lastname { get; set; }

        public int Age { get; set; }

        public bool Sex { get; set; }

        public int id_University { get; set; }

    }

}
