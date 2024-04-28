using SUT23_Labb3_API.Models;

namespace SUT23_Labb3_API.Services
{
    public interface ILabb
    {
        Task<IEnumerable<Person>> GetAll();
        Task<IEnumerable<Interest>> GetPersonInterest(int id);
        Task<IEnumerable<Link>> GetPersonLinks(int id);
        Task AddPersonInterest(int personId, int interest);
        Task AddPersonLink(int personId, int interestId, string url);
    }
}
