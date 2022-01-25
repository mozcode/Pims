using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ILegalBasisService
    {
        IDataResult<LegalBasis> GetById(int id);

        IDataResult<List<LegalBasis>> GetList();

        IResult Add(LegalBasis LegalBasis);

        IResult Update(LegalBasis LegalBasis);

        IResult Delete(LegalBasis LegalBasis);
    }
}
