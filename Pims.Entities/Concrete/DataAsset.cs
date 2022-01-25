using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Pims.Entities.Concrete
{
    public class DataAsset : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int AssetId { get; set; }

        public int DataAssetCategoryId { get; set; }

        public int RetentionTimeId { get; set; }

        public int RetentionTimeTypeId { get; set; }

        public int DataOwnerCategoryId { get; set; }

        public int DataRecordTypeCategoryId { get; set; }

        public int RetentionTime { get; set; }

        public string GoalOfRecord { get; set; }

        public string NatureOfProcessing { get; set; }

        public string ScopeOfProcessing { get; set; }

        public string ContextOfProcessing { get; set; }

        public string PurposeOfProcessing { get; set; }

        public string ConsultationProcess { get; set; }

        public string NecessityProportionality { get; set; }

        public Asset Asset { get; set; }

        public DataAssetCategory DataAssetCategory { get; set; }

        public RetentionTimeType RetentionTimeType { get; set; }

        public DataOwnerCategory DataOwnerCategory { get; set; }

        public DataSourceCategory DataSourceCategory { get; set; }

        public DataRecordTypeCategory DataRecordTypeCategory { get; set; }
    }
}
