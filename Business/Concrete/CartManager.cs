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
    public class CartManager : ICartService
    {
        ICartDal _cartDal;
        IItemDal _itemDal;

        public CartManager(ICartDal cartDal, IItemDal itemDal)
        {
            _cartDal = cartDal;
            _itemDal = itemDal;
        }
        public IResult Add(Cart cart)
        {
            var cartItem = _cartDal.Get(c => c.UserId == cart.UserId && c.ItemId == cart.ItemId && c.CartStatus == true);
            var findItem = _itemDal.Get(i => i.Id == cart.ItemId);
            if (cartItem != null)
            {
                var newCount = cartItem.Count + cart.Count;
                var newLineTotal = newCount * findItem.UnitPrice;
                cartItem.Count = newCount;
                cartItem.LineTotal = newLineTotal;
                _cartDal.Update(cartItem);
                return new SuccessResult("Sepet günellendi");
            }
            var newLineTotal2 = cart.Count * findItem.UnitPrice;
            cart.CartStatus = true;
            cart.LineTotal = newLineTotal2;
            cart.UnitPrice = findItem.UnitPrice;
            _cartDal.Add(cart);
            return new SuccessResult("Sepepe eklendi");
        }

        public IResult DecreaseAd(int userId, int itemId)
        {
            throw new NotImplementedException();
        }

        public IResult DecreaseKg(int userId, int itemId)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Cart>> GetAllByUserId(int userId)
        {
            return new SuccessDataResult<List<Cart>>(_cartDal.GetAll(c => c.UserId == userId));
        }

        public IDataResult<List<Cart>> GetAllByUserIdAndCartStatusIsTrue(int userId)
        {
            return new SuccessDataResult<List<Cart>>(_cartDal.GetAll(c => c.UserId == userId && c.CartStatus == true ), "Kullanıcı numarasına göre aktif ürünler getirildi");
        }

        public IDataResult<List<CartDto>> GetByUserIdTotalCartPrice(int userId)
        {
            return new SuccessDataResult<List<CartDto>>(_cartDal.getByUserIdTotalCartPrice(dto => dto.UserId == userId));
        }

        public IResult IncreaseAd(int userId, int itemId)
        {
            throw new NotImplementedException();
        }

        public IResult IncreaseKg(int userId, int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
