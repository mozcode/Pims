using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public IDataResult<Address> GetById(int id)
        {
            return new SuccessDataResult<Address>(_addressDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Address>> GetList()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetList().ToList());
        }

        public IResult Add(Address address)
        {
            //Business Code

            _addressDal.Add(address);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(Address address)
        {
            //Business Code

            _addressDal.Update(address);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(Address address)
        {
            //Business Code

            _addressDal.Delete(address);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
