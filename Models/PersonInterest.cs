using System.ComponentModel.DataAnnotations;

namespace SUT23_Labb3_API.Models
{
    public class PersonInterest
    {
        [Key]
        public int PersonInterestId { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int InterestId { get; set; }
        public Interest Interest { get; set; }
        public List<Link> Links { get; set; }
    }
}
