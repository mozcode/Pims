using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class SeverityOfHarmAvailabilityManager : ISeverityOfHarmAvailabilityService
    {
        private readonly ISeverityOfHarmAvailabilityDal _SeverityOfHarmAvailabilityDal;

        public SeverityOfHarmAvailabilityManager(ISeverityOfHarmAvailabilityDal SeverityOfHarmAvailabilityDal)
        {
            _SeverityOfHarmAvailabilityDal = SeverityOfHarmAvailabilityDal;
        }

        public IDataResult<SeverityOfHarmAvailability> GetById(int id)
        {
            return new SuccessDataResult<SeverityOfHarmAvailability>(_SeverityOfHarmAvailabilityDal.Get(x => x.Id == id));
        }

        public IDataResult<List<SeverityOfHarmAvailability>> GetList()
        {
            return new SuccessDataResult<List<SeverityOfHarmAvailability>>(_SeverityOfHarmAvailabilityDal.GetList().ToList());
        }

        public IResult Add(SeverityOfHarmAvailability SeverityOfHarmAvailability)
        {
            //Business Code

            _SeverityOfHarmAvailabilityDal.Add(SeverityOfHarmAvailability);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(SeverityOfHarmAvailability SeverityOfHarmAvailability)
        {
            //Business Code

            _SeverityOfHarmAvailabilityDal.Update(SeverityOfHarmAvailability);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(SeverityOfHarmAvailability SeverityOfHarmAvailability)
        {
            //Business Code

            _SeverityOfHarmAvailabilityDal.Delete(SeverityOfHarmAvailability);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
