using Pims.Entities.Concrete;
using Core.Entities;
using System.Collections.Generic;

namespace Pims.Entities.Dtos
{
    public class AssetThirdPartyCategories : IDto
    {
        public Asset Asset { get; set; }

        public List<AssetThirdPartyCategoryToGet> AssetThirdPartyCategoryToGets { get; set; }

        public List<AssetThirdPartyCategoryToTransfer> AssetThirdPartyCategoryToTransfers { get; set; }
    }
}
