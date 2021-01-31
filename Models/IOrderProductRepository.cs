using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public interface IOrderProductRepository
    {
        void AddProduct(Product p);
        void RemoveProduct(int ProductId);
        void CalculatePrice(int Price);
        public Product FindById(int ProductId);

    }
}
