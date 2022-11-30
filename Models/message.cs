using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace la_mia_pizzeria_static.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "questo campo è obligatorio")]
        public string Email { get; set; }
        [Required(ErrorMessage = "questo campo è obligatorio")]
        public string TitleMessage { get; set; }
        [Required(ErrorMessage = "questo campo è obligatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "questo campo è obligatorio")]
        public string TextMessage { get; set; }

    }
}
