
using RazorPagesUsers.UserModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesUsers.Entities
{
    public class Role
    {
        [Display(Name = "Role Id")]
        public int Id { get; set; }

        [Display(Name = "Role Name")]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
