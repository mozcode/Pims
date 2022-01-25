using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class AssetAddressManager : IAssetAddressService
    {
        private readonly IAssetAddressDal _AssetAddressDal;

        public AssetAddressManager(IAssetAddressDal AssetAddressDal)
        {
            _AssetAddressDal = AssetAddressDal;
        }

        public IDataResult<AssetAddress> GetById(int id)
        {
            return new SuccessDataResult<AssetAddress>(_AssetAddressDal.Get(x => x.Id == id));
        }

        public IDataResult<List<AssetAddress>> GetList()
        {
            return new SuccessDataResult<List<AssetAddress>>(_AssetAddressDal.GetList().ToList());
        }

        public IResult Add(AssetAddress AssetAddress)
        {
            //Business Code

            _AssetAddressDal.Add(AssetAddress);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(AssetAddress AssetAddress)
        {
            //Business Code

            _AssetAddressDal.Update(AssetAddress);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(AssetAddress AssetAddress)
        {
            //Business Code

            _AssetAddressDal.Delete(AssetAddress);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
