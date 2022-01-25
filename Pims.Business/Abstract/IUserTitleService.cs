using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IUserTitleService
    {
        IDataResult<UserTitle> GetById(int id);

        IDataResult<List<UserTitle>> GetList();

        IResult Add(UserTitle userTitle);

        IResult Update(UserTitle userTitle);

        IResult Delete(UserTitle userTitle);
    }
}
