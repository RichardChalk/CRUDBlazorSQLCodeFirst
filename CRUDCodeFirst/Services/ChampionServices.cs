using CRUDCodeFirst.Data;

namespace CRUDCodeFirst.Services
{
    public class ChampionServices
    {
        public ApplicationDbContext _context { get; }
        public ChampionServices(ApplicationDbContext context)
        {
            _context = context;
        }

       
    }
}
