using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IRetentionTimeTypeService
    {
        IDataResult<RetentionTimeType> GetById(int id);

        IDataResult<List<RetentionTimeType>> GetList();

        IResult Add(RetentionTimeType RetentionTimeType);

        IResult Update(RetentionTimeType RetentionTimeType);

        IResult Delete(RetentionTimeType RetentionTimeType);
    }
}
