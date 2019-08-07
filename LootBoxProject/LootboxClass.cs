using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootBoxProject
{
    class LootboxClass
    {
        // Default no arg constructor
        public LootboxClass()
        { }
        public LootboxClass(string theme, string name, string contents, string description, double price)
        {
            Theme = theme;
            Name = name;
            Contents = contents;
            Description = description;
            Price = price;
        }

        public string Theme { get; set; }
        public string Name { get; set; }
        public string Contents { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
