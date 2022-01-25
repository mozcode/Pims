using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class LikelihoodOfHarmAvailabilityManager : ILikelihoodOfHarmAvailabilityService
    {
        private readonly ILikelihoodOfHarmAvailabilityDal _LikelihoodOfHarmAvailabilityDal;

        public LikelihoodOfHarmAvailabilityManager(ILikelihoodOfHarmAvailabilityDal LikelihoodOfHarmAvailabilityDal)
        {
            _LikelihoodOfHarmAvailabilityDal = LikelihoodOfHarmAvailabilityDal;
        }

        public IDataResult<LikelihoodOfHarmAvailability> GetById(int id)
        {
            return new SuccessDataResult<LikelihoodOfHarmAvailability>(_LikelihoodOfHarmAvailabilityDal.Get(x => x.Id == id));
        }

        public IDataResult<List<LikelihoodOfHarmAvailability>> GetList()
        {
            return new SuccessDataResult<List<LikelihoodOfHarmAvailability>>(_LikelihoodOfHarmAvailabilityDal.GetList().ToList());
        }

        public IResult Add(LikelihoodOfHarmAvailability LikelihoodOfHarmAvailability)
        {
            //Business Code

            _LikelihoodOfHarmAvailabilityDal.Add(LikelihoodOfHarmAvailability);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(LikelihoodOfHarmAvailability LikelihoodOfHarmAvailability)
        {
            //Business Code

            _LikelihoodOfHarmAvailabilityDal.Update(LikelihoodOfHarmAvailability);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(LikelihoodOfHarmAvailability LikelihoodOfHarmAvailability)
        {
            //Business Code

            _LikelihoodOfHarmAvailabilityDal.Delete(LikelihoodOfHarmAvailability);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
