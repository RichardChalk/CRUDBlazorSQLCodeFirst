using CRUDCodeFirst.Data;

namespace CRUDCodeFirst.Services
{
    public interface IChampionServices
    {

        public List<Champion> GetChampions();
        public Champion GetChampionDetails(int id);

        public bool AddChampion(Champion champion);
        public bool UpdateChampion(Champion updateChamp);


    }
}
