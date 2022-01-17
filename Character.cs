using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Character
    {
        public string Name { get; set; }
        public List<ConsoleApp1.Item> inventory = new List<ConsoleApp1.Item>();

        public void PickUp(ConsoleApp1.Item item)
        {
           inventory.Add(item);
        }

        public ConsoleApp1.Room Location { get; set; }
        public string Move(string Direction)
        {
            if (Direction == "north")
            {
                if (Location.MoveNorth != null)
                {
                    Location = Location.MoveNorth;
                    return "You walk north.";
                }
                else
                {
                    return "You can not go this way.";
                }
            }
            if (Direction == "south")
            {
                if (Location.MoveSouth !=null)
                {
                    Location = Location.MoveSouth;
                    return "You walk south.";
                }
                else
                {
                    return "You can not go this way.";
                }
            }
            if (Direction == "east")
            {
                if (Location.MoveEast != null)
                {
                    Location = Location.MoveEast;
                    return "You move east.";
                }
                else
                {
                    return "You can not go this way.";
                }
            }
            if (Direction == "west")
            {
                if (Location.MoveWest != null)
                {
                    Location = Location.MoveWest;
                    return "You move west.";
                }
                else
                {
                    return "You can not go this way.";
                }
            }
            if (Direction == "up")
            {
                if (Location.MoveUp != null)
                {
                    Location = Location.MoveUp;
                    return "You climb up.";
                }
                else
                {
                    return "You can not go this way.";
                }
            }
            {
                if (Location.MoveDown != null)
                {
                    Location = Location.MoveDown;
                    return "You climb down.";
                }
                else
                {
                    return "You can not go this way.";
                }
            }
        }
    }
}
