using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICartService
    {
		IResult Add(Cart cart);

		IResult Delete(int id);

		IResult DecreaseAd(int userId, int itemId);
		IResult IncreaseAd(int userId, int itemId);
		IResult DecreaseKg(int userId, int itemId);
		IResult IncreaseKg(int userId, int itemId);

		IDataResult<List<Cart>> GetAllByUserId(int userId);

		IDataResult<CartDto> GetByUserIdTotalCartPrice(int userId);

		IDataResult<List<CartWithItemDto>> GetAllByUserIdAndCartStatusIsTrue(int userId);
		IDataResult<List<CartWithItemDto>> GetAllByUserIdAndCartStatusIsFalse(int userId);
	}
}
