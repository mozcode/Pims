using Core.DataAccess.EntityFramework;
using Pims.DataAccess.Abstract;
using Pims.DataAccess.Concrete.EntityFramework.Contexts;
using Pims.Entities.Concrete;
using System.Linq;

namespace Pims.DataAccess.Concrete.EntityFramework
{
    public class EfAssetCategoryDal : EfEntityRepositoryBase<AssetCategory, PimContext>, IAssetCategoryDal
    {
        public AssetCategory GetByAsset(Asset asset)
        {
            using var context = new PimContext();
            return context.AssetCategories.SingleOrDefault(x => x.Id == asset.AssetCategoryId);
        }
    }
}
