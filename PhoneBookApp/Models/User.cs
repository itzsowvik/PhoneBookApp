using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PhoneBookApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string  Password { get; set; }

        public ICollection<ContactDetail> ContactDetails { get; set; }


    }
}
