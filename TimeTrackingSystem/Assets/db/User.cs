using System.ComponentModel.DataAnnotations;

namespace TimeTrackingSystem.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        public string Company { get; set; }

        public int Status { get; set; } // Предположим, что статус пользователей кодируется целым числом
    }
}
