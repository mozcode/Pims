using System.Collections.Generic;
using Core.DataAccess;
using Pims.Entities.Concrete;

namespace Pims.DataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
