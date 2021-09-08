using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {

        IOrderDal _orderDal;
        ICartDal _cartDal;
        IOrderDetailDal _orderDetailDal;

        public OrderManager(IOrderDal orderDal, ICartDal cartDal, IOrderDetailDal orderDetailDal)
        {
            _orderDal = orderDal;
            _cartDal = cartDal;
            _orderDetailDal = orderDetailDal;
        }
        public IResult Add(Order order)
        {
            CartDto cart = _cartDal.getByUserIdTotalCartPrice(t => t.UserId == order.UserId);
            DateTime now = DateTime.Now;

            order.Date_ = now;
            order.TotalPrice = cart.TotalCartPrice;
            order.IsDelivered = false;
            _orderDal.Add(order);

            var cartItems = _cartDal.GetAll(c => c.UserId == order.UserId && c.CartStatus == true);

            foreach (var item in cartItems)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.ItemId = item.Id;
                orderDetail.OrderId = order.Id;
                orderDetail.Count = item.Count;
                _orderDetailDal.Add(orderDetail);
            }
            foreach (var item in cartItems)
            {
                item.CartStatus = false;
                _cartDal.Update(item);
            }

            return new SuccessResult("Siparişiniz alındı.");

        }

        public IDataResult<Order> GetById(int id)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(o => o.Id == id));
        }

        public IDataResult<List<Order>> GetByIsDeliveredIsFalse()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(o => o.IsDelivered == false));
        }

        public IDataResult<List<Order>> GetByIsDeliveredIsTrue()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(o => o.IsDelivered == true));
        }

        public IDataResult<List<Order>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(o => o.UserId == userId));
        }

        public IResult WasDelivered(int id)
        {
            Order order = _orderDal.Get(o => o.Id == id);
            order.IsDelivered = true;
            _orderDal.Update(order);
            return new SuccessResult("Siparişin teslim edildiği kaydedildi.");
        }
    }
}
