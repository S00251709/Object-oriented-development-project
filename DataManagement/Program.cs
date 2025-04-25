using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object_oriented_development_project;

/*namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoomData db = new RoomData();

            using(db)
            {
                Room R1 = new Room() { Id = 1, DescriptionType = "Wall&Items", RoomDescription = "The air hangs heavy and damp within these rough-hewn walls. Time and neglect have conspired to coat the stone with a patina of grime, punctuated by streaks of water damage that resemble grotesque, weeping faces. Iron sconces, long devoid of torches, are bolted unevenly into the stone, their rusty surfaces hinting at flickering shadows long past. Chains, thick as a man's arm, dangle from the walls in several places, their purpose ominously suggesting a history of restraint. A rickety wooden table sits askew in one corner, littered with the remnants of a forgotten meal – a tarnished pewter mug, a gnawed bone, and the lingering scent of mildew. " };
                Room R2 = new Room() { Id = 2, DescriptionType = "Floor&Ceiling", RoomDescription = "Beneath your feet lies a flagstone floor, uneven and worn smooth in places by countless passages. Cracks spiderweb across its surface, filled with dark, indeterminate matter. Overhead, the ceiling is a low, oppressive arch of the same rough stone as the walls. Dust motes dance in the faint light filtering from unseen sources, illuminating cobwebs that hang like macabre tapestries from the stone. Patches of dampness cling to the ceiling, promising a perpetual, unwelcome drizzle. " };
                Room R3 = new Room() { Id = 3, DescriptionType = "Ambience", RoomDescription = "A profound stillness permeates the dungeon, broken only by the occasional drip of water echoing unnervingly through the space. The air is thick with the scent of damp earth, mildew, and a faint, indefinable odor that hints at decay. A palpable sense of unease clings to the air, as if the very stones remember the countless untold stories of suffering and despair that have unfolded within these walls. One can almost feel the weight of the darkness pressing down, a silent testament to the dungeon's grim and forgotten history." };


                db.Rooms.Add(R1);
                db.Rooms.Add(R2);
                db.Rooms.Add(R3);

                Console.WriteLine("Added rooms");
                
                db.SaveChanges();

                Console.WriteLine("saved changes");
            }

        }
    }
}*/
namespace Object_oriented_development_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoomData db = new RoomData();

            using (db)
            {
                if (db.Doors.Any())
                {
                    db.Rooms.RemoveRange(db.Rooms);
                    db.Doors.RemoveRange(db.Doors);
                    db.SaveChanges();
                }

                Door woodenDoor = new Door { DoorType = "Wooden" };

                Room R1 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Mossy stone walls with chains and a broken shelf.", Door = woodenDoor };
                Room R2 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Rough flagstones below and a low wooden ceiling above.", Door = woodenDoor };
                Room R3 = new Room { DescriptionType = "Ambience", RoomDescription = "A musty, cold air with a faint smell of decay.", Door = woodenDoor };

                db.Doors.Add(woodenDoor);
                db.Rooms.Add(R1);
                db.Rooms.Add(R2);
                db.Rooms.Add(R3);

                Console.WriteLine("Added rooms");

                try
                {
                    db.SaveChanges();
                    Console.WriteLine("Saved changes");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}