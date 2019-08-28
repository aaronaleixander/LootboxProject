using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootBoxProject
{
    public class LootboxClass
    {
        // Default no arg constructor
        public LootboxClass()
        { }
        public LootboxClass(int id,string theme, string name, string contents, string description, double price)
        {
            LootboxID = id;
            Theme = theme;
            Name = name;
            Contents = contents;
            Description = description;
            Price = price;
        }

        public int LootboxID { get; set; }
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
