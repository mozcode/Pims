using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Pims.Entities.Concrete
{
    public  class SeverityOfHarmIntegrity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int Degree { get; set; }

        public string Name { get; set; }

        public string Definition { get; set; }

        public bool Status { get; set; }
    }
}
