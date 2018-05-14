using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models
{
    public class BaseModel
    {
        [Required]
        public int Id { get; set; }
    }
}