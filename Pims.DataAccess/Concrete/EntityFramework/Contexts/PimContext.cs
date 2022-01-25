using System.Linq;
using Pims.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Pims.DataAccess.Concrete.EntityFramework.Contexts
{
    public class PimContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Pim;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        #region Manage
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetAddress> AssetAddresses { get; set; }
        public DbSet<AssetAvailability> AssetAvailabilities { get; set; }
        public DbSet<AssetCategory> AssetCategories { get; set; }
        public DbSet<AssetConfidentiality> AssetConfidentialities { get; set; }
        public DbSet<AssetIntegrity> AssetIntegrities { get; set; }
        public DbSet<AssetLegalBasis> AssetLegalBases { get; set; }
        public DbSet<AssetThirdPartyCategoryToGet> AssetThirdPartyCategoryToGets { get; set; }
        public DbSet<AssetThirdPartyCategoryToTransfer> AssetThirdPartyCategoryToTransfers { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryGroup> CountryGroups { get; set; }
        public DbSet<DataAsset> DataAssets { get; set; }
        public DbSet<DataAssetCategory> DataAssetCategories { get; set; }
        public DbSet<DataOwnerCategory> DataOwnerCategories { get; set; }
        public DbSet<DataProcessingPlatformCategory> DataProcessingPlatformCategories { get; set; }
        public DbSet<DataRecordTypeCategory> DataRecordTypeCategories { get; set; }
        public DbSet<DataSourceCategory> DataSourceCategories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<LegalBasis> LegalBases { get; set; }
        public DbSet<LikelihoodOfHarmAvailability> LikelihoodOfHarmAvailabilities { get; set; }
        public DbSet<LikelihoodOfHarmConfidentiality> LikelihoodOfHarmConfidentialities { get; set; }
        public DbSet<LikelihoodOfHarmIntegrity> LikelihoodOfHarmIntegrities { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<RetentionTimeType> RetentionTimeTypes { get; set; }
        public DbSet<SeverityOfHarmAvailability> SeverityOfHarmAvailabilities { get; set; }
        public DbSet<SeverityOfHarmConfidentiality> SeverityOfHarmConfidentialities { get; set; }
        public DbSet<SeverityOfHarmIntegrity> SeverityOfHarmIntegrities { get; set; }
        public DbSet<ThirdPartyCategoryToGet> ThirdPartyCategoryToGets { get; set; }
        public DbSet<ThirdPartyCategoryExplanation> ThirdPartyCategoryExplanations { get; set; }
        public DbSet<ThirdPartyCategoryToTransfer> ThirdPartyCategoryToTransfers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<UserTitle> UserTitles { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        #endregion
    }
}
