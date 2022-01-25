using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IDataOwnerCategoryService
    {
        IDataResult<DataOwnerCategory> GetById(int id);

        IDataResult<List<DataOwnerCategory>> GetList();

        IResult Add(DataOwnerCategory DataOwnerCategory);

        IResult Update(DataOwnerCategory DataOwnerCategory);

        IResult Delete(DataOwnerCategory DataOwnerCategory);
    }
}
