using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_development_project
{
    public class Player
    {
        public int Health { get; set; } = 100;
        public int Score { get; set; } = 0;
        public List<string> Inventory { get; set; } = new List<string>();

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Health = 0;
                // Trigger Game Over
            }
        }

        public void AddItem(string item) => Inventory.Add(item);
    }
}
