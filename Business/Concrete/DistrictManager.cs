using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }
        public IDataResult<List<District>> GetByTownId(int townId)
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetAll(d => d.TownId == townId));
        }
    }
}
