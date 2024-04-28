using System.ComponentModel.DataAnnotations;

namespace SUT23_Labb3_API.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25)]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<PersonInterest> PersonInterest { get; set; }

    }
}
