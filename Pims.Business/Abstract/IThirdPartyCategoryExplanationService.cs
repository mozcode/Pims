using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IThirdPartyCategoryExplanationService
    {
        IDataResult<ThirdPartyCategoryExplanation> GetById(int id);

        IDataResult<List<ThirdPartyCategoryExplanation>> GetList();

        IResult Add(ThirdPartyCategoryExplanation ThirdPartyCategoryExplanation);

        IResult Update(ThirdPartyCategoryExplanation ThirdPartyCategoryExplanation);

        IResult Delete(ThirdPartyCategoryExplanation ThirdPartyCategoryExplanation);
    }
}
