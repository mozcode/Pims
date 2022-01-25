using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ILikelihoodOfHarmAvailabilityService
    {
        IDataResult<LikelihoodOfHarmAvailability> GetById(int id);

        IDataResult<List<LikelihoodOfHarmAvailability>> GetList();

        IResult Add(LikelihoodOfHarmAvailability LikelihoodOfHarmAvailability);

        IResult Update(LikelihoodOfHarmAvailability LikelihoodOfHarmAvailability);

        IResult Delete(LikelihoodOfHarmAvailability LikelihoodOfHarmAvailability);
    }
}
