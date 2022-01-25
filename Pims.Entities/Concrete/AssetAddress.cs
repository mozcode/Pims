using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Pims.Entities.Concrete
{
    public class AssetAddress : IEntity
    {
        [Key]
        public int Id { get; set; }

        public Asset Asset { get; set; }

        public Address Address { get; set; }

        public int AssetId { get; set; }

        public int AddressId { get; set; }
    }
}
