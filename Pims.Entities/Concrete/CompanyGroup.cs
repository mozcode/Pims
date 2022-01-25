using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class CompanyGroup : IEntity
    {
        [Key] public int Id { get; set; }
        public ICollection<Company> Companies { get; set; }
        public string Name { get; set; }
    }
}