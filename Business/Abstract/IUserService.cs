using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);

        IDataResult<User> GetByEmailUI(string email);
        IResult Add(User user);
        IResult EditProfil(User user, string password);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);




    }
}