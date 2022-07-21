using CRUDCodeFirst.Data;

namespace CRUDCodeFirst.Services
{
    public interface IChampionServices
    {

        public List<Champion> GetChampions();

        public bool AddChampion(Champion champion);
      
    }
}
