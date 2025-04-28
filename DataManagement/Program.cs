using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object_oriented_development_project;

namespace DataManagement
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
                // Wooden Door
                Door woodenDoor = new Door { DoorType = "Wooden" };

                Room R1 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Moss-covered stone walls, broken wooden benches, and chains hanging from rusty hooks.", Door = woodenDoor };
                Room R2 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Cracked flagstones underfoot, low beams overhead draped with cobwebs.", Door = woodenDoor };
                Room R3 = new Room { DescriptionType = "Ambience", RoomDescription = "The scent of mold and old rainwater saturates the air.", Door = woodenDoor };
                Room R4 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Splintered barrels and broken tools litter the corners.", Door = woodenDoor };
                Room R5 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Soggy hay scattered across the floor, with gaps revealing earth below.", Door = woodenDoor };
                Room R6 = new Room { DescriptionType = "Ambience", RoomDescription = "A chorus of creaking wood and distant, ghostly howls fills the chamber.", Door = woodenDoor };
                Room R7 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Old portraits hang crookedly, faces scratched away by time.", Door = woodenDoor };
                Room R8 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Floorboards sag dangerously; light filters through ceiling cracks.", Door = woodenDoor };
                Room R9 = new Room { DescriptionType = "Ambience", RoomDescription = "Faint laughter echoes from somewhere unseen.", Door = woodenDoor };
                Room R10 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Bundles of dried herbs hang from rafters, brittle and forgotten.", Door = woodenDoor };
                Room R11 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling bulges downward as if something heavy rests atop.", Door = woodenDoor };
                Room R12 = new Room { DescriptionType = "Ambience", RoomDescription = "You feel the oppressive weight of unseen watchers.", Door = woodenDoor };

                db.Doors.Add(woodenDoor);
                db.Rooms.AddRange(new[] { R1, R2, R3, R4, R5, R6, R7, R8, R9, R10, R11, R12 });

                // Iron Door
                Door ironDoor = new Door { DoorType = "Iron" };

                Room R13 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls of riveted iron plates scarred by fire and battle.", Door = ironDoor };
                Room R14 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "A floor coated in soot and old blood; massive iron chains dangle from above.", Door = ironDoor };
                Room R15 = new Room { DescriptionType = "Ambience", RoomDescription = "A grinding, mechanical drone reverberates through the iron walls.", Door = ironDoor };
                Room R16 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Smashed control panels and broken gears litter the ground.", Door = ironDoor };
                Room R17 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Thick iron beams crisscross the ceiling; the floor bears molten scars.", Door = ironDoor };
                Room R18 = new Room { DescriptionType = "Ambience", RoomDescription = "Sparks occasionally jump from exposed wiring in the walls.", Door = ironDoor };
                Room R19 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "A giant locked vault stands at the far end, its door warped and half-melted.", Door = ironDoor };
                Room R20 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Broken axles and rusted wheels are embedded in the stone floor.", Door = ironDoor };
                Room R21 = new Room { DescriptionType = "Ambience", RoomDescription = "The air smells of ozone and scorched metal.", Door = ironDoor };
                Room R22 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Ancient chains are bolted to the walls, too massive for any human.", Door = ironDoor };
                Room R23 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "An open grate in the floor emits a low, throbbing sound.", Door = ironDoor };
                Room R24 = new Room { DescriptionType = "Ambience", RoomDescription = "Something enormous and unseen moves far below the floor.", Door = ironDoor };

                db.Doors.Add(ironDoor);
                db.Rooms.AddRange(new[] { R13, R14, R15, R16, R17, R18, R19, R20, R21, R22, R23, R24 });

                // Stone Door
                Door stoneDoor = new Door { DoorType = "Stone" };

                Room R25 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Craggy stone walls adorned with faintly glowing runes.", Door = stoneDoor };
                Room R26 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is uneven rock, slick with subterranean moisture.", Door = stoneDoor };
                Room R27 = new Room { DescriptionType = "Ambience", RoomDescription = "The rumble of distant subterranean rivers reverberates faintly.", Door = stoneDoor };
                Room R28 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Massive stone statues guard the doorways, their faces eroded smooth.", Door = stoneDoor };
                Room R29 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Jagged stalactites hang menacingly overhead.", Door = stoneDoor };
                Room R30 = new Room { DescriptionType = "Ambience", RoomDescription = "The musty scent of old earth and something less natural pervades the air.", Door = stoneDoor };
                Room R31 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Moss and pale mushrooms cluster along the damp walls.", Door = stoneDoor };
                Room R32 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The stone ceiling has collapsed partially, forming dangerous rubble piles.", Door = stoneDoor };
                Room R33 = new Room { DescriptionType = "Ambience", RoomDescription = "Whispers in an unknown tongue drift from unseen cracks in the walls.", Door = stoneDoor };
                Room R34 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Sarcophagi line the walls, their lids slightly ajar.", Door = stoneDoor };
                Room R35 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Pools of murky water cover most of the floor.", Door = stoneDoor };
                Room R36 = new Room { DescriptionType = "Ambience", RoomDescription = "Every sound you make seems amplified, bouncing endlessly off stone.", Door = stoneDoor };

                db.Doors.Add(stoneDoor);
                db.Rooms.AddRange(new[] { R25, R26, R27, R28, R29, R30, R31, R32, R33, R34, R35, R36 });

                // CRYSTAL DOOR
                Door crystalDoor = new Door { DoorType = "Crystal" };

                Room R37 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Shimmering crystal walls reflect distorted images of yourself.", Door = crystalDoor };
                Room R38 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "A translucent floor beneath which strange lights swirl.", Door = crystalDoor };
                Room R39 = new Room { DescriptionType = "Ambience", RoomDescription = "A faint musical hum resonates through the crystals.", Door = crystalDoor };
                Room R40 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Floating crystal shards rotate slowly in the air.", Door = crystalDoor };
                Room R41 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling is a massive single crystal glowing softly.", Door = crystalDoor };
                Room R42 = new Room { DescriptionType = "Ambience", RoomDescription = "Every sound you make echoes melodically.", Door = crystalDoor };
                Room R43 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "A crystalline throne sits empty, cracked and abandoned.", Door = crystalDoor };
                Room R44 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor refracts light into dancing rainbows.", Door = crystalDoor };
                Room R45 = new Room { DescriptionType = "Ambience", RoomDescription = "A cold presence brushes past you as unseen figures whisper.", Door = crystalDoor };
                Room R46 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Mirage-like corridors branch endlessly from this chamber.", Door = crystalDoor };
                Room R47 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Glass stalactites drip from the ceiling, dangerously sharp.", Door = crystalDoor };
                Room R48 = new Room { DescriptionType = "Ambience", RoomDescription = "Time seems distorted here — moments stretch unnaturally long.", Door = crystalDoor };

                db.Doors.Add(crystalDoor);
                db.Rooms.AddRange(new[] { R37, R38, R39, R40, R41, R42, R43, R44, R45, R46, R47, R48 });

                // BONE DOOR
                Door boneDoor = new Door { DoorType = "Bone" };

                Room R49 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls assembled from interlocked skeletons, some still faintly twitching.", Door = boneDoor };
                Room R50 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "A brittle floor of cracked rib bones that snap underfoot.", Door = boneDoor };
                Room R51 = new Room { DescriptionType = "Ambience", RoomDescription = "A faint rattling follows your every step, like unseen bones shifting.", Door = boneDoor };
                Room R52 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Skulls are embedded into the walls, their sockets leaking dark tears.", Door = boneDoor };
                Room R53 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling arches upward, made entirely of stacked vertebrae.", Door = boneDoor };
                Room R54 = new Room { DescriptionType = "Ambience", RoomDescription = "The smell of ancient decay clings heavily to the air.", Door = boneDoor };
                Room R55 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Giant femurs support doorways between chambers.", Door = boneDoor };
                Room R56 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is uneven, with sharp bone splinters jutting up dangerously.", Door = boneDoor };
                Room R57 = new Room { DescriptionType = "Ambience", RoomDescription = "You swear the walls whisper in languages long dead.", Door = boneDoor };
                Room R58 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "A throne fashioned from pelvises and spines sits empty.", Door = boneDoor };
                Room R59 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Hanging bone chimes clatter with every breath of wind.", Door = boneDoor };
                Room R60 = new Room { DescriptionType = "Ambience", RoomDescription = "An oppressive silence falls whenever you try to speak.", Door = boneDoor };

                db.Doors.Add(boneDoor);
                db.Rooms.AddRange(new[] { R49, R50, R51, R52, R53, R54, R55, R56, R57, R58, R59, R60 });

                // CLOCKWORK DOOR
                Door clockworkDoor = new Door { DoorType = "Clockwork" };

                Room R61 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls of brass panels with gears turning inside transparent casings.", Door = clockworkDoor };
                Room R62 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "A floor tiled with rotating cogs that move as you step.", Door = clockworkDoor };
                Room R63 = new Room { DescriptionType = "Ambience", RoomDescription = "A relentless ticking sound pulses like a heartbeat.", Door = clockworkDoor };
                Room R64 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Pipes crisscross the walls, occasionally hissing steam.", Door = clockworkDoor };
                Room R65 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling is a glass dome showing spinning stars beyond.", Door = clockworkDoor };
                Room R66 = new Room { DescriptionType = "Ambience", RoomDescription = "The air tastes faintly metallic, laced with ozone.", Door = clockworkDoor };
                Room R67 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "A giant clock mechanism dominates one side of the chamber.", Door = clockworkDoor };
                Room R68 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Trapdoors open and close at random across the floor.", Door = clockworkDoor };
                Room R69 = new Room { DescriptionType = "Ambience", RoomDescription = "You feel as if invisible eyes behind gears are watching.", Door = clockworkDoor };
                Room R70 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Disassembled automaton parts hang suspended from metal hooks.", Door = clockworkDoor };
                Room R71 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor softly vibrates beneath you with hidden machinery.", Door = clockworkDoor };
                Room R72 = new Room { DescriptionType = "Ambience", RoomDescription = "Distant, mechanical laughter echoes from unseen chambers.", Door = clockworkDoor };

                db.Doors.Add(clockworkDoor);
                db.Rooms.AddRange(new[] { R61, R62, R63, R64, R65, R66, R67, R68, R69, R70, R71, R72 });

                // VEIL DOOR
                Door veilDoor = new Door { DoorType = "Veil" };

                Room R73 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls that seem woven from mist and shadow.", Door = veilDoor };
                Room R74 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "You step onto clouds that barely support your weight.", Door = veilDoor };
                Room R75 = new Room { DescriptionType = "Ambience", RoomDescription = "Every noise you make sounds muffled and distant.", Door = veilDoor };
                Room R76 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Phantom figures move silently just out of sight.", Door = veilDoor };
                Room R77 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling above shifts like a stormy sky trapped indoors.", Door = veilDoor };
                Room R78 = new Room { DescriptionType = "Ambience", RoomDescription = "Chilling whispers circle you without ever growing closer.", Door = veilDoor };
                Room R79 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Curtains of darkness hang where doors should be.", Door = veilDoor };
                Room R80 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "A bottomless pit opens unexpectedly across the floor.", Door = veilDoor };
                Room R81 = new Room { DescriptionType = "Ambience", RoomDescription = "You feel you are being pulled slowly, unwillingly, in some unknown direction.", Door = veilDoor };
                Room R82 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Silvered mirrors reflect scenes from impossible places.", Door = veilDoor };
                Room R83 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor constantly shifts between solid and insubstantial.", Door = veilDoor };
                Room R84 = new Room { DescriptionType = "Ambience", RoomDescription = "Your shadow behaves independently from you.", Door = veilDoor };

                db.Doors.Add(veilDoor);
                db.Rooms.AddRange(new[] { R73, R74, R75, R76, R77, R78, R79, R80, R81, R82, R83, R84 });

                // BLOOD DOOR
                Door bloodDoor = new Door { DoorType = "Blood" };

                Room R85 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls of pulsing flesh, veins clearly visible and moving.", Door = bloodDoor };
                Room R86 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "A squelching, organic floor that reacts to your steps.", Door = bloodDoor };
                Room R87 = new Room { DescriptionType = "Ambience", RoomDescription = "A heartbeat echoes throughout, irregular and unsettling.", Door = bloodDoor };
                Room R88 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Tendrils sprout from the walls, twitching at your passing.", Door = bloodDoor };
                Room R89 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Mucus-like slime drips steadily from the ceiling.", Door = bloodDoor };
                Room R90 = new Room { DescriptionType = "Ambience", RoomDescription = "An unbearable thirst claws at your throat.", Door = bloodDoor };
                Room R91 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Mouths open and close along the walls, mouthing silent screams.", Door = bloodDoor };
                Room R92 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor occasionally spasms like a living being.", Door = bloodDoor };
                Room R93 = new Room { DescriptionType = "Ambience", RoomDescription = "The taste of iron fills your mouth even though you haven’t eaten.", Door = bloodDoor };
                Room R94 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Eyes embedded in the walls roll and blink independently.", Door = bloodDoor };
                Room R95 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling breathes slowly in and out.", Door = bloodDoor };
                Room R96 = new Room { DescriptionType = "Ambience", RoomDescription = "You feel your own heartbeat syncing with the building itself.", Door = bloodDoor };

                db.Doors.Add(bloodDoor);
                db.Rooms.AddRange(new[] { R85, R86, R87, R88, R89, R90, R91, R92, R93, R94, R95, R96 });

                // MIRROR DOOR
                Door mirrorDoor = new Door { DoorType = "Mirror" };

                Room R97 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls of flawless mirrors reflect endless versions of yourself.", Door = mirrorDoor };
                Room R98 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The mirrored floor shatters and reforms with every step.", Door = mirrorDoor };
                Room R99 = new Room { DescriptionType = "Ambience", RoomDescription = "You hear footsteps, but they’re not yours.", Door = mirrorDoor };
                Room R100 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Fragments of broken reflections swirl like leaves in a storm.", Door = mirrorDoor };
                Room R101 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling reflects a sky in eternal twilight.", Door = mirrorDoor };
                Room R102 = new Room { DescriptionType = "Ambience", RoomDescription = "Your reflection sometimes moves a moment too late — or too soon.", Door = mirrorDoor };
                Room R103 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Mirrored doors lead in all directions, some cracked and bleeding light.", Door = mirrorDoor };
                Room R104 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor splinters into new, disorienting angles.", Door = mirrorDoor };
                Room R105 = new Room { DescriptionType = "Ambience", RoomDescription = "You hear conversations you never had, whispered from the reflections.", Door = mirrorDoor };
                Room R106 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Inverted versions of yourself lurk just behind the mirrors.", Door = mirrorDoor };
                Room R107 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor flashes memories from your past with every step.", Door = mirrorDoor };
                Room R108 = new Room { DescriptionType = "Ambience", RoomDescription = "The reflections sometimes smile when you do not.", Door = mirrorDoor };

                db.Doors.Add(mirrorDoor);
                db.Rooms.AddRange(new[] { R97, R98, R99, R100, R101, R102, R103, R104, R105, R106, R107, R108 });


                // RUSTY DOOR
                Door rustyDoor = new Door { DoorType = "Rusty" };

                Room R109 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls corroded with layers of flaking rust.", Door = rustyDoor };
                Room R110 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor crunches underfoot with brittle, rusted debris.", Door = rustyDoor };
                Room R111 = new Room { DescriptionType = "Ambience", RoomDescription = "The air is thick with the acrid stench of oxidation.", Door = rustyDoor };
                Room R112 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Broken chains dangle from rust-eaten hooks.", Door = rustyDoor };
                Room R113 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling sags under the weight of corroded beams.", Door = rustyDoor };
                Room R114 = new Room { DescriptionType = "Ambience", RoomDescription = "Distant groaning noises come from collapsing metal.", Door = rustyDoor };
                Room R115 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Iron doors welded shut by decades of decay line the walls.", Door = rustyDoor };
                Room R116 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Pits of orange sludge bubble slowly across the floor.", Door = rustyDoor };
                Room R117 = new Room { DescriptionType = "Ambience", RoomDescription = "Every breath tastes of blood and metal.", Door = rustyDoor };
                Room R118 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Cracked tanks leak rusty liquid along the walls.", Door = rustyDoor };
                Room R119 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Rust flakes drift downward like diseased snow.", Door = rustyDoor };
                Room R120 = new Room { DescriptionType = "Ambience", RoomDescription = "You feel watched by unseen eyes behind broken vents.", Door = rustyDoor };

                db.Doors.Add(rustyDoor);
                db.Rooms.AddRange(new[] { R109, R110, R111, R112, R113, R114, R115, R116, R117, R118, R119, R120 });

                // GOLDEN DOOR
                Door goldenDoor = new Door { DoorType = "Golden" };

                Room R121 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls plated with brilliant, shimmering gold.", Door = goldenDoor };
                Room R122 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor shines like a polished coin.", Door = goldenDoor };
                Room R123 = new Room { DescriptionType = "Ambience", RoomDescription = "Soft chimes sound with every step you take.", Door = goldenDoor };
                Room R124 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Golden vines climb intricately up the walls.", Door = goldenDoor };
                Room R125 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling dazzles with embedded rubies and sapphires.", Door = goldenDoor };
                Room R126 = new Room { DescriptionType = "Ambience", RoomDescription = "The air hums with a sacred, holy vibration.", Door = goldenDoor };
                Room R127 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Statues of forgotten kings and queens stare down silently.", Door = goldenDoor };
                Room R128 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Golden dust swirls through shafts of warm light.", Door = goldenDoor };
                Room R129 = new Room { DescriptionType = "Ambience", RoomDescription = "Whispers of fortune and temptation fill your ears.", Door = goldenDoor };
                Room R130 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Gilded murals tell tales of lost civilizations.", Door = goldenDoor };
                Room R131 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Steps of pure gold lead up to unseen heights.", Door = goldenDoor };
                Room R132 = new Room { DescriptionType = "Ambience", RoomDescription = "The air is sweet with the scent of myrrh and honey.", Door = goldenDoor };

                db.Doors.Add(goldenDoor);
                db.Rooms.AddRange(new[] { R121, R122, R123, R124, R125, R126, R127, R128, R129, R130, R131, R132 });

                // ORNATE DOOR
                Door ornateDoor = new Door { DoorType = "Ornate" };

                Room R133 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls covered in intricate carvings and reliefs.", Door = ornateDoor };
                Room R134 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "A mosaic floor depicting strange celestial maps.", Door = ornateDoor };
                Room R135 = new Room { DescriptionType = "Ambience", RoomDescription = "A soft, angelic choir seems to echo just beyond hearing.", Door = ornateDoor };
                Room R136 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Tapestries depict battles between gods and monsters.", Door = ornateDoor };
                Room R137 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Vaulted ceilings studded with frescoes of forgotten saints.", Door = ornateDoor };
                Room R138 = new Room { DescriptionType = "Ambience", RoomDescription = "Every breath stirs motes of ancient dust from the air.", Door = ornateDoor };
                Room R139 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Jewelled sconces hold eternally burning candles.", Door = ornateDoor };
                Room R140 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor flexes underfoot, revealing hidden symbols.", Door = ornateDoor };
                Room R141 = new Room { DescriptionType = "Ambience", RoomDescription = "Faint harp music plays without visible source.", Door = ornateDoor };
                Room R142 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Elaborate thrones sit abandoned along the walls.", Door = ornateDoor };
                Room R143 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Stained glass windows throw kaleidoscopic patterns.", Door = ornateDoor };
                Room R144 = new Room { DescriptionType = "Ambience", RoomDescription = "The smell of old parchment and faded incense fills the air.", Door = ornateDoor };

                db.Doors.Add(ornateDoor);
                db.Rooms.AddRange(new[] { R133, R134, R135, R136, R137, R138, R139, R140, R141, R142, R143, R144 });

                // EMERALD DOOR
                Door emeraldDoor = new Door { DoorType = "Emerald" };

                Room R145 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls shimmer with embedded emerald veins.", Door = emeraldDoor };
                Room R146 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor pulses with a green, organic glow.", Door = emeraldDoor };
                Room R147 = new Room { DescriptionType = "Ambience", RoomDescription = "The scent of fresh moss fills your lungs.", Door = emeraldDoor };
                Room R148 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Vines slither along the walls, alive and watchful.", Door = emeraldDoor };
                Room R149 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Roots crack through the tiles underfoot.", Door = emeraldDoor };
                Room R150 = new Room { DescriptionType = "Ambience", RoomDescription = "A soft trickle of unseen water echoes everywhere.", Door = emeraldDoor };
                Room R151 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Carved stones portray ancient forests and beasts.", Door = emeraldDoor };
                Room R152 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Glowing spores drift lazily from cracks in the ceiling.", Door = emeraldDoor };
                Room R153 = new Room { DescriptionType = "Ambience", RoomDescription = "Your ears catch the sound of rustling leaves, though no wind blows.", Door = emeraldDoor };
                Room R154 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Murals of great trees with eyes seem to follow you.", Door = emeraldDoor };
                Room R155 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Patches of grass grow wildly between broken tiles.", Door = emeraldDoor };
                Room R156 = new Room { DescriptionType = "Ambience", RoomDescription = "It feels as if something ancient and green watches from the corners.", Door = emeraldDoor };

                db.Doors.Add(emeraldDoor);
                db.Rooms.AddRange(new[] { R145, R146, R147, R148, R149, R150, R151, R152, R153, R154, R155, R156 });

                // CHARRED DOOR
                Door charredDoor = new Door { DoorType = "Charred" };

                Room R157 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls blackened and cracked by ancient fire.", Door = charredDoor };
                Room R158 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Ash piles swirl across the scorched floor.", Door = charredDoor };
                Room R159 = new Room { DescriptionType = "Ambience", RoomDescription = "The smell of burnt flesh lingers heavily.", Door = charredDoor };
                Room R160 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Charcoal drawings of screaming figures line the walls.", Door = charredDoor };
                Room R161 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling above is fractured and soot-stained.", Door = charredDoor };
                Room R162 = new Room { DescriptionType = "Ambience", RoomDescription = "Occasional bursts of heat still ripple through the air.", Door = charredDoor };
                Room R163 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Melted remnants of furniture cling to the walls.", Door = charredDoor };
                Room R164 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Sections of the floor still smolder faintly.", Door = charredDoor };
                Room R165 = new Room { DescriptionType = "Ambience", RoomDescription = "Distant crackling noises hint at fires long gone.", Door = charredDoor };
                Room R166 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls scarred with the outlines of vanished objects.", Door = charredDoor };
                Room R167 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ground is brittle underfoot, breaking at the slightest touch.", Door = charredDoor };
                Room R168 = new Room { DescriptionType = "Ambience", RoomDescription = "The temperature shifts violently between freezing and boiling.", Door = charredDoor };

                db.Doors.Add(charredDoor);
                db.Rooms.AddRange(new[] { R157, R158, R159, R160, R161, R162, R163, R164, R165, R166, R167, R168 });

                // BRONZE DOOR
                Door bronzeDoor = new Door { DoorType = "Bronze" };

                Room R169 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls are layered in oxidized bronze panels.", Door = bronzeDoor };
                Room R170 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Bronze tiles form a cracked, tarnished mosaic underfoot.", Door = bronzeDoor };
                Room R171 = new Room { DescriptionType = "Ambience", RoomDescription = "The air is heavy and metallic, almost oily.", Door = bronzeDoor };
                Room R172 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Green corrosion blooms across bronze statues.", Door = bronzeDoor };
                Room R173 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Crumbled sections expose dark, unfinished stone.", Door = bronzeDoor };
                Room R174 = new Room { DescriptionType = "Ambience", RoomDescription = "The faint creak of shifting metal echoes softly.", Door = bronzeDoor };
                Room R175 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Reliefs of forgotten battles warp across the walls.", Door = bronzeDoor };
                Room R176 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling groans under its own oxidized weight.", Door = bronzeDoor };
                Room R177 = new Room { DescriptionType = "Ambience", RoomDescription = "Everything feels weighed down, slow, inevitable.", Door = bronzeDoor };
                Room R178 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Brass gears and rusted mechanisms jut out of the walls.", Door = bronzeDoor };
                Room R179 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Pools of verdigris collect in sagging depressions.", Door = bronzeDoor };
                Room R180 = new Room { DescriptionType = "Ambience", RoomDescription = "It feels like you’re inside a colossal, dying machine.", Door = bronzeDoor };

                db.Doors.Add(bronzeDoor);
                db.Rooms.AddRange(new[] { R169, R170, R171, R172, R173, R174, R175, R176, R177, R178, R179, R180 });

                // RUNIC DOOR
                Door runicDoor = new Door { DoorType = "Runic" };

                Room R181 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Walls are etched with glowing runes, their meanings lost to time.", Door = runicDoor };
                Room R182 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "Runes are carved into the stone floor, glowing faintly.", Door = runicDoor };
                Room R183 = new Room { DescriptionType = "Ambience", RoomDescription = "The air hums with an ancient, forgotten language.", Door = runicDoor };
                Room R184 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Ancient scrolls and relics are suspended in the walls, trapped by the runes.", Door = runicDoor };
                Room R185 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor shifts subtly, as if the runes beneath it are alive.", Door = runicDoor };
                Room R186 = new Room { DescriptionType = "Ambience", RoomDescription = "An eerie, otherworldly whisper echoes faintly in the room.", Door = runicDoor };
                Room R187 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Stone pillars covered in runic symbols rise from the corners of the room.", Door = runicDoor };
                Room R188 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling is adorned with runic carvings that seem to move in the shadows.", Door = runicDoor };
                Room R189 = new Room { DescriptionType = "Ambience", RoomDescription = "The room pulses with the energy of ancient magic.", Door = runicDoor };
                Room R190 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Stone tablets inscribed with runes are scattered throughout the room.", Door = runicDoor };
                Room R191 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is cold and smooth, with symbols etched deep into the stone.", Door = runicDoor };
                Room R192 = new Room { DescriptionType = "Ambience", RoomDescription = "A feeling of being watched lingers, as if the runes are aware of your presence.", Door = runicDoor };

                db.Doors.Add(runicDoor);
                db.Rooms.AddRange(new[] { R181, R182, R183, R184, R185, R186, R187, R188, R189, R190, R191, R192 });

                // ELDRITCH DOOR
                Door eldritchDoor = new Door { DoorType = "Eldritch" };

                Room R193 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls are constantly shifting, covered in strange, unrecognizable symbols.", Door = eldritchDoor };
                Room R194 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor ripples like water, as if the ground itself is alive.", Door = eldritchDoor };
                Room R195 = new Room { DescriptionType = "Ambience", RoomDescription = "A low, disturbing hum vibrates through the room, like the pulse of some dark force.", Door = eldritchDoor };
                Room R196 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls seem to bleed shadows, dark tendrils snaking out from unseen cracks.", Door = eldritchDoor };
                Room R197 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The ceiling seems to open into an infinite void, darkness swirling with glimpses of otherworldly landscapes.", Door = eldritchDoor };
                Room R198 = new Room { DescriptionType = "Ambience", RoomDescription = "The air smells like decay and something worse, as if something ancient stirs in the depths.", Door = eldritchDoor };
                Room R199 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "Flesh-like tendrils stretch across the walls, twisting and pulsating.", Door = eldritchDoor };
                Room R200 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor appears to be covered in a sickly, writhing mass of strange, organic material.", Door = eldritchDoor };
                Room R201 = new Room { DescriptionType = "Ambience", RoomDescription = "An overwhelming sense of dread fills the room, making it feel as if you are not alone.", Door = eldritchDoor };
                Room R202 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls warp and bend as if reality itself is unraveling.", Door = eldritchDoor };
                Room R203 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor pulsates with an unnatural rhythm, as if it is breathing.", Door = eldritchDoor };

                db.Doors.Add(eldritchDoor);
                db.Rooms.AddRange(new[] { R193, R194, R195, R196, R197, R198, R199, R200, R201, R202, R203 });

                // ABYSSAL DOOR
                Door abyssalDoor = new Door { DoorType = "Abyssal" };

                Room R228 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls are black and slick, covered in strange, ever-shifting patterns that seem to pulsate with a life of their own. The floor is uneven, shifting beneath your feet.", Door = abyssalDoor };
                Room R229 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor seems to stretch endlessly into the distance, made of dark stone that absorbs light. The ceiling is a vast, oppressive void, swirling with the unknown.", Door = abyssalDoor };
                Room R230 = new Room { DescriptionType = "Ambience", RoomDescription = "The air feels thin, as though it’s being drained from the room. A deep, resonant hum echoes, vibrating through your bones, as if something ancient stirs in the dark.", Door = abyssalDoor };
                Room R231 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "An altar of unknown material sits in the center of the room, covered in strange, glowing symbols. The walls seem to bend away from it, as though they fear its presence.", Door = abyssalDoor };
                Room R232 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor feels unnaturally cold and slick, like ice, while the ceiling looms overhead, dark and featureless, as if suspended in an eternal night.", Door = abyssalDoor };
                Room R233 = new Room { DescriptionType = "Ambience", RoomDescription = "A cold breeze stirs the room, though there are no apparent openings. The silence is profound, broken only by the occasional distant echo of something moving.", Door = abyssalDoor };
                Room R234 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls seem to stretch and ripple, as though they are being pulled by some unseen force. Ancient glyphs appear and vanish in an instant.", Door = abyssalDoor };
                Room R235 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is unnaturally smooth, with strange markings etched into its surface. The ceiling appears to be made of swirling shadows that shift constantly.", Door = abyssalDoor };
                Room R236 = new Room { DescriptionType = "Ambience", RoomDescription = "An eerie, whispering voice seems to come from the darkness, but when you strain to listen, it’s gone. The temperature fluctuates wildly from freezing to oppressively hot.", Door = abyssalDoor };
                Room R237 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "A pulsating, fleshy substance covers the walls, oozing with a dark, viscous liquid. The room feels alive, as though it breathes in rhythm with the heartbeat of some ancient entity.", Door = abyssalDoor };
                Room R238 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is cracked, with black veins running through it, as if the room itself is bleeding. The ceiling hangs like a blackened dome, seeming to press closer with every breath.", Door = abyssalDoor };
                Room R239 = new Room { DescriptionType = "Ambience", RoomDescription = "There is a faint, oppressive weight in the air, as though something intangible is watching you from the dark. The room feels claustrophobic, suffocating even.", Door = abyssalDoor };

                db.Doors.Add(abyssalDoor);
                db.Rooms.AddRange(new[] { R228, R229, R230, R231, R232, R233, R234, R235, R236, R237, R238, R239 });


                // VOID DOOR
                Door voidDoor = new Door { DoorType = "Void" };

                Room R240 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls appear to shift in and out of focus, as if they are not fully part of this reality. The room constantly seems to stretch and shrink, warping with each glance.", Door = voidDoor };
                Room R241 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor seems to flicker, revealing glimpses of nothingness beneath. The ceiling is a swirling vortex of void, where the air itself seems to bend and distort.", Door = voidDoor };
                Room R242 = new Room { DescriptionType = "Ambience", RoomDescription = "An overwhelming silence envelops the room, broken only by the occasional warping noise, as though the very fabric of reality is being torn apart.", Door = voidDoor };
                Room R243 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls pulse with shifting, impossible geometry, each turn and angle leading to places that should not exist. Objects within the room flicker in and out of view.", Door = voidDoor };
                Room R244 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor appears to ripple like liquid, reflecting twisted versions of yourself as you move. The ceiling above seems to be a mirror of the floor, distorted and incomplete.", Door = voidDoor };
                Room R245 = new Room { DescriptionType = "Ambience", RoomDescription = "There is an oppressive sensation that time no longer functions properly here. Every second stretches endlessly, while memories seem to fade the longer you linger.", Door = voidDoor };
                Room R246 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "A strange, unnatural glow emanates from the walls, casting long, twisted shadows that seem to move of their own accord. The floor beneath you feels unstable.", Door = voidDoor };
                Room R247 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is broken into a million shards of glass, each shard a reflection of a twisted version of the room. The ceiling constantly shifts, never remaining in one place for long.", Door = voidDoor };
                Room R248 = new Room { DescriptionType = "Ambience", RoomDescription = "The air is thin and unnatural, as if it has been pulled from a place where life cannot exist. The room is suffused with a strange vibration, as if the space itself is alive.", Door = voidDoor };
                Room R249 = new Room { DescriptionType = "WallsAndItems", RoomDescription = "The walls are cracked and broken, but where the cracks appear, a swirling black void can be seen, beckoning you with an unsettling allure.", Door = voidDoor };
                Room R250 = new Room { DescriptionType = "FloorAndCeiling", RoomDescription = "The floor is uneven, with rips and tears in its surface revealing endless, swirling darkness. The ceiling above appears to crumble into a chaotic mass of ever-changing matter.", Door = voidDoor };
                Room R251 = new Room { DescriptionType = "Ambience", RoomDescription = "An unnatural chill fills the room, like the coldness of space itself. Strange sounds reverberate, as if countless whispers are being carried from a far-off dimension.", Door = voidDoor };

                db.Doors.Add(voidDoor);
                db.Rooms.AddRange(new[] { R240, R241, R242, R243, R244, R245, R246, R247, R248, R249, R250, R251 });


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