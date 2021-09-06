using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICartDal : IEntityRepository<Cart>
    {
        List<CartDto> getByUserIdTotalCartPrice(Expression<Func<CartDto, bool>> filter = null);
    }
}
