using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBinaryTree
{
    public class Character
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }

        public Character(string name, int power, int speed)
        {
            Name = name;
            Power = power;
            Speed = speed;
        }

        public override string ToString()
        {
            return $"{Name} (Power: {Power}, Speed: {Speed})";
        }
    }

}
