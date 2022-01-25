using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ICountryGroupService
    {
        IDataResult<CountryGroup> GetById(int id);

        IDataResult<List<CountryGroup>> GetList();

        IResult Add(CountryGroup CountryGroup);

        IResult Update(CountryGroup CountryGroup);

        IResult Delete(CountryGroup CountryGroup);
    }
}
