using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IDataSourceCategoryService
    {
        IDataResult<DataSourceCategory> GetById(int id);

        IDataResult<List<DataSourceCategory>> GetList();

        IResult Add(DataSourceCategory DataSourceCategory);

        IResult Update(DataSourceCategory DataSourceCategory);

        IResult Delete(DataSourceCategory DataSourceCategory);
    }
}
