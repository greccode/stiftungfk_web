using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace FK_Stiftung.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Projektname darf nicht leer sein")]
        [DisplayName("Projektname")]
        public string Name { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Projektbeschreibung muss mindestens 5 Zeichen enthalten")]
        [DisplayName("Projektbeschreibung")]
        public string Description { get; set; }

        public string PicturePath { get; set; }
    }
}
