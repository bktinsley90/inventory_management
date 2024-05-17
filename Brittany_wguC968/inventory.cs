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
        //this is used in seach
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
        private static int nextProductID;
        public static int GenerateProductID()
        {
            if (Products.Count > 0)
            {
                int maxProductID = Products.Max(product => product.ProductID);
                nextProductID = maxProductID + 1;
            }
            else
            {
                nextProductID = 1;
            }

            return nextProductID;
        }
        public static void AddProduct(Product product)
        {
            if (product.ProductID > 0)
            {
                Products.Add(product);
                
            }
            else
            {
                int newProductID = GenerateProductID();
                product.ProductID = newProductID;
                Products.Add(product);

            }
            var sortedProducts = Products.OrderBy(product => product.ProductID).ToList();
            Products.Clear();
            foreach (var p in sortedProducts)
            {
                Products.Add(p);
            }
        }
        public static bool RemoveProduct(Product product)
        {
          return Products.Remove(product);
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
        public static void UpdateProduct(Main mainForm,Product oldProduct, Product updatedProduct)
        {
            RemoveProduct(oldProduct);
            AddProduct(updatedProduct);

            mainForm.PopulateDataGridViews();
        }
        public static void AddPart(Part part)
        {
            
            if (part.PartID > 0)
            {
                AllParts.Add(part);
                
            }
            else
            {
                int newPartID = GeneratePartID();
                part.PartID = newPartID;
                AllParts.Add(part);
                
            }
            var sortedParts = AllParts.OrderBy(part => part.PartID).ToList();
            AllParts.Clear();
            foreach (var p in sortedParts)
            {
                AllParts.Add(p);
            }
 
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
        public static void UpdatePart(Main mainForm, Part oldPart, Part updatedPart)
        {
           DeletePart(oldPart);
           AddPart(updatedPart);


           mainForm.PopulateDataGridViews();
        }


    }
}
