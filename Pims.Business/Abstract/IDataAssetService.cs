using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IDataAssetService
    {
        IDataResult<DataAsset> GetById(int id);

        IDataResult<List<DataAsset>> GetList();

        IResult Add(DataAsset DataAsset);

        IResult Update(DataAsset DataAsset);

        IResult Delete(DataAsset DataAsset);
    }
}
