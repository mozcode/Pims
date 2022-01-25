using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class Address : IEntity
    {
        [Key]
        public int Id { get; set; }

        public District District { get; set; }

        public CountryGroup CountryGroup { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public int? PostalCode { get; set; }

        public string FullAddress { get; set; }

        public string CoordinateX { get; set; }

        public string CoordinateY { get; set; }

        public int? DistrictId { get; set; }

        public int? CountryGroupId { get; set; }
    }
}