using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderDetailService
    {
        IDataResult<List<OrderDetailDto>> GetByOrderId(int orderId);

        IDataResult<OrderDetailDto> GetById(int id);

        IDataResult<List<OrderDetailDto>> GetByUserId(int userId);

        IDataResult<List<DeliveredDto>> GetByIsDeliveredIsTrue();

        IDataResult<List<DeliveredDto>> GetByIsDeliveredIsFalse();

        IDataResult<List<DeliveredDto>> GetOrderHistoryByUserId(int userId);
    }
}
