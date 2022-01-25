using Core.DataAccess;
using Pims.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Pims.DataAccess.Abstract
{
    public interface ICompanyDal: IEntityRepository<Company>
    {
        Company GetByUser(User user);
        Company GetWTypeByUser(User user);
        Company GetWGroupByUser(User user);
        Company GetWTypeWGroupByUser(User user);
        Company GetWType(Expression<Func<Company, bool>> filter);
        Company GetWGroup(Expression<Func<Company, bool>> filter);
        Company GetWTypeWGroup(Expression<Func<Company, bool>> filter);
    }
}
