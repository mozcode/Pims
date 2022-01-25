using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Pims.Entities.Concrete
{
    public class AssetThirdPartyCategoryToTransfer: IEntity
    {
        [Key]
        public int Id { get; set; }

        public Asset Asset { get; set; }

        public ThirdPartyCategoryToTransfer ThirdPartyCategoryToTransfer { get; set; }

        public ThirdPartyCategoryExplanation ThirdPartyCategoryExplanation { get; set; }

        public int AssetId { get; set; }

        public int ThirdPartyCategoryToTransferId { get; set; }

        public int ThirdPartyCategoryExplanationId { get; set; }
    }
}
