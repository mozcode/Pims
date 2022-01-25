using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class Company : IEntity
    {
        [Key] public int Id { get; set; }
        public CompanyGroup CompanyGroup { get; set; }
        public CompanyType CompanyType { get; set; }
        public string Name { get; set; }
        public int CompanyGroupId { get; set; }
        public int CompanyTypeId { get; set; }
        public ICollection<User> Users { get; set; }
    }
}