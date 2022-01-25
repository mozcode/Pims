using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pims.Entities.Concrete
{
    public class Asset : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int? ConfidentialityId { get; set; }

        public int? IntegrityId { get; set; }

        public int? AvailabilityId { get; set; }

        public int? LikelihoodOfHarmConfidentialityId { get; set; }

        public int? LikelihoodOfHarmIntegrityId { get; set; }

        public int? LikelihoodOfHarmAvailabilityId { get; set; }

        public int? SeverityOfHarmConfidentialityId { get; set; }

        public int? SeverityOfHarmIntegrityId { get; set; }

        public int? SeverityOfHarmAvailabilityId { get; set; }

        public int SuperAssetId { get; set; }

        public int AssetTypeId { get; set; }

        public int AssetCategoryId { get; set; }

        public string Name { get; set; }

        public string Explanation { get; set; }

        public bool Status { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime RemovedDate { get; set; }

        public int AffectionPercentageOfSuperAsset { get; set; }

        public AssetConfidentiality AssetConfidentiality { get; set; }

        public AssetIntegrity AssetIntegrity { get; set; }

        public AssetAvailability AssetAvailability { get; set; }

        public LikelihoodOfHarmConfidentiality LikelihoodOfHarmConfidentiality { get; set; }

        public LikelihoodOfHarmIntegrity LikelihoodOfHarmIntegrity { get; set; }

        public LikelihoodOfHarmAvailability LikelihoodOfHarmAvailability { get; set; }

        public SeverityOfHarmConfidentiality SeverityOfHarmConfidentiality { get; set; }

        public SeverityOfHarmIntegrity SeverityOfHarmIntegrity { get; set; }

        public SeverityOfHarmAvailability SeverityOfHarmAvailability { get; set; }

        public Asset SuperAsset { get; set; }

        public AssetType AssetType { get; set; }

        public AssetCategory AssetCategory { get; set; }

        public ICollection<AssetThirdPartyCategoryToGet> AssetThirdPartyCategoryToGets { get; set; }

        public ICollection<AssetThirdPartyCategoryToTransfer> AssetThirdPartyCategoryToTransfers { get; set; }
    }
}
