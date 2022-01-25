using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface ICityService
    {
        IDataResult<City> GetById(int id);

        IDataResult<List<City>> GetList();

        IResult Add(City city);

        IResult Update(City city);

        IResult Delete(City city);
    }
}
