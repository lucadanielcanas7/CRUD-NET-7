using System.ComponentModel.DataAnnotations;

namespace CRUDNet7MVC.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre.")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido.")]
        public string? Lastname { get; set; }

        public string? Phone { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar el celular.")]
        public string? Cellphone { get; set; }

        [Required(ErrorMessage = "Debe ingresar el correo electrónico.")]
        public string? Email { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
