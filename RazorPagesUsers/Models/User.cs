using System.ComponentModel.DataAnnotations;

namespace RazorPagesUsers.UserModel
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }
}
