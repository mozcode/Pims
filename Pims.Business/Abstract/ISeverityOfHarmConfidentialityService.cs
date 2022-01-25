using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ISeverityOfHarmConfidentialityService
    {
        IDataResult<SeverityOfHarmConfidentiality> GetById(int id);

        IDataResult<List<SeverityOfHarmConfidentiality>> GetList();

        IResult Add(SeverityOfHarmConfidentiality SeverityOfHarmConfidentiality);

        IResult Update(SeverityOfHarmConfidentiality SeverityOfHarmConfidentiality);

        IResult Delete(SeverityOfHarmConfidentiality SeverityOfHarmConfidentiality);
    }
}
