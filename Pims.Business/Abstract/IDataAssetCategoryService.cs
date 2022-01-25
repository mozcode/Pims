using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IDataAssetCategoryService
    {
        IDataResult<DataAssetCategory> GetById(int id);

        IDataResult<List<DataAssetCategory>> GetList();

        IResult Add(DataAssetCategory DataAssetCategory);

        IResult Update(DataAssetCategory DataAssetCategory);

        IResult Delete(DataAssetCategory DataAssetCategory);
    }
}
