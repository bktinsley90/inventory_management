using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brittany_wguC968
{
    public class Outsourced : Part
    {
        private string companyName;
        public string CompanyName { get; set; }
        public Outsourced() { }
        public Outsourced(int partID, string name, int instock, decimal price, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            InStock = instock;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = companyName;
        }
    }
}
