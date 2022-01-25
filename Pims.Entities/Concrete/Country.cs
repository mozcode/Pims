using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class Country : IEntity
    {

        [Key]
        public int Id { get; set; }

        public int? CountryGroupId { get; set; }

        public string Name { get; set; }

        public CountryGroup CountryGroup { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}