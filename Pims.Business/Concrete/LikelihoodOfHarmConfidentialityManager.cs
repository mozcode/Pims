using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class LikelihoodOfHarmConfidentialityManager : ILikelihoodOfHarmConfidentialityService
    {
        private readonly ILikelihoodOfHarmConfidentialityDal _LikelihoodOfHarmConfidentialityDal;

        public LikelihoodOfHarmConfidentialityManager(ILikelihoodOfHarmConfidentialityDal LikelihoodOfHarmConfidentialityDal)
        {
            _LikelihoodOfHarmConfidentialityDal = LikelihoodOfHarmConfidentialityDal;
        }

        public IDataResult<LikelihoodOfHarmConfidentiality> GetById(int id)
        {
            return new SuccessDataResult<LikelihoodOfHarmConfidentiality>(_LikelihoodOfHarmConfidentialityDal.Get(x => x.Id == id));
        }

        public IDataResult<List<LikelihoodOfHarmConfidentiality>> GetList()
        {
            return new SuccessDataResult<List<LikelihoodOfHarmConfidentiality>>(_LikelihoodOfHarmConfidentialityDal.GetList().ToList());
        }

        public IResult Add(LikelihoodOfHarmConfidentiality LikelihoodOfHarmConfidentiality)
        {
            //Business Code

            _LikelihoodOfHarmConfidentialityDal.Add(LikelihoodOfHarmConfidentiality);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(LikelihoodOfHarmConfidentiality LikelihoodOfHarmConfidentiality)
        {
            //Business Code

            _LikelihoodOfHarmConfidentialityDal.Update(LikelihoodOfHarmConfidentiality);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(LikelihoodOfHarmConfidentiality LikelihoodOfHarmConfidentiality)
        {
            //Business Code

            _LikelihoodOfHarmConfidentialityDal.Delete(LikelihoodOfHarmConfidentiality);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
