using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ICompanyTypeService
    {
        IDataResult<CompanyType> GetById(int id);

        IDataResult<List<CompanyType>> GetList();

        IResult Add(CompanyType companyType);

        IResult Update(CompanyType companyType);

        IResult Delete(CompanyType companyType);
    }
}
