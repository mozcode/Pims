using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class AssetThirdPartyCategoryToTransferManager : IAssetThirdPartyCategoryToTransferService
    {
        private readonly IAssetThirdPartyCategoryToTransferDal _AssetThirdPartyCategoryToTransferDal;

        public AssetThirdPartyCategoryToTransferManager(IAssetThirdPartyCategoryToTransferDal AssetThirdPartyCategoryToTransferDal)
        {
            _AssetThirdPartyCategoryToTransferDal = AssetThirdPartyCategoryToTransferDal;
        }

        public IDataResult<AssetThirdPartyCategoryToTransfer> GetById(int id)
        {
            return new SuccessDataResult<AssetThirdPartyCategoryToTransfer>(_AssetThirdPartyCategoryToTransferDal.Get(x => x.Id == id));
        }

        public IDataResult<List<AssetThirdPartyCategoryToTransfer>> GetList()
        {
            return new SuccessDataResult<List<AssetThirdPartyCategoryToTransfer>>(_AssetThirdPartyCategoryToTransferDal.GetList().ToList());
        }

        public IResult Add(AssetThirdPartyCategoryToTransfer AssetThirdPartyCategoryToTransfer)
        {
            //Business Code

            _AssetThirdPartyCategoryToTransferDal.Add(AssetThirdPartyCategoryToTransfer);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(AssetThirdPartyCategoryToTransfer AssetThirdPartyCategoryToTransfer)
        {
            //Business Code

            _AssetThirdPartyCategoryToTransferDal.Update(AssetThirdPartyCategoryToTransfer);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(AssetThirdPartyCategoryToTransfer AssetThirdPartyCategoryToTransfer)
        {
            //Business Code

            _AssetThirdPartyCategoryToTransferDal.Delete(AssetThirdPartyCategoryToTransfer);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
