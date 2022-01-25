using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IAssetThirdPartyCategoryToTransferService
    {
        IDataResult<AssetThirdPartyCategoryToTransfer> GetById(int id);

        IDataResult<List<AssetThirdPartyCategoryToTransfer>> GetList();

        IResult Add(AssetThirdPartyCategoryToTransfer AssetThirdPartyCategoryToTransfer);

        IResult Update(AssetThirdPartyCategoryToTransfer AssetThirdPartyCategoryToTransfer);

        IResult Delete(AssetThirdPartyCategoryToTransfer AssetThirdPartyCategoryToTransfer);
    }
}
