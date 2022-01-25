﻿using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Pims.Entities.Concrete
{
    public class AssetThirdPartyCategoryToGet : IEntity
    {
        [Key]
        public int Id { get; set; }

        public Asset Asset { get; set; }

        public ThirdPartyCategoryToGet ThirdPartyCategoryToGet { get; set; }

        public ThirdPartyCategoryExplanation ThirdPartyCategoryExplanation { get; set; }

        public int AssetId { get; set; }

        public int ThirdPartyCategoryToGetId { get; set; }

        public int ThirdPartyCategoryExplanationId { get; set; }
    }
}