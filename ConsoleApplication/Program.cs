using NinjaDomain.DataModel;
using NinjaDomain.Classes;
using System;
using System.Data.Entity;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());
            //InsertNinja();
            //InsertClan();
            InsertVariosNinjas();
            Console.ReadKey();
        }

        private static void InsertVariosNinjas()
        {
            var ge = new Ninja
            {
                Name = "Geovanna",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(2004, 11, 23),
                ClanId = 2
            };
            var gle = new Ninja
            {
                Name = "Gle",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(1986, 12, 31),
                ClanId = 2
            };
            var le = new Ninja
            {
                Name = "Leandro",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(1982, 03, 02),
                ClanId = 1
            };

            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.AddRange(new List<Ninja> { ge, le, gle});
                context.SaveChanges();
            }

        }

        private static void InsertClan()
        {
            var clan = new Clan
            {
                ClanName = "Rósinhas"
            };
            using (var  context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Clans.Add(clan);
                context.SaveChanges();
            }
        }

        private static void InsertNinja()
        {
            var ninja = new Ninja
            {
                Name = "Vinicius",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(2004, 12, 24),
                ClanId = 1
            };
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }
        }
    }
}
