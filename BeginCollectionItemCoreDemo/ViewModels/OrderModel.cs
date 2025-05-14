﻿using System;
using System.Collections.Generic;

namespace BeginCollectionItemCoreDemo.ViewModels;

public class OrderModel
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTimeOffset OrderDateTime { get; set; }
    public List<OrderItemModel> OrderItems { get; set; } = new List<OrderItemModel>();
    public string Message { get; set; }

}
