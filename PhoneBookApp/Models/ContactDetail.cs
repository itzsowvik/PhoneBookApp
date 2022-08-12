using System.ComponentModel.DataAnnotations;

namespace PhoneBookApp.Models
{
    public class ContactDetail
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
