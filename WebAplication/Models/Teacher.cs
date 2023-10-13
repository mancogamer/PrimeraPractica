using System.ComponentModel.DataAnnotations;

namespace WebAplication.Models
{
    public class Teacher
    {
        [Key]

        public int id_Teacher { get; set; }

        public string Name { get; set; }

        public string Lastname { get; set; }

        public string Location { get; set; }

        public bool Sex { get; set; }

        public string CI { get; set; }

        public int id_University { get; set; }

    }
}
