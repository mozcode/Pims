using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Pims.Entities.Concrete
{
    public class Document : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public DocumentType DocumentType { get; set; }

        public int DocumentTypeId { get; set; }

        public string Url { get; set; }

        public string About { get; set; }

        public DateTime? ExpirationDate { get; set; }
    }
}