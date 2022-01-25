using Core.DataAccess.EntityFramework;
using Pims.DataAccess.Abstract;
using Pims.DataAccess.Concrete.EntityFramework.Contexts;
using Pims.Entities.Concrete;

namespace Pims.DataAccess.Concrete.EntityFramework
{
    public class EfAssetIntegrityDal: EfEntityRepositoryBase<AssetIntegrity, PimContext>,IAssetIntegrityDal
    {
       
    }
}
