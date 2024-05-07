using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Brittany_wguC968
{

    public class Inventory
    {
        public static BindingList<Product> Products { get; } = new BindingList<Product>();
        public static BindingList<Product> ProductList { get { return Products; } }
        public static BindingList<Part> AllParts { get; } = new BindingList<Part>();
        public static BindingList<Part> PartsList { get {return AllParts; }}
        Main mainForm = Application.OpenForms.OfType<Main>().FirstOrDefault();
  
        public static void sampleParts()
        {
            
            Part example1 = new InHouse { PartID = 1, Name = "Wheel", InStock = 15, Price = 12.11m, Min = 5, Max = 25, MachineID = 5454 };
            Part example2 = new InHouse { PartID = 2, Name = "Pedal", InStock = 11, Price = 8.22m, Min = 5, Max=25, MachineID= 1234};
            Part example3 = new InHouse { PartID = 3, Name = "Cochain", InStock = 12, Price = 8.33m, Min = 5, Max = 25, MachineID = 5678 };
            Part example4 = new InHouse { PartID = 4, Name = "Seat", InStock = 8, Price = 4.55m, Min = 2, Max = 15, MachineID = 9876 };
            AddPart(example1);
            AddPart(example2);
            AddPart(example3);
            AddPart(example4);
        }
        public static void sampleProducts()
        {
            Product example5 = new Product { ProductID = 1, Name = "Red Bicycle", InStock = 15, Price = 11.44m, Min = 1, Max = 25 };
            Product example6 = new Product { ProductID = 2, Name = "Yellow Bicycle", InStock = 19, Price = 9.66m, Min = 1, Max = 20 };
            Product example7 = new Product { ProductID = 3, Name = "Blue Bicycle", InStock = 5, Price = 12.77m, Min = 1, Max = 25 };
            AddProduct(example5);
            AddProduct(example6);
            AddProduct(example7);
        }
        private static int nextPartID;
        public static int GeneratePartID()
        {
            if(AllParts.Count > 0)
            {
                int maxPartID = AllParts.Max(part => part.PartID);
                nextPartID = maxPartID + 1;
            }
            else
            {
                nextPartID = 1;
            }

            return nextPartID;
        }

        public static bool RemoveProduct(int productID)
        {
            Product productToRemove = null;
            foreach (var product in Products)
            {
                if (product.ProductID == productID)
                {
                    productToRemove = product;
                    break;
                }
            }
            return productToRemove != null && Products.Remove(productToRemove);
        }


        public static Product LookupProduct(int productID)
        {
            foreach (var product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }
        public static void UpdateProduct(int productID, Product newProduct)
        {
            var productToUpdate = LookupProduct(productID);
            if (productToUpdate != null)
            {
                productToUpdate.Name = newProduct.Name;
                productToUpdate.Price = newProduct.Price;
            }
        }
        public static void AddPart(Part part)
        {
            var existingPart = AllParts.FirstOrDefault(p => p.PartID == part.PartID);
            if (existingPart != null)
            {
                AllParts.Add(part);
                //throw new InvalidOperationException("A part with the same PartID already exists");
            }
            else
            {
                int newPartID = GeneratePartID();
                part.PartID = newPartID;
                AllParts.Add(part);
                
            }
 
        }
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public static bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }
        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID) return part;
            }
            Part emptyPart = new InHouse();
            return emptyPart;
        }
        public static void UpdatePart(Part oldPart, Part updatedPart)
        {
           DeletePart(oldPart);
           AddPart(updatedPart);


           mainForm.PopulateDataGridViews();
        }


    }
}
