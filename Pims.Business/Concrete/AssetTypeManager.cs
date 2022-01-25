using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class AssetTypeManager : IAssetTypeService
    {
        private readonly IAssetTypeDal _AssetTypeDal;

        public AssetTypeManager(IAssetTypeDal AssetTypeDal)
        {
            _AssetTypeDal = AssetTypeDal;
        }

        public IDataResult<AssetType> GetById(int id)
        {
            return new SuccessDataResult<AssetType>(_AssetTypeDal.Get(x => x.Id == id));
        }

        public IDataResult<List<AssetType>> GetList()
        {
            return new SuccessDataResult<List<AssetType>>(_AssetTypeDal.GetList().ToList());
        }

        public IResult Add(AssetType AssetType)
        {
            //Business Code

            _AssetTypeDal.Add(AssetType);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(AssetType AssetType)
        {
            //Business Code

            _AssetTypeDal.Update(AssetType);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(AssetType AssetType)
        {
            //Business Code

            _AssetTypeDal.Delete(AssetType);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
