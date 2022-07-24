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
        
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required] 
        public ChampionClass Class { get; set; }

        [Required]
        [Range(50,110)]
        public int StartingAttackDamage { get; set; }

        [Required]
        public DamageType DamageType { get; set; }

    }
}
