using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        [Key] public int Id { get; set; }
        [Required] public int OperationClaimId { get; set; }
        [Required] public int UserId { get; set; }
        public OperationClaim OperationClaim { get; set; }
        public User User { get; set; }
    }
}
