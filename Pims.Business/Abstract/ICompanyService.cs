using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ICompanyService
    {
        IDataResult<Company> GetById(int id);

        IDataResult<List<Company>> GetList();

        IDataResult<List<Company>> GetListByCompanyTypeId(int companyTypeId);

        IResult Add(Company company);

        IResult Update(Company company);

        IResult Delete(Company company);
    }
}
