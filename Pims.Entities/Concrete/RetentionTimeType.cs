using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Pims.Entities.Concrete
{
    public class RetentionTimeType : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }
    }
}
