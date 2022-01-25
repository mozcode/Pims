using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class OperationClaimManager : IOperationClaimService
    {
        private readonly IOperationClaimDal _operationClaimDal;

        public OperationClaimManager(IOperationClaimDal operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }

        public IDataResult<OperationClaim> GetById(int id)
        {
            return new SuccessDataResult<OperationClaim>(_operationClaimDal.Get(x => x.Id == id));
        }

        public IDataResult<List<OperationClaim>> GetList()
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationClaimDal.GetList().ToList());
        }

        public IResult Add(OperationClaim operationClaim)
        {
            //Business Code

            _operationClaimDal.Add(operationClaim);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(OperationClaim operationClaim)
        {
            //Business Code

            _operationClaimDal.Update(operationClaim);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(OperationClaim operationClaim)
        {
            //Business Code

            _operationClaimDal.Delete(operationClaim);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
