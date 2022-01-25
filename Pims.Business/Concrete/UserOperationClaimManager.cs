using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        private readonly IUserOperationClaimDal _userOperationClaimDal;

        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal)
        {
            _userOperationClaimDal = userOperationClaimDal;
        }

        public IDataResult<UserOperationClaim> GetById(int id)
        {
            return new SuccessDataResult<UserOperationClaim>(_userOperationClaimDal.Get(x => x.Id == id));
        }

        public IDataResult<List<UserOperationClaim>> GetList()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaimDal.GetList().ToList());
        }

        public IResult Add(UserOperationClaim userOperationClaim)
        {
            //Business Code

            _userOperationClaimDal.Add(userOperationClaim);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(UserOperationClaim userOperationClaim)
        {
            //Business Code

            _userOperationClaimDal.Update(userOperationClaim);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(UserOperationClaim userOperationClaim)
        {
            //Business Code

            _userOperationClaimDal.Delete(userOperationClaim);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
