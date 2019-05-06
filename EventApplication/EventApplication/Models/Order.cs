using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class Order
    {
        [Key]
        public int EventOrderId { get; set; }

        public string OrderId { get; set; }

        public virtual int EventId { get; set; }

        public virtual Event EventSelected { get; set; }

        public int Tickets { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }

    }
}