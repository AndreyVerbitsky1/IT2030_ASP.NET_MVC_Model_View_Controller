using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class OrderCartRemoveViewModel
    {
        public int DeleteId;

        public decimal CartTotal;

        public int ItemCount;

        public string Message;
    }
}