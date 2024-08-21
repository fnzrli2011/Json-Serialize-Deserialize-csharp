using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonProject
{
    public class ProductService : IProductService
    {

        public void Create(Product product)
        {
            string JsProduct = JsonSerializer.Serialize(product);
            using(StreamWriter sw = new StreamWriter("C:\\Users\\fnzrli109\\Desktop\\Lessons\\C#\\Json\\Data\\data.txt",true))
            {
                sw.WriteLine(JsProduct);
            }
        }

        public void Delete(int id)
        {
            string[] allproducts = File.ReadAllLines("C:\\Users\\fnzrli109\\Desktop\\Lessons\\C#\\Json\\Data\\data.txt");
            Product? product = null;
            List<string> newJsProduct = new List<string>();

            foreach (var item in allproducts)
            {
                product = JsonSerializer.Deserialize<Product>(item);
                if (product != null) 
                {
                    if (product.id == id)
                    {
                        newJsProduct.Add(item);
                    }
                }
            }
            File.WriteAllLines("C:\\Users\\fnzrli109\\Desktop\\Lessons\\C#\\Json\\Data\\data.txt",newJsProduct);
        }

        public Product? Get(int id)
        {
            string[] allproducts = File.ReadAllLines("C:\\Users\\fnzrli109\\Desktop\\Lessons\\C#\\Json\\Data\\data.txt");
            Product? product = null;
            foreach (var item in allproducts)
            {
                product = JsonSerializer.Deserialize<Product>(item);
                if (product != null)
                {
                    if (product.id == id)
                    {
                        return product;
                    }
                }
            }
            return null;
        }

        public List<Product> GetAll()
        {
            string[] allproducts = File.ReadAllLines("C:\\Users\\fnzrli109\\Desktop\\Lessons\\C#\\Json\\Data\\data.txt");
            List<Product> JsProduct = new List<Product>();

            foreach (var item in allproducts)
            {
                Product? product = JsonSerializer.Deserialize<Product>(item);
                if(product != null)
                {
                    JsProduct.Add(product);
                }
            }
            return JsProduct;
        }
    }
}
