using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class OrderCart
    {
        public string OrderCartId;

        private DBContext db = new DBContext();

        public static OrderCart GetOrder(HttpContextBase context)
        {
            OrderCart order = new OrderCart();
            order.OrderCartId = order.GetOrderId(context);
            return order;
        }

        private string GetOrderId(HttpContextBase context)
        {
            const string OrderSessionId = "OrderId";

            string orderId;

            if (context.Session[OrderSessionId] == null)
            {

                //Create a new order id
                orderId = Guid.NewGuid().ToString();

                //Save to the session date.
                context.Session[OrderSessionId] = orderId;
            }
            else
            {

                //Return existing order id
                orderId = context.Session[OrderSessionId].ToString();
            }

            return orderId;

        }


        public List<Order> GetOrderItems()
        {
            return db.Orders.Where(c => c.OrderId == this.OrderCartId).ToList();
        }

        public void AddToOrder(int albumId)
        {
            //TODO: Verify order ID exists in the database
            Order orderItem = db.Orders.SingleOrDefault(c => c.OrderId == this.OrderCartId && c.EventId == albumId);


            if (orderItem == null)
            {
                // Item not in order; add new order item
                orderItem = new Order()
                {
                    OrderId = this.OrderCartId,
                    EventId = albumId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };

                db.Orders.Add(orderItem);
            }
            else
            {
                // item is already; increase item count
                orderItem.Count++;
            }

            db.SaveChanges();
        }

        public int RemoveFromOrder(int recordId)
        {
            Order orderItem = db.Orders.SingleOrDefault(c => c.OrderId == this.OrderCartId && c.EventOrderId == recordId);

            if (orderItem == null)
            {
                throw new NullReferenceException();
            }

            int newCount;

            if (orderItem.Count > 1)
            {
                //The count > 1; decrement count
                orderItem.Count--;
                newCount = orderItem.Count;
            }
            else
            {
                //The count <= 0; remove order item
                db.Orders.Remove(orderItem);
                newCount = 0;
            }

            db.SaveChanges();

            return newCount;

        }
    }

}