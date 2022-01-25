using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IAssetAddressService
    {
        IDataResult<AssetAddress> GetById(int id);

        IDataResult<List<AssetAddress>> GetList();

        IResult Add(AssetAddress AssetAddress);

        IResult Update(AssetAddress AssetAddress);

        IResult Delete(AssetAddress AssetAddress);
    }
}
