using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderManager.Models;

namespace OrderManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController:ControllerBase
    {
        private readonly OrderContext orderdb;

         public OrderController(OrderContext context)
        {
            this.orderdb = context;
        }

        private IQueryable<Order> buildQuery(string name)
        {
            IQueryable<Order> query = orderdb.Orders;
            if (name != null)
            {
                query = query.Where(t => t.ClientName.Contains(name));
            }
           
            return query;
        }

         private IQueryable<OrderItem> buildItemQuery(int orderid)
        {
            IQueryable<OrderItem> query = orderdb.OrderItems;
            
            query = query.Where(t => t.OrderID == orderid);
            return query;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetOrders(string name)
        {
            var query = buildQuery(name);
            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
             var order = orderdb.Orders.FirstOrDefault(t => t.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        [HttpGet("{id}/orderItems")]
        public ActionResult<List<OrderItem>> GetOrderItems(int id,string name)
        {
            var query = buildItemQuery(id);
            if (query == null)
            {
                return NotFound();
            }
            return query.ToList();
            
        }
        
        [HttpPost]
        public ActionResult<Order> PostOrders(Order order)
        {
            try{
                orderdb.Orders.Add(order);
                orderdb.SaveChanges();
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order; 
        }
        //add items
        [HttpPost("{id}")]
        public ActionResult<OrderItem> PostOrderItems(OrderItem orderItem)
        {
            try{
                orderdb.OrderItems.Add(orderItem);
                orderdb.SaveChanges();
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return orderItem; 
        }

        [HttpDelete("{id}")]
         public ActionResult DeleteOrder(int id)
        {
            try
            {
                var order = orderdb.Orders.FirstOrDefault(t => t.OrderID == id);
                if (order != null)
                {
                    orderdb.Remove(order);
                    orderdb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
        [HttpDelete("{id}/{itemid}")]
         public ActionResult DeleteOrder(int id,int itemid)
        {
            try
            {
                var orderItem = orderdb.OrderItems.FirstOrDefault(t => t.OrderID == id && t.ItemID == itemid );
                if (orderItem != null)
                {
                    orderdb.Remove(orderItem);
                    orderdb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult<Order> PutOrders(int id,Order order)
        {
            if (id != order.OrderID)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                orderdb.Entry(order).State = EntityState.Modified;
                orderdb.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

    }
}