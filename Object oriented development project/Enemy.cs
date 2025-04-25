using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_development_project
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; } = 50;
        public int AttackPower { get; set; } = 10;

        public int Attack() => AttackPower;
    }
}
