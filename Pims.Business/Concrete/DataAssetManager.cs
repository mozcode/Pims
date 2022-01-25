using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class DataAssetManager : IDataAssetService
    {
        private readonly IDataAssetDal _DataAssetDal;

        public DataAssetManager(IDataAssetDal DataAssetDal)
        {
            _DataAssetDal = DataAssetDal;
        }

        public IDataResult<DataAsset> GetById(int id)
        {
            return new SuccessDataResult<DataAsset>(_DataAssetDal.Get(x => x.Id == id));
        }

        public IDataResult<List<DataAsset>> GetList()
        {
            return new SuccessDataResult<List<DataAsset>>(_DataAssetDal.GetList().ToList());
        }

        public IResult Add(DataAsset DataAsset)
        {
            //Business Code

            _DataAssetDal.Add(DataAsset);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(DataAsset DataAsset)
        {
            //Business Code

            _DataAssetDal.Update(DataAsset);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(DataAsset DataAsset)
        {
            //Business Code

            _DataAssetDal.Delete(DataAsset);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
