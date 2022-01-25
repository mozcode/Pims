using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class AssetCategoryManager : IAssetCategoryService
    {
        private readonly IAssetCategoryDal _AssetCategoryDal;

        public AssetCategoryManager(IAssetCategoryDal AssetCategoryDal)
        {
            _AssetCategoryDal = AssetCategoryDal;
        }

        public IDataResult<AssetCategory> GetById(int id)
        {
            return new SuccessDataResult<AssetCategory>(_AssetCategoryDal.Get(x => x.Id == id));
        }

        public IDataResult<List<AssetCategory>> GetList()
        {
            return new SuccessDataResult<List<AssetCategory>>(_AssetCategoryDal.GetList().ToList());
        }

        public IResult Add(AssetCategory AssetCategory)
        {
            //Business Code

            _AssetCategoryDal.Add(AssetCategory);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(AssetCategory AssetCategory)
        {
            //Business Code

            _AssetCategoryDal.Update(AssetCategory);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(AssetCategory AssetCategory)
        {
            //Business Code

            _AssetCategoryDal.Delete(AssetCategory);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
