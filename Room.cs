#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ConsoleApp1.Item> inventory = new List<ConsoleApp1.Item>();

        public void Drop(ConsoleApp1.Item item)
        {
            inventory.Remove(item);
        }


        public Room(string name, string description, List<Item> inventory, Room? moveNorth, Room? moveSouth, Room? moveEast, Room? moveWest, Room? moveUp, Room? moveDown)
        {
            Name = name;
            Description = description;
            this.inventory = inventory;
            MoveNorth = moveNorth;
            MoveSouth = moveSouth;
            MoveEast = moveEast;
            MoveWest = moveWest;
            MoveUp = moveUp;
            MoveDown = moveDown;
        }

        public Room? MoveNorth { get; set; }
        public Room? MoveSouth { get; set; }
        public Room? MoveEast { get; set; }
        public Room? MoveWest { get; set; }

        public Room? MoveUp { get; set; }
        public Room? MoveDown { get; set; }
    }
}
