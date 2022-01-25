using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IUserTypeService
    {
        IDataResult<UserType> GetById(int id);

        IDataResult<List<UserType>> GetList();

        IResult Add(UserType userType);

        IResult Update(UserType userType);

        IResult Delete(UserType userType);
    }
}
