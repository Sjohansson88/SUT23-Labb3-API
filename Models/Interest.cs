using System.ComponentModel.DataAnnotations;

namespace SUT23_Labb3_API.Models
{
    public class Interest
    {
        [Key]
        public int InterestId { get; set; }
        public string InterestName { get; set; }
        public string InterestDesc { get; set;}

        public ICollection<PersonInterest> PersonInterest {  get; set; }
    }
}
