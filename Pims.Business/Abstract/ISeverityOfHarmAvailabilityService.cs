using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ISeverityOfHarmAvailabilityService
    {
        IDataResult<SeverityOfHarmAvailability> GetById(int id);

        IDataResult<List<SeverityOfHarmAvailability>> GetList();

        IResult Add(SeverityOfHarmAvailability SeverityOfHarmAvailability);

        IResult Update(SeverityOfHarmAvailability SeverityOfHarmAvailability);

        IResult Delete(SeverityOfHarmAvailability SeverityOfHarmAvailability);
    }
}
