using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public interface IOrderRepository
    {
        void viewOrder();
        void cancelOrder(int OrderId);
        void UpdateOrder();
        void CalculatePrice(int Price);
    }
}
