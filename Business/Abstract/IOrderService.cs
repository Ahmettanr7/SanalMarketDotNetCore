using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
		IResult Add(Order order);

		IResult WasDelivered(int id);

		IDataResult<Order> GetById(int id);

		IDataResult<List<Order>> GetByUserId(int userId);

		IDataResult<List<Order>> GetByIsDeliveredIsTrue();

		IDataResult<List<Order>> GetByIsDeliveredIsFalse();
	}
}
