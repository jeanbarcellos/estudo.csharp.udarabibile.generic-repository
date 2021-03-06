using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GenericRepository.Models;

namespace GenericRepository.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(DatabaseContext context) : base(context) { }

        public Task<Author> GetByName(string name)
        {
            return FindByCondition(author => author.Name == name);
        }

    }

}
