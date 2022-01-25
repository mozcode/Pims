using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class SeverityOfHarmConfidentialityManager : ISeverityOfHarmConfidentialityService
    {
        private readonly ISeverityOfHarmConfidentialityDal _SeverityOfHarmConfidentialityDal;

        public SeverityOfHarmConfidentialityManager(ISeverityOfHarmConfidentialityDal SeverityOfHarmConfidentialityDal)
        {
            _SeverityOfHarmConfidentialityDal = SeverityOfHarmConfidentialityDal;
        }

        public IDataResult<SeverityOfHarmConfidentiality> GetById(int id)
        {
            return new SuccessDataResult<SeverityOfHarmConfidentiality>(_SeverityOfHarmConfidentialityDal.Get(x => x.Id == id));
        }

        public IDataResult<List<SeverityOfHarmConfidentiality>> GetList()
        {
            return new SuccessDataResult<List<SeverityOfHarmConfidentiality>>(_SeverityOfHarmConfidentialityDal.GetList().ToList());
        }

        public IResult Add(SeverityOfHarmConfidentiality SeverityOfHarmConfidentiality)
        {
            //Business Code

            _SeverityOfHarmConfidentialityDal.Add(SeverityOfHarmConfidentiality);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(SeverityOfHarmConfidentiality SeverityOfHarmConfidentiality)
        {
            //Business Code

            _SeverityOfHarmConfidentialityDal.Update(SeverityOfHarmConfidentiality);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(SeverityOfHarmConfidentiality SeverityOfHarmConfidentiality)
        {
            //Business Code

            _SeverityOfHarmConfidentialityDal.Delete(SeverityOfHarmConfidentiality);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
