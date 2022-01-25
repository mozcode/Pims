using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class User : IEntity
    {
        public User()
        {
            Active = true;
        }

        [Key] public int Id { get; set; }
        public UserType UserType { get; set; }
        public UserTitle UserTitle { get; set; }
        public Company Company { get; set; }
        public Department Department { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName => FirstName + " " + LastName;
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string About { get; set; }
        public bool Active { get; set; }
        public int UserTypeId { get; set; }
        public int UserTitleId { get; set; }
        public int CompanyId { get; set; }
        public int? DepartmentId { get; set; }
    }
}
