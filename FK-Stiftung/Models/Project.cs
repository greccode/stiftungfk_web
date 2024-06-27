using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace FK_Stiftung.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Projektname")]
        public string Name { get; set; }
        [DisplayName("Projektbeschreibung")]
        public string Description { get; set; }
    }
}
