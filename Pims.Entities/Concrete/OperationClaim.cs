using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class OperationClaim: IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
