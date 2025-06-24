using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository
    {
        public Product Retrieve(int id)
        {
            foreach (Product p in CustomerData.Products)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return null!;
        }

        public List<Product> RetrieveByName(string name)
        {
            List<Product> ret = new List<Product>();

            foreach (Product p in CustomerData.Products)
            {
                if (p.Name!.ToLower().Contains(name.ToLower()))
                    ret.Add(p);

                return ret;
            }
            return null!;
        }

        public List<Product> RetrieveAll()
        {
            return CustomerData.Products;
        }

        public void Save(Product product)
        {
            product.Id = GetCount() + 1;
            CustomerData.Products.Add(product);
        }

        public bool Delete(Product product)
        {
            return CustomerData.Products.Remove(product);
        }

        public bool DeleteById(int Id)
        {
            Product product = Retrieve(Id);

            if (product != null)
                return Delete(product);

            return false;
        }

        public int GetCount()
        {
            return CustomerData.Customers.Count;
        }
    }
}

