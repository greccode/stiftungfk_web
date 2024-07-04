using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace FK_Stiftung.Models
{
    public class ProjektFoerderer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Name des Förderers darf nicht leer sein.")]
        [DisplayName("Name des Projektförderers")]
        public string Name { get; set; }

        public string ImageUrl { get; set; }

    }
}
