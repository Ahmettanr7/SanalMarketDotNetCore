using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IResult Add(Address address);

        IDataResult<List<Address>> GetAllByUserId(int userId);

        IDataResult<List<Address>> GetAll();
    }
}
