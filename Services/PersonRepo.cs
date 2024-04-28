using Microsoft.EntityFrameworkCore;
using SUT23_Labb3_API.Data;
using SUT23_Labb3_API.Models;

namespace SUT23_Labb3_API.Services
{
    public class PersonRepo : ILabb
    {

        private ILabbDbContext _dbContext;
        public PersonRepo(ILabbDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddPersonInterest(int personId, int interest)
        {
            var personInterest = new PersonInterest
            {
                PersonId = personId,
                InterestId = interest
            };
            _dbContext.PersonInterests.Add(personInterest);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddPersonLink(int personId, int interestId, string url)
        {
            var result = new PersonInterest
            {
                PersonId = personId,
                InterestId = interestId,
                Links = new List<Link>() { new Link { Url = url } }
            };
            _dbContext.PersonInterests.Add(result);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _dbContext.Persons.ToListAsync();
        }

        public async Task<IEnumerable<Interest>> GetPersonInterest(int id)
        {
            var personInterest = await _dbContext.PersonInterests.Where(p => p.PersonId == id).Select(p => p.Interest).ToListAsync();
            return personInterest;
        }

        public async Task<IEnumerable<Link>> GetPersonLinks(int id)
        {
            return await _dbContext.PersonInterests.Where(p => p.PersonId == id).SelectMany(u => u.Links).ToListAsync();
        }
    }
}
