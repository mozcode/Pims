using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class AssetIntegrityManager : IAssetIntegrityService
    {
        private readonly IAssetIntegrityDal _AssetIntegrityDal;

        public AssetIntegrityManager(IAssetIntegrityDal AssetIntegrityDal)
        {
            _AssetIntegrityDal = AssetIntegrityDal;
        }

        public IDataResult<AssetIntegrity> GetById(int id)
        {
            return new SuccessDataResult<AssetIntegrity>(_AssetIntegrityDal.Get(x => x.Id == id));
        }

        public IDataResult<List<AssetIntegrity>> GetList()
        {
            return new SuccessDataResult<List<AssetIntegrity>>(_AssetIntegrityDal.GetList().ToList());
        }

        public IResult Add(AssetIntegrity AssetIntegrity)
        {
            //Business Code

            _AssetIntegrityDal.Add(AssetIntegrity);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(AssetIntegrity AssetIntegrity)
        {
            //Business Code

            _AssetIntegrityDal.Update(AssetIntegrity);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(AssetIntegrity AssetIntegrity)
        {
            //Business Code

            _AssetIntegrityDal.Delete(AssetIntegrity);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
