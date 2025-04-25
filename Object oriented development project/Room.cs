using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_development_project
{
    public class Room
    {
        public int Id { get; set; }
        public string DescriptionType { get; set; }
        public string RoomDescription { get; set; }

        public Door door { get; set; }
    }
    public class Door
    {
        public string DoorType { get; set; } //store the door chosen to determine rooms description

        public List<Room> Rooms { get; set; }
    }

    public class RoomData : DbContext
    {
        public RoomData() : base("MyGameRooms") { }
        public DbSet<Room> Rooms { get; set; }
    }
}
