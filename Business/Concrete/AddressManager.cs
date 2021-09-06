using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AddressManager : IAddressService
    {

        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        public IResult Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult("Adres ekleme işlemi başarılı");
        }

        public IDataResult<List<Address>> GetAll()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll());
        }

        public IDataResult<List<Address>> GetAllByUserId(int userId)
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll(u => u.UserId == userId));
        }
    }
}
