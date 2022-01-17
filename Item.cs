using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Item
    {
        public Item(string name, string description) 
        {
            Description = description;
            Name = name;
        }

        public string Name { get; set; }
        public string Description { get; set; }

    }
}
