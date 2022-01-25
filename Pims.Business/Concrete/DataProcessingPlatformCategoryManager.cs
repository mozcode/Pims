using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class DataProcessingPlatformCategoryManager : IDataProcessingPlatformCategoryService
    {
        private readonly IDataProcessingPlatformCategoryDal _DataProcessingPlatformCategoryDal;

        public DataProcessingPlatformCategoryManager(IDataProcessingPlatformCategoryDal DataProcessingPlatformCategoryDal)
        {
            _DataProcessingPlatformCategoryDal = DataProcessingPlatformCategoryDal;
        }

        public IDataResult<DataProcessingPlatformCategory> GetById(int id)
        {
            return new SuccessDataResult<DataProcessingPlatformCategory>(_DataProcessingPlatformCategoryDal.Get(x => x.Id == id));
        }

        public IDataResult<List<DataProcessingPlatformCategory>> GetList()
        {
            return new SuccessDataResult<List<DataProcessingPlatformCategory>>(_DataProcessingPlatformCategoryDal.GetList().ToList());
        }

        public IResult Add(DataProcessingPlatformCategory DataProcessingPlatformCategory)
        {
            //Business Code

            _DataProcessingPlatformCategoryDal.Add(DataProcessingPlatformCategory);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(DataProcessingPlatformCategory DataProcessingPlatformCategory)
        {
            //Business Code

            _DataProcessingPlatformCategoryDal.Update(DataProcessingPlatformCategory);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(DataProcessingPlatformCategory DataProcessingPlatformCategory)
        {
            //Business Code

            _DataProcessingPlatformCategoryDal.Delete(DataProcessingPlatformCategory);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
