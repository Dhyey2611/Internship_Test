using Internship_Test.Data;
using Microsoft.EntityFrameworkCore.Storage;

namespace Internship_Test.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly DatabaseContext _context;   
        public MenuRepository(DatabaseContext context)
        {
            _context = context;
        }    
    }
}