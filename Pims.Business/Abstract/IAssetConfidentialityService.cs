using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IAssetConfidentialityService
    {
        IDataResult<AssetConfidentiality> GetById(int id);

        IDataResult<List<AssetConfidentiality>> GetList();

        IResult Add(AssetConfidentiality AssetConfidentiality);

        IResult Update(AssetConfidentiality AssetConfidentiality);

        IResult Delete(AssetConfidentiality AssetConfidentiality);
    }
}
