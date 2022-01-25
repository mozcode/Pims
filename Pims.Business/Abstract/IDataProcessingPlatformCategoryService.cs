using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IDataProcessingPlatformCategoryService
    {
        IDataResult<DataProcessingPlatformCategory> GetById(int id);

        IDataResult<List<DataProcessingPlatformCategory>> GetList();

        IResult Add(DataProcessingPlatformCategory DataProcessingPlatformCategory);

        IResult Update(DataProcessingPlatformCategory DataProcessingPlatformCategory);

        IResult Delete(DataProcessingPlatformCategory DataProcessingPlatformCategory);
    }
}
