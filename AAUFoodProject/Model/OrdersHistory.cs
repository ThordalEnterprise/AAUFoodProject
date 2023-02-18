﻿using System;
using System.Collections.Generic;

namespace AAUFoodProject.Model
{

    public class OrdersHistory : List<OrderDetails>
        {
            public string OrderId { get; set; }
            public string Username { get; set; }
            public decimal TotalCost { get; set; }
        }

}
