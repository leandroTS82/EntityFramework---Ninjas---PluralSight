using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NinjaDomain.Classes
{
    public class Ninja
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ServedInOniwaban { get; set; }
        public Clan Clan { get; set; }
        public int ClanId { get; set; }
        public List<NinjaEquipament> EquipamentOwned { get; set; }
        public System.DateTime DateOfBirth { get; set; }

    }
    public class Clan
    {
        public int Id { get; set; }
        public string ClanName { get; set; }
        public List<Ninja> Ninjas { get; set; }
    }

    public class NinjaEquipament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EquipamentType type { get; set; }
        [Required]
        public Ninja Ninja { get; set; }
    }

}
