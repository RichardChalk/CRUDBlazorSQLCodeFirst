using CRUDCodeFirst.Data;

namespace CRUDCodeFirst.Services
{
    public class ChampionServices : IChampionServices
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

        public Champion GetChampionDetails(int id)
        {
            //Champion editObj = new Champion();
            return _context.Champions.FirstOrDefault(c=>c.ChampionId == id);
        }

        public bool UpdateChampion(Champion updateChamp)
        {
            var getChamp = _context.Champions.FirstOrDefault(c => c.ChampionId == updateChamp.ChampionId);
            if (getChamp != null)
            {
                // Refactor - Automapper
                getChamp.Name = updateChamp.Name;
                getChamp.DamageType = updateChamp.DamageType;
                getChamp.StartingAttackDamage = updateChamp.StartingAttackDamage;
                getChamp.Class = updateChamp.Class;
                _context.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
