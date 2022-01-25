using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IDataResult<UserOperationClaim> GetById(int id);

        IDataResult<List<UserOperationClaim>> GetList();

        IResult Add(UserOperationClaim userOperationClaim);

        IResult Update(UserOperationClaim userOperationClaim);

        IResult Delete(UserOperationClaim userOperationClaim);
    }
}
