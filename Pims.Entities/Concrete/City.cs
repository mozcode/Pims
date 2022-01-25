using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class City : IEntity
    {
        [Key]
        public int Id { get; set; }

        public Country Country { get; set; }

        public ICollection<District> Districts { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }
    }
}