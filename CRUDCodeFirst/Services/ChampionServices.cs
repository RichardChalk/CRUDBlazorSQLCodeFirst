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

        public List<Champion> GetChampions()
        {
            return _context.Champions.ToList();
        }

        public bool AddChampion(Champion champion)
        {
            _context.Champions.Add(champion);
            _context.SaveChanges();
            return true;
        }

       
    }
}
