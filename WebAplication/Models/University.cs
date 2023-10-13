using System.ComponentModel.DataAnnotations;

namespace WebAplication.Models
{
    public class University
    {
        [Key]

        public int id_University { get; set; }
        
        public string Name { get; set; }
    }
}
