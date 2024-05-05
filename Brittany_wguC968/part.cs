using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brittany_wguC968
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private decimal price;
        private int Instock;
        private int min;
        private int max;

        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
