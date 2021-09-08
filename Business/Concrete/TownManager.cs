using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TownManager : ITownService
    {

        ITownDal _townDal;

        public TownManager(ITownDal townDal)
        {
            _townDal = townDal;
        }
        public IDataResult<List<Town>> GetByCityId(int cityId)
        {
            return new SuccessDataResult<List<Town>>(_townDal.GetAll(t => t.CityId == cityId));
        }
    }
}
