using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IAssetCategoryService
    {
        IDataResult<AssetCategory> GetById(int id);

        IDataResult<List<AssetCategory>> GetList();

        IResult Add(AssetCategory AssetCategory);

        IResult Update(AssetCategory AssetCategory);

        IResult Delete(AssetCategory AssetCategory);
    }
}
