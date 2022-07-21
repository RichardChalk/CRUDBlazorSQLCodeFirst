using System.ComponentModel.DataAnnotations;

namespace CRUDCodeFirst.Data
{
    public enum ChampionClass
    {
        Mage,
        ADC,
        Assassin,
        Tank,
        Bruiser
    }

    public enum DamageType
    {
        AD,
        AP,
        Mixed
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
