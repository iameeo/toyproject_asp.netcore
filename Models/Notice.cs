using System.ComponentModel.DataAnnotations;

namespace ToyProject.Models
{
    public class Notice
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public string? UserId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public DateTime? Regdate { get; set; }
    }
}
