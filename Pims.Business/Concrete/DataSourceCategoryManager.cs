using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class DataSourceCategoryManager : IDataSourceCategoryService
    {
        private readonly IDataSourceCategoryDal _DataSourceCategoryDal;

        public DataSourceCategoryManager(IDataSourceCategoryDal DataSourceCategoryDal)
        {
            _DataSourceCategoryDal = DataSourceCategoryDal;
        }

        public IDataResult<DataSourceCategory> GetById(int id)
        {
            return new SuccessDataResult<DataSourceCategory>(_DataSourceCategoryDal.Get(x => x.Id == id));
        }

        public IDataResult<List<DataSourceCategory>> GetList()
        {
            return new SuccessDataResult<List<DataSourceCategory>>(_DataSourceCategoryDal.GetList().ToList());
        }

        public IResult Add(DataSourceCategory DataSourceCategory)
        {
            //Business Code

            _DataSourceCategoryDal.Add(DataSourceCategory);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(DataSourceCategory DataSourceCategory)
        {
            //Business Code

            _DataSourceCategoryDal.Update(DataSourceCategory);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(DataSourceCategory DataSourceCategory)
        {
            //Business Code

            _DataSourceCategoryDal.Delete(DataSourceCategory);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
