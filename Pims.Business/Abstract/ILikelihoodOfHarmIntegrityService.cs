using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ILikelihoodOfHarmIntegrityService
    {
        IDataResult<LikelihoodOfHarmIntegrity> GetById(int id);

        IDataResult<List<LikelihoodOfHarmIntegrity>> GetList();

        IResult Add(LikelihoodOfHarmIntegrity LikelihoodOfHarmIntegrity);

        IResult Update(LikelihoodOfHarmIntegrity LikelihoodOfHarmIntegrity);

        IResult Delete(LikelihoodOfHarmIntegrity LikelihoodOfHarmIntegrity);
    }
}
