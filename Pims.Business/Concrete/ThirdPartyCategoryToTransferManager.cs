using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class ThirdPartyCategoryToTransferManager : IThirdPartyCategoryToTransferService
    {
        private readonly IThirdPartyCategoryToTransferDal _ThirdPartyCategoryToTransferDal;

        public ThirdPartyCategoryToTransferManager(IThirdPartyCategoryToTransferDal ThirdPartyCategoryToTransferDal)
        {
            _ThirdPartyCategoryToTransferDal = ThirdPartyCategoryToTransferDal;
        }

        public IDataResult<ThirdPartyCategoryToTransfer> GetById(int id)
        {
            return new SuccessDataResult<ThirdPartyCategoryToTransfer>(_ThirdPartyCategoryToTransferDal.Get(x => x.Id == id));
        }

        public IDataResult<List<ThirdPartyCategoryToTransfer>> GetList()
        {
            return new SuccessDataResult<List<ThirdPartyCategoryToTransfer>>(_ThirdPartyCategoryToTransferDal.GetList().ToList());
        }

        public IResult Add(ThirdPartyCategoryToTransfer ThirdPartyCategoryToTransfer)
        {
            //Business Code

            _ThirdPartyCategoryToTransferDal.Add(ThirdPartyCategoryToTransfer);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(ThirdPartyCategoryToTransfer ThirdPartyCategoryToTransfer)
        {
            //Business Code

            _ThirdPartyCategoryToTransferDal.Update(ThirdPartyCategoryToTransfer);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(ThirdPartyCategoryToTransfer ThirdPartyCategoryToTransfer)
        {
            //Business Code

            _ThirdPartyCategoryToTransferDal.Delete(ThirdPartyCategoryToTransfer);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
