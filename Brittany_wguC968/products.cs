using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brittany_wguC968
{
    public class Product
    {
        public BindingList<Part>? AssociatedParts { get; } =
        new BindingList<Part>();

        private int productID;
        private string name;
        private decimal price;
        private int Instock;
        private int min;
        private int max;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        

        public Product() { }
     
        public Product(string productName, int inStock, decimal price, int min, int max)
        {
            Name = productName;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part) => AssociatedParts.Add(part);
        public bool RemoveAssociatedPart(Part part) =>  AssociatedParts.Remove(part);
        
        public Part LookupAssociatedPart(int partID)
        {
            foreach (var part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
