using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IAssetService
    {
        IDataResult<Asset> GetById(int id);

        IDataResult<List<Asset>> GetList();

        IResult Add(Asset Asset);

        IResult Update(Asset Asset);

        IResult Delete(Asset Asset);
    }
}
