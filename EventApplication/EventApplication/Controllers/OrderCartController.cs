using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventApplication.Models;

namespace EventApplication.Controllers
{
    public class OrderOrderController : Controller
    {
        DBContext db = new DBContext();
        // GET: OrderCart
        public ActionResult Index()
        {
            OrderCart order = OrderCart.GetOrder(this.HttpContext);

            OrderCartViewModel vm = new OrderCartViewModel
            {
                OrderItems = order.GetOrderItems(),

            };

            return View(vm);
        }

        // GET: OrderOrder/AddToOrder
        public ActionResult AddToOrder(int id)
        {
            OrderCart Order = new OrderCart();

            OrderCart order = OrderCart.GetOrder(this.HttpContext);
            Order.AddToOrder(id);
            return RedirectToAction("Index");
        }
        // GET: Order
        public ActionResult Register()
        {
            return View();
        }

        // GET: Order
        public ActionResult OrderSummary()
        {
            return View();
        }

        // POST: OrderOrder/RemoveFromOrder
        [HttpPost]
        public ActionResult RemoveFromOrder(int id)
        {
            OrderCart order = OrderCart.GetOrder(this.HttpContext);

            Event orderevent = db.Orders.SingleOrDefault(c => c.EventOrderId == id).EventSelected;

            int newItemCount = order.RemoveFromOrder(id);

            OrderCartRemoveViewModel vm = new OrderCartRemoveViewModel()
            {
                DeleteId = id,
                ItemCount = newItemCount,
                Message = orderevent.Title + " has been removed from the order"
            };

            return Json(vm);
        }

    }
}