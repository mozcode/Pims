using Core.DataAccess;
using Pims.Entities.Concrete;
using System.Collections.Generic;

namespace Pims.DataAccess.Abstract
{
    public interface IAddressDal: IEntityRepository<Address>
    {
        List<Address> GetAddressesByAsset(Asset asset);
        List<Address> GetAddressesByDistrict(District district);
        List<Address> GetAddressesByCity(City city);
        List<Address> GetAddressesByCountryGroup(CountryGroup countryGroup);
    }
}
