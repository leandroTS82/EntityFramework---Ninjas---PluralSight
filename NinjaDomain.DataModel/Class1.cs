using NinjaDomain.Classes;
using System.Data.Entity;

namespace NinjaDomain.DataModel
{
    public class NinjaContext : DbContext
    {
        public NinjaContext() : base("name=NinjaContext")
        {
        }
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipament> Equipament { get; set; }
    }
}
