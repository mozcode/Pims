using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class AssetConfidentialityManager : IAssetConfidentialityService
    {
        private readonly IAssetConfidentialityDal _AssetConfidentialityDal;

        public AssetConfidentialityManager(IAssetConfidentialityDal AssetConfidentialityDal)
        {
            _AssetConfidentialityDal = AssetConfidentialityDal;
        }

        public IDataResult<AssetConfidentiality> GetById(int id)
        {
            return new SuccessDataResult<AssetConfidentiality>(_AssetConfidentialityDal.Get(x => x.Id == id));
        }

        public IDataResult<List<AssetConfidentiality>> GetList()
        {
            return new SuccessDataResult<List<AssetConfidentiality>>(_AssetConfidentialityDal.GetList().ToList());
        }

        public IResult Add(AssetConfidentiality AssetConfidentiality)
        {
            //Business Code

            _AssetConfidentialityDal.Add(AssetConfidentiality);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(AssetConfidentiality AssetConfidentiality)
        {
            //Business Code

            _AssetConfidentialityDal.Update(AssetConfidentiality);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(AssetConfidentiality AssetConfidentiality)
        {
            //Business Code

            _AssetConfidentialityDal.Delete(AssetConfidentiality);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
