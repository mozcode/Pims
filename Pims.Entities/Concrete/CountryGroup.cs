using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class CountryGroup : IEntity
    {
        public ICollection<Country> Countries { get; set; }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}