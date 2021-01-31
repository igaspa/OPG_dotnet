using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace OPG.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _appDbContext.Product.Include(c => c.Category );
            }
        }

        public void AddCategory(Category c)
        {
            _appDbContext.Category.Add(c);
            _appDbContext.SaveChanges();
        }

        public void AddPrice()
        {
           
         }

        public void AddProduct(Product p)
        {

         _appDbContext.Product.Add(p);
         _appDbContext.SaveChanges();

        }

        public Product GetProductByID ( int product_id )
        {
            return _appDbContext.Product.FirstOrDefault ( p => p.ProductId == product_id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return AllProducts;
        }


    }
}
