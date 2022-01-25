using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class AssetThirdPartyCategoryToGetManager : IAssetThirdPartyCategoryToGetService
    {
        private readonly IAssetThirdPartyCategoryToGetDal _AssetThirdPartyCategoryToGetDal;

        public AssetThirdPartyCategoryToGetManager(IAssetThirdPartyCategoryToGetDal AssetThirdPartyCategoryToGetDal)
        {
            _AssetThirdPartyCategoryToGetDal = AssetThirdPartyCategoryToGetDal;
        }

        public IDataResult<AssetThirdPartyCategoryToGet> GetById(int id)
        {
            return new SuccessDataResult<AssetThirdPartyCategoryToGet>(_AssetThirdPartyCategoryToGetDal.Get(x => x.Id == id));
        }

        public IDataResult<List<AssetThirdPartyCategoryToGet>> GetList()
        {
            return new SuccessDataResult<List<AssetThirdPartyCategoryToGet>>(_AssetThirdPartyCategoryToGetDal.GetList().ToList());
        }

        public IResult Add(AssetThirdPartyCategoryToGet AssetThirdPartyCategoryToGet)
        {
            //Business Code

            _AssetThirdPartyCategoryToGetDal.Add(AssetThirdPartyCategoryToGet);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(AssetThirdPartyCategoryToGet AssetThirdPartyCategoryToGet)
        {
            //Business Code

            _AssetThirdPartyCategoryToGetDal.Update(AssetThirdPartyCategoryToGet);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(AssetThirdPartyCategoryToGet AssetThirdPartyCategoryToGet)
        {
            //Business Code

            _AssetThirdPartyCategoryToGetDal.Delete(AssetThirdPartyCategoryToGet);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
