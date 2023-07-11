using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenericDemo
{
    public class Product
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class ProductCRUD
    {
        private List<Product> products;
        public ProductCRUD()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product Pro)//Add Products
        {
            products.Add(Pro);
        }

        public List<Product> GetProducts()//Display Products
        {
            return products;
        }

        public void UpdateProduct(Product Pro)//Update Products
        {
            foreach(Product p in products)
            {
                if (p.Id == Pro.Id)
                {
                    //odd data
                    p.Name = Pro.Name;
                    p.Price = Pro.Price;
                    break;
                }
            }
        }

        public void DeleteProduct(int id)
        {
            foreach (Product p in products)
            {
                if(p.Id==id)
                {
                    products.Remove(p);
                    break;
                }
            }
        }




       
    }
}
