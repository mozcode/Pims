using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IDistrictService
    {
        IDataResult<District> GetById(int id);

        IDataResult<List<District>> GetList();

        IDataResult<List<District>> GetListByCityId(int cityId);

        IResult Add(District district);

        IResult Update(District district);

        IResult Delete(District district);
    }
}
