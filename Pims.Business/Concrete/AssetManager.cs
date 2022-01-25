using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class AssetManager : IAssetService
    {
        private readonly IAssetDal _AssetDal;

        public AssetManager(IAssetDal AssetDal)
        {
            _AssetDal = AssetDal;
        }

        public IDataResult<Asset> GetById(int id)
        {
            return new SuccessDataResult<Asset>(_AssetDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Asset>> GetList()
        {
            return new SuccessDataResult<List<Asset>>(_AssetDal.GetList().ToList());
        }

        public IResult Add(Asset Asset)
        {
            //Business Code

            _AssetDal.Add(Asset);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(Asset Asset)
        {
            //Business Code

            _AssetDal.Update(Asset);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(Asset Asset)
        {
            //Business Code

            _AssetDal.Delete(Asset);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
