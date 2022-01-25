using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ICountryService
    {
        IDataResult<Country> GetById(int id);

        IDataResult<List<Country>> GetList();

        IResult Add(Country Country);

        IResult Update(Country Country);

        IResult Delete(Country Country);
    }
}
