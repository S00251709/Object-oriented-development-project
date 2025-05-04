using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_development_project
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DescriptionType { get; set; }

        [Required]
        public string RoomDescription { get; set; }

        public int DoorId { get; set; }

        [ForeignKey("DoorId")]
        public virtual Door Door { get; set; }
    }

    public class Door
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DoorType { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }

    public class RoomData : DbContext
    {
        public RoomData() : base("MyGameRooms") { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Door> Doors { get; set; }
    }
}