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

                //Create doors of different types
                Door woodenDoor = new Door { DoorType = "Wooden" };

                Room R1 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Mossy stone walls with chains and a broken shelf.", Door = woodenDoor };
                Room R2 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Rough flagstones below and a low wooden ceiling above.", Door = woodenDoor };
                Room R3 = new Room { DescriptionType = "Ambience", RoomDescription = "A musty, cold air with a faint smell of decay.", Door = woodenDoor };
                Room R4 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Old wooden beams overhead creak with age, dust fills the air.", Door = woodenDoor };
                Room R5 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "A large, ancient oak door on the far wall leads further into the unknown.", Door = woodenDoor };
                Room R6 = new Room { DescriptionType = "Ambience", RoomDescription = "A dimly lit space, with cracks in the walls revealing glimpses of the outside world.", Door = woodenDoor };

                db.Doors.Add(woodenDoor);
                db.Rooms.AddRange(new[] { R1, R2, R3, R4, R5, R6 });

                //Iron Door
                Door ironDoor = new Door { DoorType = "Iron" };

                Room R7 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The iron walls gleam faintly, with intricate carvings of mythical creatures on them. There is a large stone altar in the center, covered in ancient dust.", Door = ironDoor };
                Room R8 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is covered in a thin layer of grime, with shattered glass scattered about. The ceiling is made of heavy iron plates, suspended by chains. A dull metallic clang is heard occasionally.", Door = ironDoor };
                Room R9 = new Room { DescriptionType = "Ambience", RoomDescription = "A cold chill runs through the room, as the sound of creaking metal echoes in the distance. The smell of rust and aged leather fills the room, mingling with the scent of fresh air.", Door = ironDoor };
                Room R10 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Heavy chains dangle from the ceiling, swaying with each breath of wind, while rusted iron sconces emit a faint glow.", Door = ironDoor };
                Room R11 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The walls are filled with broken iron bars, remnants of cages long abandoned. The floor is slick with dust and rusted remnants.", Door = ironDoor };
                Room R12 = new Room { DescriptionType = "Ambience", RoomDescription = "The iron walls are warped, bending inward as if under pressure, casting eerie shadows on the floor below.", Door = ironDoor };

                db.Doors.Add(ironDoor);
                db.Rooms.AddRange(new[] { R7, R8, R9, R10, R11, R12 });

                //Stone Door
                Door stoneDoor = new Door { DoorType = "Stone" };

                Room R13 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The stone walls are adorned with ancient runes that glow faintly in the dark. There is a pedestal in the middle of the room with a strange, glowing crystal.", Door = stoneDoor };
                Room R14 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is made of smooth stone slabs that are worn down by years of foot traffic. The ceiling is a high, vaulted expanse, with faint traces of carvings that have faded with time.", Door = stoneDoor };
                Room R15 = new Room { DescriptionType = "Ambience", RoomDescription = "The room has a mysterious, ancient atmosphere. The air smells of old stone and dust, and there is a quiet hum that fills the room, as if the stone itself is alive.", Door = stoneDoor };
                Room R16 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls are uneven, with cracks showing the passage of time. A large, stone throne sits against one wall, untouched for centuries.", Door = stoneDoor };
                Room R17 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Large pillars stand in the corners of the room, with faint etchings visible on their surface, while the floor is slick with moisture.", Door = stoneDoor };
                Room R18 = new Room { DescriptionType = "Ambience", RoomDescription = "Stone slabs create a maze-like environment, with narrow pathways winding between jagged rocks, leading deeper into the unknown.", Door = stoneDoor };

                db.Doors.Add(stoneDoor);
                db.Rooms.AddRange(new[] { R13, R14, R15, R16, R17, R18 });

                //Glass Door
                Door glassDoor = new Door { DoorType = "Glass" };

                Room R19 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls are made entirely of shattered glass, reflecting light at odd angles. In the center, a pedestal holds an ornate golden mirror, cracked down the center.", Door = glassDoor };
                Room R20 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is smooth and reflective, like glass. The ceiling is a series of interconnected glass panels, through which the sky can be seen. The light creates an ethereal glow.", Door = glassDoor };
                Room R21 = new Room { DescriptionType = "Ambience", RoomDescription = "The air is cold, and the faint sound of glass cracking underfoot echoes through the room. A soft breeze flows through the cracks in the walls, making the room feel unsettlingly fragile.", Door = glassDoor };
                Room R22 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The floor is littered with shards of broken glass, creating a dangerous maze of reflections. Above, a stained-glass dome creates a prism of color across the room.", Door = glassDoor };
                Room R23 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Glass walls on all sides provide a full view of the surroundings. A soft sound of wind makes the glass panes vibrate slightly, creating a faint melodic hum.", Door = glassDoor };
                Room R24 = new Room { DescriptionType = "Ambience", RoomDescription = "The room is completely transparent, offering no privacy from the world beyond. A single large shard of glass stands in the center, surrounded by traces of ancient symbols.", Door = glassDoor };

                db.Doors.Add(glassDoor);
                db.Rooms.AddRange(new[] { R19, R20, R21, R22, R23, R24 });

                //Ornate Door
                Door ornateDoor = new Door { DoorType = "Ornate" };

                Room R25 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls are covered in intricate tapestries depicting grand battles and celestial beings. Golden sconces line the walls, holding flickering candles.", Door = ornateDoor };
                Room R26 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is made of polished marble, with large carpets placed around the room. The ceiling is high, with painted frescoes of gods and legendary heroes.", Door = ornateDoor };
                Room R27 = new Room { DescriptionType = "Ambience", RoomDescription = "The room has an air of grandeur and elegance. The scent of burning incense fills the air, mingling with the faint sound of distant music.", Door = ornateDoor };
                Room R28 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Richly decorated furniture fills the room, with velvet curtains hanging from golden rods. Large chandeliers cast soft light over everything, creating an atmosphere of opulence.", Door = ornateDoor };
                Room R29 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Columns adorned with golden filigree stretch up to the ceiling, and ornate carvings line the walls, depicting scenes from ancient myth.", Door = ornateDoor };
                Room R30 = new Room { DescriptionType = "Ambience", RoomDescription = "An ornate mirror stands at the center of the room, with gold framing and intricate carvings. Soft music plays in the background, adding to the ethereal atmosphere.", Door = ornateDoor };

                db.Doors.Add(ornateDoor);
                db.Rooms.AddRange(new[] { R25, R26, R27, R28, R29, R30 });

                //Rusty Door
                Door rustyDoor = new Door { DoorType = "Rusty" };

                Room R31 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The rusted walls have peeling paint, with old pipes running along the edges. There is a large, rusted cage in the corner, abandoned and falling apart.", Door = rustyDoor };
                Room R32 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is uneven and cracked, covered in rust and dust. The ceiling is made of rusted metal, sagging in places, with holes letting in bits of light from above.", Door = rustyDoor };
                Room R33 = new Room { DescriptionType = "Ambience", RoomDescription = "The air smells of rust and decay, and there’s a constant drip of water from the ceiling. The room is eerily silent except for the occasional groan of the old metal.", Door = rustyDoor };
                Room R34 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The rusted walls are covered with old graffiti and signs of wear, and a large machine in the corner is in disrepair, its gears missing teeth.", Door = rustyDoor };
                Room R35 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is cracked and covered in rust, with broken pipes running along the edges. A small pool of stagnant water sits in the corner, reflecting the dim light.", Door = rustyDoor };
                Room R36 = new Room { DescriptionType = "Ambience", RoomDescription = "The ceiling is low, and the walls are warped from age. The room feels claustrophobic, with old tools and discarded items scattered throughout the space.", Door = rustyDoor };

                db.Doors.Add(rustyDoor);
                db.Rooms.AddRange(new[] { R31, R32, R33, R34, R35, R36 });

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