using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace Business.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public IDataResult<OrderDetailDto> GetById(int id)
        {
            return new SuccessDataResult<OrderDetailDto>(_orderDetailDal.GetDTO(dto => dto.Id == id));
        }

        public IDataResult<List<DeliveredDto>> GetByIsDeliveredIsFalse()
        {
            return new SuccessDataResult<List<DeliveredDto>>(_orderDetailDal.GetAllDeliveredDTO(dto => dto.IsDelivered == false));
        }

        public IDataResult<List<DeliveredDto>> GetByIsDeliveredIsTrue()
        {
            return new SuccessDataResult<List<DeliveredDto>>(_orderDetailDal.GetAllDeliveredDTO(dto => dto.IsDelivered == true));
        }

        public IDataResult<List<OrderDetailDto>> GetByOrderId(int orderId)
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_orderDetailDal.GetAllDTO(dto => dto.OrderId == orderId));
        }

        public IDataResult<List<OrderDetailDto>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_orderDetailDal.GetAllDTO(dto => dto.UserId == userId));
        }

        public IDataResult<List<DeliveredDto>> GetOrderHistoryByUserId(int userId)
        {
            return new SuccessDataResult<List<DeliveredDto>>(_orderDetailDal.GetAllDeliveredDTO(dto => dto.UserId==userId && dto.IsDelivered == true));
        }
    }
    }

