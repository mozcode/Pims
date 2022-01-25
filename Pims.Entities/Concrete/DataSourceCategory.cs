﻿using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pims.Entities.Concrete
{
    public class DataSourceCategory : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public ICollection<DataAsset> DataAssets { get; set; }
    }
}