using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProject
{
    public interface IProductService
    {
        public void Create(Product product);
        public Product Get(int id);
        public List<Product> GetAll();
        public void Delete(int id);
    }
}
