using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public IDataResult<List<City>> GetByCountryId(int countryId)
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(c => c.CountryId == countryId));
        }
    }
}
