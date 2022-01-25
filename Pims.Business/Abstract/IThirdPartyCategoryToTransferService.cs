using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IThirdPartyCategoryToTransferService
    {
        IDataResult<ThirdPartyCategoryToTransfer> GetById(int id);

        IDataResult<List<ThirdPartyCategoryToTransfer>> GetList();

        IResult Add(ThirdPartyCategoryToTransfer ThirdPartyCategoryToTransfer);

        IResult Update(ThirdPartyCategoryToTransfer ThirdPartyCategoryToTransfer);

        IResult Delete(ThirdPartyCategoryToTransfer ThirdPartyCategoryToTransfer);
    }
}
