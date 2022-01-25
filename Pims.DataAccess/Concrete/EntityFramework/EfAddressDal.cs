using Core.DataAccess.EntityFramework;
using Pims.DataAccess.Abstract;
using Pims.DataAccess.Concrete.EntityFramework.Contexts;
using Pims.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Pims.DataAccess.Concrete.EntityFramework
{
    public class EfAddressDal : EfEntityRepositoryBase<Address, PimContext>, IAddressDal
    {
        public List<Address> GetAddressesByAsset(Asset asset)
        {
            using (var context = new PimContext())
            {
                var result = from address in context.Addresses
                             join assetAddress in context.AssetAddresses on address.Id equals assetAddress.AddressId
                             join assets in context.Assets on assetAddress.AssetId equals assets.Id
                             where asset.Id == assets.Id
                             select address;

                return result.ToList();
            }
        }

        public List<Address> GetAddressesByDistrict(District district)
        {
            using (var context = new PimContext())
            {
                var result = from address in context.Addresses
                             join districts in context.Districts on address.DistrictId equals districts.Id
                             where district.Id == districts.Id
                             select address;

                return result.ToList();
            }
        }

        public List<Address> GetAddressesByCity(City city)
        {
            using (var context = new PimContext())
            {
                var result = from address in context.Addresses
                             join district in context.Districts on address.DistrictId equals district.Id
                             join cities in context.Cities on district.CityId equals cities.Id
                             where city.Id == cities.Id
                             select address;

                return result.ToList();
            }
        }

        public List<Address> GetAddressesByCountryGroup(CountryGroup countryGroup)
        {
            using (var context = new PimContext())
            {
                var result = from address in context.Addresses
                             join countryGroups in context.CountryGroups on address.CountryGroupId equals countryGroups.Id
                             where countryGroup.Id == countryGroups.Id
                             select address;

                return result.ToList();
            }
        }
    }
}
