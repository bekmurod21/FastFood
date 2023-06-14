﻿using FastFood.Domain.Commons;
using FastFood.Domain.Entities.Commons;
using FastFood.Domain.Entities.Orders;
using FastFood.Domain.Entities.Users;
using FastFood.Domain.Enums;

namespace FastFood.Domain.Entities.Payment
{
    public class Payment : Auditable
    {
        public decimal? Amount { get; set; }
        public string Description { get; set; }
        public PaymentStatus Status { get; set; }
        public bool IsAdmin { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public long OrderId { get; set; }
        public Order Order { get; set; }
    }
}