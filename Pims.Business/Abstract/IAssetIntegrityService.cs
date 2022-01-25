using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IAssetIntegrityService
    {
        IDataResult<AssetIntegrity> GetById(int id);

        IDataResult<List<AssetIntegrity>> GetList();

        IResult Add(AssetIntegrity AssetIntegrity);

        IResult Update(AssetIntegrity AssetIntegrity);

        IResult Delete(AssetIntegrity AssetIntegrity);
    }
}
