using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
       // IEnumerable<Product> GetProducts(); ?
        Product GetProductByID(int product_id);

        void AddProduct(Product p);

        void AddPrice();

        void AddCategory(Category c);
    }
}
