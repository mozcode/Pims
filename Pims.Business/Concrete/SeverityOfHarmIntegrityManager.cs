using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class SeverityOfHarmIntegrityManager : ISeverityOfHarmIntegrityService
    {
        private readonly ISeverityOfHarmIntegrityDal _SeverityOfHarmIntegrityDal;

        public SeverityOfHarmIntegrityManager(ISeverityOfHarmIntegrityDal SeverityOfHarmIntegrityDal)
        {
            _SeverityOfHarmIntegrityDal = SeverityOfHarmIntegrityDal;
        }

        public IDataResult<SeverityOfHarmIntegrity> GetById(int id)
        {
            return new SuccessDataResult<SeverityOfHarmIntegrity>(_SeverityOfHarmIntegrityDal.Get(x => x.Id == id));
        }

        public IDataResult<List<SeverityOfHarmIntegrity>> GetList()
        {
            return new SuccessDataResult<List<SeverityOfHarmIntegrity>>(_SeverityOfHarmIntegrityDal.GetList().ToList());
        }

        public IResult Add(SeverityOfHarmIntegrity SeverityOfHarmIntegrity)
        {
            //Business Code

            _SeverityOfHarmIntegrityDal.Add(SeverityOfHarmIntegrity);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(SeverityOfHarmIntegrity SeverityOfHarmIntegrity)
        {
            //Business Code

            _SeverityOfHarmIntegrityDal.Update(SeverityOfHarmIntegrity);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(SeverityOfHarmIntegrity SeverityOfHarmIntegrity)
        {
            //Business Code

            _SeverityOfHarmIntegrityDal.Delete(SeverityOfHarmIntegrity);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
