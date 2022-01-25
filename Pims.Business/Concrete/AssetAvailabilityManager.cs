using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class AssetAvailabilityManager : IAssetAvailabilityService
    {
        private readonly IAssetAvailabilityDal _AssetAvailabilityDal;

        public AssetAvailabilityManager(IAssetAvailabilityDal AssetAvailabilityDal)
        {
            _AssetAvailabilityDal = AssetAvailabilityDal;
        }

        public IDataResult<AssetAvailability> GetById(int id)
        {
            return new SuccessDataResult<AssetAvailability>(_AssetAvailabilityDal.Get(x => x.Id == id));
        }

        public IDataResult<List<AssetAvailability>> GetList()
        {
            return new SuccessDataResult<List<AssetAvailability>>(_AssetAvailabilityDal.GetList().ToList());
        }

        public IResult Add(AssetAvailability AssetAvailability)
        {
            //Business Code

            _AssetAvailabilityDal.Add(AssetAvailability);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(AssetAvailability AssetAvailability)
        {
            //Business Code

            _AssetAvailabilityDal.Update(AssetAvailability);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(AssetAvailability AssetAvailability)
        {
            //Business Code

            _AssetAvailabilityDal.Delete(AssetAvailability);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
