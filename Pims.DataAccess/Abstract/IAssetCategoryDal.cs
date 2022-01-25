using Core.DataAccess;
using Pims.Entities.Concrete;

namespace Pims.DataAccess.Abstract
{
    public interface IAssetCategoryDal : IEntityRepository<AssetCategory>
    {
        AssetCategory GetByAsset(Asset asset);
    }
}
