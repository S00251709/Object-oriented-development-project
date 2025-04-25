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

            using(db)
            {
                Room R1 = new Room() {Id=1,DescriptionType="",RoomDescription="" };


                db.Rooms.Add(R1);

                Console.WriteLine("Added room");
                
                db.SaveChanges();

                Console.WriteLine("saved changes");
            }

        }
    }
}
