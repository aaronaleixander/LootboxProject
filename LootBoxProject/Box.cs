using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootBoxProject
{
    class Box
    {
        // theme/tag of the lootbox
        public string LootboxTheme { get; set; }

        // Title/Name of the box
        public string LootboxName { get; set; }

        // ???
        public string LootboxContents { get; set; }

        // A description explaining the consept an contents of the lootbox
        public string LootboxDescription { get; set; }

        // The stock price of the lootbox
        // DO NOT CHANGE FOR sales, discounts, or limited time offers
        public double LootboxPrice { get; set; }
    }
}
