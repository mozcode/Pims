using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IAssetAvailabilityService
    {
        IDataResult<AssetAvailability> GetById(int id);

        IDataResult<List<AssetAvailability>> GetList();

        IResult Add(AssetAvailability AssetAvailability);

        IResult Update(AssetAvailability AssetAvailability);

        IResult Delete(AssetAvailability AssetAvailability);
    }
}
