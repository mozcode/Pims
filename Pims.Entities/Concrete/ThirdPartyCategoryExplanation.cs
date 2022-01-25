using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pims.Entities.Concrete
{
    public class ThirdPartyCategoryExplanation : IEntity
    {
        [Key]
        public int Id { get; set; }

        public ICollection<AssetThirdPartyCategoryToGet> AssetThirdPartyCategoriesToGet { get; set; }

        public ICollection<AssetThirdPartyCategoryToTransfer> AssetThirdPartyCategoriesToTransfer { get; set; }

        public string Explanation { get; set; }

        public bool Active { get; set; }
    }
}
