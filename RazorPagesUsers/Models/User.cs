using RazorPagesUsers.Entities;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesUsers.UserModel
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Email length can't be more than 50.")]
        public string EmailAddress { get; set; }

        [Display(Name="Role Id")]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
