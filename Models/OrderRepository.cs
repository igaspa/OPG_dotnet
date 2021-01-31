using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        public OrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void CalculatePrice(int Price)
        {
            throw new NotImplementedException();
        }

        public void cancelOrder(int OrderId)
        {
            _appDbContext.Order.RemoveRange();
            _appDbContext.SaveChanges();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }

        public void viewOrder()
        {
            throw new NotImplementedException();
            
        }
    }
}

