using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IAssetTypeService
    {
        IDataResult<AssetType> GetById(int id);

        IDataResult<List<AssetType>> GetList();

        IResult Add(AssetType AssetType);

        IResult Update(AssetType AssetType);

        IResult Delete(AssetType AssetType);
    }
}
