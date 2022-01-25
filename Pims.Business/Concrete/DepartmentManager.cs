using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public IDataResult<Department> GetById(int id)
        {
            return new SuccessDataResult<Department>(_departmentDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Department>> GetList()
        {
            return new SuccessDataResult<List<Department>>(_departmentDal.GetList().ToList());
        }

        public IResult Add(Department department)
        {
            //Business Code

            _departmentDal.Add(department);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(Department department)
        {
            //Business Code

            _departmentDal.Update(department);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(Department department)
        {
            //Business Code

            _departmentDal.Delete(department);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
