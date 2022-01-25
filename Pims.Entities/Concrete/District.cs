using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class District : IEntity
    {
        public City City { get; set; }

        public ICollection<Address> Addresses { get; set; }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int CityId { get; set; }
    }
}