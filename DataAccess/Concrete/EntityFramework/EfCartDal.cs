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
        public List<CartWithItemDto> GetAllByUserIdAndCartStatusTrueCartWithItemDto(Expression<Func<CartWithItemDto, bool>> filter = null)
        {
            using (ETRADE4Context context = new ETRADE4Context())
            {
                var result = from c in context.Carts
                             join u in context.Users on c.UserId equals u.Id
                             join i in context.Items on c.ItemId equals i.Id
                             

                             select new CartWithItemDto
                             {
                                 Id = c.Id,
                                 Count = c.Count,
                                 UserId = u.Id,
                                 CartStatus = c.CartStatus,
                                 LineTotal = c.LineTotal,
                                 ItemId = i.Id,
                                 Brand = i.Brand,
                                 Category1 = i.Category1,
                                 Category2 = i.Category2,
                                 Category3 = i.Category3,
                                 Category4 = i.Category4,
                                 ImageUrl = i.ImageUrl,
                                 ItemCode = i.ItemCode,
                                 ItemName = i.ItemName,
                                 UnitPrice = i.UnitPrice
                                 
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public CartDto getByUserIdTotalCartPrice(Expression<Func<CartDto, bool>> filter = null)
        {
            using (ETRADE4Context context = new ETRADE4Context())
            {
                var result = from c in context.Carts
                             join u in context.Users on c.UserId equals u.Id
                             where c.CartStatus == true

                             select new CartDto
                             {
                                 UserId = c.UserId,
                                 TotalCartPrice =
                                 context.Carts.Where(ca => ca.UserId == c.UserId && c.CartStatus == true).Sum(t => t.LineTotal)
                             };
                return filter == null ? result.FirstOrDefault() : result.Where(filter).FirstOrDefault();
            }
        }
    }
}
