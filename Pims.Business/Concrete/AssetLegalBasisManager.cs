using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class AssetLegalBasisManager : IAssetLegalBasisService
    {
        private readonly IAssetLegalBasisDal _AssetLegalBasisDal;

        public AssetLegalBasisManager(IAssetLegalBasisDal AssetLegalBasisDal)
        {
            _AssetLegalBasisDal = AssetLegalBasisDal;
        }

        public IDataResult<AssetLegalBasis> GetById(int id)
        {
            return new SuccessDataResult<AssetLegalBasis>(_AssetLegalBasisDal.Get(x => x.Id == id));
        }

        public IDataResult<List<AssetLegalBasis>> GetList()
        {
            return new SuccessDataResult<List<AssetLegalBasis>>(_AssetLegalBasisDal.GetList().ToList());
        }

        public IResult Add(AssetLegalBasis AssetLegalBasis)
        {
            //Business Code

            _AssetLegalBasisDal.Add(AssetLegalBasis);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(AssetLegalBasis AssetLegalBasis)
        {
            //Business Code

            _AssetLegalBasisDal.Update(AssetLegalBasis);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(AssetLegalBasis AssetLegalBasis)
        {
            //Business Code

            _AssetLegalBasisDal.Delete(AssetLegalBasis);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
