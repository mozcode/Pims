using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class UserTitle : IEntity
    {
        public UserTitle()
        {
            ViewInUserTitleList = true;
        }

        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public bool ViewInUserTitleList { get; set; }
        public ICollection<User> Users { get; set; }
    }
}