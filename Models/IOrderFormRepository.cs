﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public interface IOrderFormRepository
    {
        void CreateOrderForm ( OrderForm orderForm );
    }
}
