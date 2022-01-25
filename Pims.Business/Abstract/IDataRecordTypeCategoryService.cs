using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IDataRecordTypeCategoryService
    {
        IDataResult<DataRecordTypeCategory> GetById(int id);

        IDataResult<List<DataRecordTypeCategory>> GetList();

        IResult Add(DataRecordTypeCategory DataRecordTypeCategory);

        IResult Update(DataRecordTypeCategory DataRecordTypeCategory);

        IResult Delete(DataRecordTypeCategory DataRecordTypeCategory);
    }
}
