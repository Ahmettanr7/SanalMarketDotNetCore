using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCountryDal : EfEntityRepositoryBase<Country, ETRADE4Context>, ICountryDal
    {
    }
}
