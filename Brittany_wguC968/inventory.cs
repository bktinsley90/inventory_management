using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brittany_wguC968
{

    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
    public class Inhouse : Part
    {
        public int MachineID { get; set; }
    }
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }
    }
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part>? AssociatedParts { get; }
        new BindingList<Part>? NewStruct;

        public void AddAssociatedPart(Part part) => AssociatedParts.Add(part);
        public bool RemoveAssociatedPart(int partID)
        {
            Part partToRemove = null;
            foreach(var part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    partToRemove = part;
                    break;
                }
            }
            return partToRemove != null && AssociatedParts.Remove(partToRemove);
        }
        public Part LookupAssociatedPart(int partID)
        {
            foreach(var part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }
    public class Inventory
    {
        public BindingList<Product> Products { get; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; } = new BindingList<Part>();
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public bool RemoveProduct(int productID)
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


        public Product LookupProduct(int productID)
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
        public void UpdateProduct(int productID, Product newProduct)
        {
            var productToUpdate = LookupProduct(productID);
            if (productToUpdate != null)
            {
                productToUpdate.Name = newProduct.Name;
                productToUpdate.Price = newProduct.Price;
            }
        }
        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }
        public bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }
        public Part LookupPart(int partID)
        {
            foreach (var part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
        public void UpdatePart(int partID, Part newPart)
        {
            var partToUpdate = LookupPart(partID);
            if (partToUpdate != null)
            {
                partToUpdate.Name = newPart.Name;
                partToUpdate.Price = newPart.Price;
            }
        }

        internal void AddPart(Main.Part part)
        {
            throw new NotImplementedException();
        }

        internal record struct NewStruct(object Item1, object Item2)
        {
            public static implicit operator (object, object)(NewStruct value)
            {
                return (value.Item1, value.Item2);
            }

            public static implicit operator NewStruct((object, object) value)
            {
                return new NewStruct(value.Item1, value.Item2);
            }
        }
    }
}
