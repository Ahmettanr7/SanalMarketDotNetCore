using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDetailDal : EfEntityRepositoryBase<OrderDetail, ETRADE4Context>, IOrderDetailDal
    {
        public List<DeliveredDto> GetAllDeliveredDTO(Expression<Func<DeliveredDto, bool>> filter = null)
        {
            using (ETRADE4Context context = new ETRADE4Context())
            {
                var result = from o in context.Orders
                             join od in context.OrderDetails on o.Id equals od.OrderId
                             join i in context.Items on od.ItemId equals i.Id
                             join a in context.Addresses on o.AddressId equals a.Id
                             join u in context.Users on o.UserId equals u.Id


                             select new DeliveredDto
                             {
                                 UserId = u.Id,
                                 AddressId = a.Id,
                                 AddressText = a.AddressText,
                                 CityId = a.CityId,
                                 CountryId = a.CountryId,
                                 Date_ = o.Date_,
                                 DistrictId = a.DistrictId,
                                 Email = u.Email,
                                 FirstName = u.FirstName,
                                 IsDelivered = o.IsDelivered,
                                 LastName = u.LastName,
                                 OrderId = o.Id,
                                 PostalCode = a.PostalCode,
                                 TotalPrice = o.TotalPrice,
                                 TownId = a.TownId
                             };
                return filter == null ? result.Distinct().ToList() : result.Where(filter).Distinct().OrderByDescending(o => o.OrderId).ToList();
            }
        }

        public List<OrderDetailDto> GetAllDTO(Expression<Func<OrderDetailDto, bool>> filter = null)
        {
            using (ETRADE4Context context = new ETRADE4Context())
            {
                var result = from o in context.Orders
                             join od in context.OrderDetails on o.Id equals od.OrderId
                             join i in context.Items on od.ItemId equals i.Id
                             join a in context.Addresses on o.AddressId equals a.Id
                             join u in context.Users on o.UserId equals u.Id
                             


                             select new OrderDetailDto
                             {
                                 UserId = u.Id,
                                 AddressId = a.Id,
                                 AddressText = a.AddressText,
                                 ItemId = i.Id,
                                 Brand = i.Brand,
                                 Category1 = i.Category1,
                                 Category2 = i.Category2,
                                 Category3 = i.Category3,
                                 Category4 = i.Category4,
                                 ImageUrl = i.ImageUrl,
                                 ItemCode = i.ItemCode,
                                 ItemName = i.ItemName,
                                 UnitPrice = i.UnitPrice,
                                 CityId = a.CityId,
                                 Count = od.Count,
                                 CountryId = a.CountryId,
                                 Date_ = o.Date_,
                                 DistrictId = a.DistrictId,
                                 Email = u.Email,
                                 FirstName = u.FirstName,
                                 IsDelivered = o.IsDelivered,
                                 LastName = u.LastName,
                                 Id = od.Id,
                                 OrderId = o.Id,
                                 PostalCode = a.PostalCode,
                                 TotalPrice = o.TotalPrice,
                                 TownId = a.TownId


                             };
                return filter == null ? result.ToList() : result.Where(filter).OrderByDescending(o => o.OrderId).ToList();
            }
    }
        public OrderDetailDto GetDTO(Expression<Func<OrderDetailDto, bool>> filter = null)
        {
            using (ETRADE4Context context = new ETRADE4Context())
            {
                var result = from o in context.Orders
                             join od in context.OrderDetails on o.Id equals od.OrderId
                             join i in context.Items on od.ItemId equals i.Id
                             join a in context.Addresses on o.AddressId equals a.Id
                             join u in context.Users on o.UserId equals u.Id


                             select new OrderDetailDto
                             {
                                 UserId = u.Id,
                                 AddressId = a.Id,
                                 AddressText = a.AddressText,
                                 ItemId = i.Id,
                                 Brand = i.Brand,
                                 Category1 = i.Category1,
                                 Category2 = i.Category2,
                                 Category3 = i.Category3,
                                 Category4 = i.Category4,
                                 ImageUrl = i.ImageUrl,
                                 ItemCode = i.ItemCode,
                                 ItemName = i.ItemName,
                                 UnitPrice = i.UnitPrice,
                                 CityId = a.CityId,
                                 Count = od.Count,
                                 CountryId = a.CountryId,
                                 Date_ = o.Date_,
                                 DistrictId = a.DistrictId,
                                 Email = u.Email,
                                 FirstName = u.FirstName,
                                 IsDelivered = o.IsDelivered,
                                 LastName = u.LastName,
                                 Id = od.Id,
                                 OrderId = o.Id,
                                 PostalCode = a.PostalCode,
                                 TotalPrice = o.TotalPrice,
                                 TownId = a.TownId


                             };
                return filter == null ? result.SingleOrDefault() : result.Where(filter).SingleOrDefault();
            }
        }
    }
}
