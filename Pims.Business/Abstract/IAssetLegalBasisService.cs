using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IAssetLegalBasisService
    {
        IDataResult<AssetLegalBasis> GetById(int id);

        IDataResult<List<AssetLegalBasis>> GetList();

        IResult Add(AssetLegalBasis AssetLegalBasis);

        IResult Update(AssetLegalBasis AssetLegalBasis);

        IResult Delete(AssetLegalBasis AssetLegalBasis);
    }
}
