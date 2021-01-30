﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Product GetProductByID ( int Product_Id )
        {
            return _appDbContext.Product.FirstOrDefault ( p => p.ProductId == Product_Id);
        }
    }
}
