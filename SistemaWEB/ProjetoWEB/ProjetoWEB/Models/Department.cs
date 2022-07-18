using System.ComponentModel.DataAnnotations;

namespace ProjetoWEB.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public virtual ICollection<Employees> Employees { get; set; } = new List<Employees>();
    }
}
