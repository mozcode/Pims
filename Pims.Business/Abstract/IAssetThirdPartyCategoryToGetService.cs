using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IAssetThirdPartyCategoryToGetService
    {
        IDataResult<AssetThirdPartyCategoryToGet> GetById(int id);

        IDataResult<List<AssetThirdPartyCategoryToGet>> GetList();

        IResult Add(AssetThirdPartyCategoryToGet AssetThirdPartyCategoryToGet);

        IResult Update(AssetThirdPartyCategoryToGet AssetThirdPartyCategoryToGet);

        IResult Delete(AssetThirdPartyCategoryToGet AssetThirdPartyCategoryToGet);
    }
}
