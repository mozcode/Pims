using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Pims.Entities.Concrete
{
    public class AssetLegalBasis : IEntity
    {
        [Key]
        public int Id { get; set; }

        public Asset Asset { get; set; }

        public LegalBasis LegalBasis { get; set; }

        public string Explanation { get; set; }

        public int AssetId { get; set; }

        public int LegalBasisId { get; set; }
    }
}
