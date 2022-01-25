using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ICompanyGroupService
    {
        IDataResult<CompanyGroup> GetById(int id);

        IDataResult<List<CompanyGroup>> GetList();

        IResult Add(CompanyGroup companyGroup);

        IResult Update(CompanyGroup companyGroup);

        IResult Delete(CompanyGroup companyGroup);
    }
}
