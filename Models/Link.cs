namespace SUT23_Labb3_API.Models
{
    public class Link
    {
        public int LinkId { get; set; }
        public string Url { get; set; }

        public int PersonInterestId { get; set; }
        public PersonInterest PersonInterest { get; set; }
    }
}