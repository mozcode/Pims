using Core.DataAccess;
using Pims.Entities.Concrete;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using Pims.Entities.Dtos;

namespace Pims.DataAccess.Abstract
{
    public interface IAssetDal : IEntityRepository<Asset>
    {
        List<Asset> GetByAddress(Address address);

        Asset GetWType(Expression<Func<Asset, bool>> filter);

        Asset GetWCategory(Expression<Func<Asset, bool>> filter);

        Asset GetWSuper(Expression<Func<Asset, bool>> filter);

        Asset GetSuperAsset(Asset asset);

        Asset GetWCategoryWTypeWSuper(Expression<Func<Asset, bool>> filter);

        Asset GetWCategoryWTypeWSuperTWCategoryTWTypeTWSuper(Expression<Func<Asset, bool>> filter);

        Asset GetW3rdPartyCategory(Expression<Func<Asset, bool>> filter);

        AssetThirdPartyCategories GetW3rdPartyCategory(Asset asset);

        Asset GetW3rdPartyCategoryToGet(Expression<Func<Asset, bool>> filter);

        Asset GetW3rdPartyCategoryToTransfer(Expression<Func<Asset, bool>> filter);

        Asset GetWCategoryWTypeW3rdPartyCategoryWSuper(Expression<Func<Asset, bool>> filter);

        Asset GetWCategoryWTypeW3rdPartyCategoryWSuperTWCategoryTWTypeTW3rdPartyCategoryTWSuper(Expression<Func<Asset, bool>> filter);
    }
}
