using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IDepartmentService
    {
        IDataResult<Department> GetById(int id);

        IDataResult<List<Department>> GetList();

        IResult Add(Department department);

        IResult Update(Department department);

        IResult Delete(Department department);
    }
}
