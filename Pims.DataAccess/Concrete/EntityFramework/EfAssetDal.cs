using Core.DataAccess.EntityFramework;
using Pims.DataAccess.Abstract;
using Pims.DataAccess.Concrete.EntityFramework.Contexts;
using Pims.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System;
using Microsoft.EntityFrameworkCore;
using Pims.Entities.Dtos;

namespace Pims.DataAccess.Concrete.EntityFramework
{
    public class EfAssetDal : EfEntityRepositoryBase<Asset, PimContext>, IAssetDal
    {
        public List<Asset> GetByAddress(Address address)
        {
            using (var context = new PimContext())
            {
                var result = from asset in context.Assets
                             join assetAddress in context.AssetAddresses on asset.Id equals assetAddress.AssetId
                             join addresses in context.Addresses on assetAddress.AssetId equals addresses.Id
                             where address.Id == addresses.Id
                             select asset;

                return result.ToList();
            }
        }

        public Asset GetWType(Expression<Func<Asset, bool>> filter)
        {
            using var context = new PimContext();
            return context.Assets.Include(a => a.AssetType).SingleOrDefault(filter);
        }

        public Asset GetWCategory(Expression<Func<Asset, bool>> filter)
        {
            using var context = new PimContext();
            return context.Assets.Include(a => a.AssetCategory).SingleOrDefault(filter);
        }

        public Asset GetWSuper(Expression<Func<Asset, bool>> filter)
        {
            using var context = new PimContext();
            return context.Assets.Include(a => a.SuperAsset).SingleOrDefault(filter);
        }

        public Asset GetSuperAsset(Asset asset)
        {
            using var context = new PimContext();
            return context.Assets.SingleOrDefault(a => a.Id == asset.SuperAssetId);
        }

        public Asset GetWCategoryWTypeWSuper(Expression<Func<Asset, bool>> filter)
        {
            using var context = new PimContext();
            return context.Assets.Include(a => a.AssetCategory).Include(a => a.AssetType).Include(a => a.SuperAsset).SingleOrDefault(filter);
        }

        public Asset GetWCategoryWTypeWSuperTWCategoryTWTypeTWSuper(Expression<Func<Asset, bool>> filter)
        {
            using var context = new PimContext();
            return context.Assets.Include(a => a.AssetCategory).Include(a => a.AssetType).Include(a => a.SuperAsset).Include(a => a.SuperAsset.AssetCategory).Include(a => a.SuperAsset.AssetType).Include(a => a.SuperAsset.SuperAsset).SingleOrDefault(filter);
        }

        public Asset GetW3rdPartyCategory(Expression<Func<Asset, bool>> filter)
        {
            using var context = new PimContext();
            return context.Assets.Include(a => a.AssetThirdPartyCategoryToGets).ThenInclude(tpg => tpg.ThirdPartyCategoryToGet).Include(a => a.AssetThirdPartyCategoryToGets).ThenInclude(tpg2 => tpg2.ThirdPartyCategoryExplanation).Include(a => a.AssetThirdPartyCategoryToTransfers).ThenInclude(tpt => tpt.ThirdPartyCategoryToTransfer).Include(a => a.AssetThirdPartyCategoryToTransfers).ThenInclude(tpt2 => tpt2.ThirdPartyCategoryExplanation).SingleOrDefault(filter);
        }

        public AssetThirdPartyCategories GetW3rdPartyCategory(Asset asset)
        {
            using (var context = new PimContext())
            {
                var result = (from assets in context.Assets
                             join assetThirdPartyCategoryToGet in context.AssetThirdPartyCategoryToGets.Include(g => g.ThirdPartyCategoryToGet).Include(g => g.ThirdPartyCategoryExplanation) on assets.Id equals assetThirdPartyCategoryToGet.AssetId
                             join assetThirdPartyCategoryToTransfer in context.AssetThirdPartyCategoryToTransfers.Include(g => g.ThirdPartyCategoryToTransfer).Include(g => g.ThirdPartyCategoryExplanation) on assets.Id equals assetThirdPartyCategoryToTransfer.AssetId
                             where assets.Id == asset.Id
                             select new AssetThirdPartyCategories
                             {
                                 Asset = assets,
                                 AssetThirdPartyCategoryToGets = new List<AssetThirdPartyCategoryToGet>() { assetThirdPartyCategoryToGet },
                                 AssetThirdPartyCategoryToTransfers = new List<AssetThirdPartyCategoryToTransfer>() { assetThirdPartyCategoryToTransfer }
                             }).SingleOrDefault();

                return result;
            }
        }

