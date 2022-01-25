using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IAddressService
    {
        IDataResult<Address> GetById(int id);

        IDataResult<List<Address>> GetList();

        IResult Add(Address address);

        IResult Update(Address address);

        IResult Delete(Address address);
    }
}
