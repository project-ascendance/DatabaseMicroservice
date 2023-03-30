using System.ComponentModel.DataAnnotations;

namespace DatabaseMicroservice.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<Role> Users { get; set;}
    }
}