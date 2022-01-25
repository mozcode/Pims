using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ILikelihoodOfHarmConfidentialityService
    {
        IDataResult<LikelihoodOfHarmConfidentiality> GetById(int id);

        IDataResult<List<LikelihoodOfHarmConfidentiality>> GetList();

        IResult Add(LikelihoodOfHarmConfidentiality LikelihoodOfHarmConfidentiality);

        IResult Update(LikelihoodOfHarmConfidentiality LikelihoodOfHarmConfidentiality);

        IResult Delete(LikelihoodOfHarmConfidentiality LikelihoodOfHarmConfidentiality);
    }
}
