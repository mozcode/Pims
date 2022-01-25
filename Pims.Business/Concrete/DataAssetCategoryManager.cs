using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class DataAssetCategoryManager : IDataAssetCategoryService
    {
        private readonly IDataAssetCategoryDal _DataAssetCategoryDal;

        public DataAssetCategoryManager(IDataAssetCategoryDal DataAssetCategoryDal)
        {
            _DataAssetCategoryDal = DataAssetCategoryDal;
        }

        public IDataResult<DataAssetCategory> GetById(int id)
        {
            return new SuccessDataResult<DataAssetCategory>(_DataAssetCategoryDal.Get(x => x.Id == id));
        }

        public IDataResult<List<DataAssetCategory>> GetList()
        {
            return new SuccessDataResult<List<DataAssetCategory>>(_DataAssetCategoryDal.GetList().ToList());
        }

        public IResult Add(DataAssetCategory DataAssetCategory)
        {
            //Business Code

            _DataAssetCategoryDal.Add(DataAssetCategory);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(DataAssetCategory DataAssetCategory)
        {
            //Business Code

            _DataAssetCategoryDal.Update(DataAssetCategory);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(DataAssetCategory DataAssetCategory)
        {
            //Business Code

            _DataAssetCategoryDal.Delete(DataAssetCategory);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
