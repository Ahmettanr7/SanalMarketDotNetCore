using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IOrderDetailDal : IEntityRepository<OrderDetail>
    {
        List<OrderDetailDto> GetAllDTO(Expression<Func<OrderDetailDto, bool>> filter = null);

        OrderDetailDto GetDTO(Expression<Func<OrderDetailDto, bool>> filter = null);

        List<DeliveredDto> GetAllDeliveredDTO(Expression<Func<DeliveredDto, bool>> filter = null);
    }
}
