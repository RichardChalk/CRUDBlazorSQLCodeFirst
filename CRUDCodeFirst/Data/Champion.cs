using System.ComponentModel.DataAnnotations;

namespace CRUDCodeFirst.Data
{
    public enum ChampionClass
    {
        Mage = 1,
        ADC = 2,
        Assassin = 3,
        Tank = 4,
        Bruiser = 5
    }

    public enum DamageType
    {
        AD = 1,
        AP = 2,
        Mixed = 3
    }
    public class Champion
    {
        [Key]
        public int ChampionId { get; set; }
        public string Name { get; set; }
        public ChampionClass Class { get; set; }
        public int StartingAttackDamage { get; set; }
        public DamageType DamageType { get; set; }
    }
}
