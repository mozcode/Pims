using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class Department : IEntity
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public string Code { get; set; }

        public bool ViewInDepartmentList { get; set; }

        public ICollection<User> Users { get; set; }
    }
}