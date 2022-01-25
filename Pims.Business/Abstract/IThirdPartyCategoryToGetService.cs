using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IThirdPartyCategoryToGetService
    {
        IDataResult<ThirdPartyCategoryToGet> GetById(int id);

        IDataResult<List<ThirdPartyCategoryToGet>> GetList();

        IResult Add(ThirdPartyCategoryToGet ThirdPartyCategoryToGet);

        IResult Update(ThirdPartyCategoryToGet ThirdPartyCategoryToGet);

        IResult Delete(ThirdPartyCategoryToGet ThirdPartyCategoryToGet);
    }
}
