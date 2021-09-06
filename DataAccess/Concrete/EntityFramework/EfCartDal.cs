using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCartDal : EfEntityRepositoryBase<Cart, ETRADE4Context>, ICartDal
    {
        public List<CartDto> getByUserIdTotalCartPrice(Expression<Func<CartDto, bool>> filter = null)
        {
            using (ETRADE4Context context = new ETRADE4Context())
            {
                var result = from c in context.Carts
                             join u in context.Users on c.UserId equals u.Id

                             select new CartDto
                             {
                                 UserId = c.UserId,
                                 TotalCartPrice =
                                 context.Carts.Where(ca => ca.UserId == c.UserId && c.CartStatus == true).Sum(t => t.LineTotal)
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