        public Asset GetWCategoryWTypeW3rdPartyCategoryWSuper(Expression<Func<Asset, bool>> filter)
        {
            using var context = new PimContext();
            return context.Assets.Include(a => a.AssetCategory).Include(a => a.AssetType).Include(a => a.AssetThirdPartyCategoryToGets).ThenInclude(tpg => tpg.ThirdPartyCategoryToGet).Include(a => a.AssetThirdPartyCategoryToGets).ThenInclude(tpg2 => tpg2.ThirdPartyCategoryExplanation).Include(a => a.AssetThirdPartyCategoryToTransfers).ThenInclude(tpt => tpt.ThirdPartyCategoryToTransfer).Include(a => a.AssetThirdPartyCategoryToTransfers).ThenInclude(tpt2 => tpt2.ThirdPartyCategoryExplanation).Include(a => a.SuperAsset).SingleOrDefault(filter);
        }

        public Asset GetWCategoryWTypeW3rdPartyCategoryWSuperTWCategoryTWTypeTW3rdPartyCategoryTWSuper(Expression<Func<Asset, bool>> filter)
        {
            using var context = new PimContext();
            return context.Assets.Include(a => a.AssetCategory).Include(a => a.AssetType).Include(a => a.AssetThirdPartyCategoryToGets).ThenInclude(tpg => tpg.ThirdPartyCategoryToGet).Include(a => a.AssetThirdPartyCategoryToGets).ThenInclude(tpg => tpg.ThirdPartyCategoryExplanation).Include(a => a.AssetThirdPartyCategoryToTransfers).ThenInclude(tpt => tpt.ThirdPartyCategoryToTransfer).Include(a => a.AssetThirdPartyCategoryToTransfers).ThenInclude(tpt => tpt.ThirdPartyCategoryExplanation).Include(a => a.SuperAsset).ThenInclude(sa => sa.AssetCategory).Include(a => a.SuperAsset).ThenInclude(sa => sa.AssetType).Include(a => a.SuperAsset).ThenInclude(sa => sa.AssetThirdPartyCategoryToGets).ThenInclude(tpg2 => tpg2.ThirdPartyCategoryToGet).Include(a => a.SuperAsset).ThenInclude(sa => sa.AssetThirdPartyCategoryToGets).ThenInclude(tpg2 => tpg2.ThirdPartyCategoryExplanation).Include(a => a.SuperAsset).ThenInclude(sa => sa.AssetThirdPartyCategoryToTransfers).ThenInclude(tpt2 => tpt2.ThirdPartyCategoryToTransfer).Include(a => a.SuperAsset).ThenInclude(sa => sa.AssetThirdPartyCategoryToTransfers).ThenInclude(tpt2 => tpt2.ThirdPartyCategoryExplanation).SingleOrDefault(filter);
        }

        public Asset GetW3rdPartyCategoryToGet(Expression<Func<Asset, bool>> filter)
        {
            using var context = new PimContext();
            return context.Assets.Include(a => a.AssetThirdPartyCategoryToGets).ThenInclude(tpg => tpg.ThirdPartyCategoryToGet).Include(a => a.AssetThirdPartyCategoryToGets).ThenInclude(tpg2 => tpg2.ThirdPartyCategoryExplanation).SingleOrDefault(filter);
        }

        public Asset GetW3rdPartyCategoryToTransfer(Expression<Func<Asset, bool>> filter)
        {
            using var context = new PimContext();
            return context.Assets.Include(a => a.AssetThirdPartyCategoryToTransfers).ThenInclude(tpt => tpt.ThirdPartyCategoryToTransfer).Include(a => a.AssetThirdPartyCategoryToTransfers).ThenInclude(tpt2 => tpt2.ThirdPartyCategoryExplanation).SingleOrDefault(filter);
        }
    }
}
