using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetById(int id);

        IDataResult<List<User>> GetList();

        IDataResult<List<User>> GetListByCompanyId(int categoryId);

        IDataResult<List<User>> GetListByUserTypeId(int categoryId);

        IDataResult<List<OperationClaim>> GetClaims(User user);

        IDataResult<User> GetByMail(string email);

        IResult Add(User user);

        IResult Update(User user);

        IResult Delete(User user);
    }
}
