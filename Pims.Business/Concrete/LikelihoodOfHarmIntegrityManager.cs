using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class LikelihoodOfHarmIntegrityManager : ILikelihoodOfHarmIntegrityService
    {
        private readonly ILikelihoodOfHarmIntegrityDal _LikelihoodOfHarmIntegrityDal;

        public LikelihoodOfHarmIntegrityManager(ILikelihoodOfHarmIntegrityDal LikelihoodOfHarmIntegrityDal)
        {
            _LikelihoodOfHarmIntegrityDal = LikelihoodOfHarmIntegrityDal;
        }

        public IDataResult<LikelihoodOfHarmIntegrity> GetById(int id)
        {
            return new SuccessDataResult<LikelihoodOfHarmIntegrity>(_LikelihoodOfHarmIntegrityDal.Get(x => x.Id == id));
        }

        public IDataResult<List<LikelihoodOfHarmIntegrity>> GetList()
        {
            return new SuccessDataResult<List<LikelihoodOfHarmIntegrity>>(_LikelihoodOfHarmIntegrityDal.GetList().ToList());
        }

        public IResult Add(LikelihoodOfHarmIntegrity LikelihoodOfHarmIntegrity)
        {
            //Business Code

            _LikelihoodOfHarmIntegrityDal.Add(LikelihoodOfHarmIntegrity);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(LikelihoodOfHarmIntegrity LikelihoodOfHarmIntegrity)
        {
            //Business Code

            _LikelihoodOfHarmIntegrityDal.Update(LikelihoodOfHarmIntegrity);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(LikelihoodOfHarmIntegrity LikelihoodOfHarmIntegrity)
        {
            //Business Code

            _LikelihoodOfHarmIntegrityDal.Delete(LikelihoodOfHarmIntegrity);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
