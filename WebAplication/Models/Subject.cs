using System.ComponentModel.DataAnnotations;

namespace WebAplication.Models
{
    public class Subject
    {
        [Key]
        public int id_Subject { get; set; }
        public string Name { get; set; }

        public int id_Teacher { get; set; }
    }
}
