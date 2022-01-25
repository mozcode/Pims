using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ISeverityOfHarmIntegrityService
    {
        IDataResult<SeverityOfHarmIntegrity> GetById(int id);

        IDataResult<List<SeverityOfHarmIntegrity>> GetList();

        IResult Add(SeverityOfHarmIntegrity SeverityOfHarmIntegrity);

        IResult Update(SeverityOfHarmIntegrity SeverityOfHarmIntegrity);

        IResult Delete(SeverityOfHarmIntegrity SeverityOfHarmIntegrity);
    }
}
