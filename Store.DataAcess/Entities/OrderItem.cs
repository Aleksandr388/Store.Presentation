﻿using Shared.Enums;
using Store.DataAcess.Entities.Base;


namespace Store.DataAcess.Entities
{
    public class OrderItem : BaseEntity
    {
        public decimal Amount { get; set; }
        public int Count { get; set; }
        public Curency Curency { get; set; }

        public long PrintingEditionId { get; set; }
        public virtual PrintingEdition PrintingEdition { get; set; }

        public long OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
