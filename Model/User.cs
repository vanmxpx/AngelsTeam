using System.ComponentModel.DataAnnotations;

namespace AngelsTeam.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(20)]
        public string Login { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(20)]
        public string Password { get; set; }
        [Required]
        public string Telegram { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}