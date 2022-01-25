using Autofac;
using Pims.Business.Abstract;
using Pims.Business.Concrete;
using Pims.DataAccess.Abstract;
using Pims.DataAccess.Concrete.EntityFramework;
using Pims.Entities.Concrete;

namespace Pims.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AddressManager>().As<IAddressService>();
            builder.RegisterType<EfAddressDal>().As<IAddressDal>();

            builder.RegisterType<AssetManager>().As<IAssetService>();
            builder.RegisterType<EfAssetTypeDal>().As<IAssetDal>();

            builder.RegisterType<AssetAddressManager>().As<IAssetAddressService>();
            builder.RegisterType<EfAssetAddressDal>().As<IAssetAddressDal>();

            builder.RegisterType<AssetAvailabilityManager>().As<IAssetAddressService>();
            builder.RegisterType<EfAssetAvailabilityDal>().As<IAssetAvailabilityDal>();

            builder.RegisterType<AssetCategoryManager>().As<IAssetCategoryService>();
            builder.RegisterType<EfAssetCategoryDal>().As<IAssetCategoryService>();

            builder.RegisterType<AssetConfidentialityManager>().As<IAssetConfidentialityService>();
            builder.RegisterType<EfAssetConfidentialityDal>().As<IAssetConfidentialityDal>();

            builder.RegisterType<AssetIntegrityManager>().As<IAssetIntegrityService>();
            builder.RegisterType<EfAssetIntegrityDal>().As<IAssetIntegrityDal>();

            builder.RegisterType<AssetLegalBasisManager>().As<IAssetLegalBasisService>();
            builder.RegisterType<EfAssetLegalBasisDal>().As<IAssetLegalBasisDal>();

            builder.RegisterType<AssetThirdPartyCategoryToGetManager>().As<IAssetThirdPartyCategoryToGetService>();
            builder.RegisterType<EfAssetThirdPartyCategoryToGetDal>().As<IAssetThirdPartyCategoryToGetDal>();

            builder.RegisterType<AssetThirdPartyCategoryToTransferManager>().As<IAssetThirdPartyCategoryToTransferService>();
            builder.RegisterType<EfAssetThirdPartyCategoryToTransferDal>().As<IAssetThirdPartyCategoryToTransferDal>();

            builder.RegisterType<AssetTypeManager>().As<IAssetTypeService>();
            builder.RegisterType<EfAssetTypeDal>().As<IAssetTypeDal>();

            builder.RegisterType<CompanyManager>().As<ICompanyService>();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>();

            builder.RegisterType<CompanyGroupManager>().As<ICompanyGroupService>();
            builder.RegisterType<EfCompanyGroupDal>().As<ICompanyGroupDal>();

            builder.RegisterType<DataAssetManager>().As<IDataAssetService>();
            builder.RegisterType<EfDataAssetDal>().As<IDataAssetDal>();

            builder.RegisterType<DataAssetCategoryManager>().As<IDataAssetCategoryService>();
            builder.RegisterType<EfDataAssetCategoryDal>().As<IDataAssetCategoryDal>();

            builder.RegisterType<DataOwnerCategoryManager>().As<IDataOwnerCategoryService>();
            builder.RegisterType<EfDataOwnerCategoryDal>().As<IDataOwnerCategoryDal>();

            builder.RegisterType<DataProcessingPlatformCategoryManager>().As<IDataProcessingPlatformCategoryService>();
            builder.RegisterType<EfDataProcessingPlatformCategoryDal>().As<IDataProcessingPlatformCategoryDal>();

            builder.RegisterType<DataRecordTypeCategoryManager>().As<IDataRecordTypeCategoryService>();
            builder.RegisterType<EfDataRecordTypeCategoryDal>().As<IDataRecordTypeCategoryService>();

            builder.RegisterType<DataSourceCategoryManager>().As<IDataSourceCategoryService>();
            builder.RegisterType<EfDataSourceCategoryDal>().As<IDataSourceCategoryDal>();

            builder.RegisterType<DepartmentManager>().As<IDepartmentService>();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>();

            builder.RegisterType<DocumentManager>().As<IDocumentService>();
            builder.RegisterType<EfDocumentDal>().As<IDocumentDal>();

            builder.RegisterType<LegalBasisManager>().As<ILegalBasisService>();
            builder.RegisterType<EfLegalBasisDal>().As<ILegalBasisDal>();

            builder.RegisterType<LikelihoodOfHarmAvailabilityManager>().As<ILikelihoodOfHarmAvailabilityService>();
            builder.RegisterType<EfLikelihoodOfHarmAvailabilityDal>().As<ILikelihoodOfHarmAvailabilityDal>();

            builder.RegisterType<LikelihoodOfHarmConfidentialityManager>().As<ILikelihoodOfHarmConfidentialityService>();
            builder.RegisterType<EfLikelihoodOfHarmConfidentialityDal>().As<ILikelihoodOfHarmConfidentialityDal>();

            builder.RegisterType<LikelihoodOfHarmIntegrityManager>().As<ILikelihoodOfHarmIntegrityService>();
            builder.RegisterType<EfLikelihoodOfHarmIntegrityDal>().As<ILikelihoodOfHarmIntegrityDal>();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();

            builder.RegisterType<RetentionTimeTypeManager>().As<IRetentionTimeTypeService>();
            builder.RegisterType<EfRetentionTimeTypeDal>().As<IRetentionTimeTypeDal>();

            builder.RegisterType<SeverityOfHarmAvailabilityManager>().As<ISeverityOfHarmAvailabilityService>();
            builder.RegisterType<EfSeverityOfHarmAvailabilityDal>().As<ISeverityOfHarmAvailabilityDal>();

            builder.RegisterType<SeverityOfHarmConfidentialityManager>().As<ISeverityOfHarmConfidentialityService>();
            builder.RegisterType<EfSeverityOfHarmConfidentialityDal>().As<ISeverityOfHarmConfidentialityDal>();

            builder.RegisterType<SeverityOfHarmIntegrityManager>().As<ISeverityOfHarmIntegrityService>();
            builder.RegisterType<EfSeverityOfHarmIntegrityDal>().As<ISeverityOfHarmIntegrityDal>();

            builder.RegisterType<ThirdPartyCategoryToGetManager>().As<IThirdPartyCategoryToGetService>();
            builder.RegisterType<EfThirdPartyCategoryToGetDal>().As<IThirdPartyCategoryToGetDal>();

            builder.RegisterType<ThirdPartyCategoryToTransferManager>().As<IThirdPartyCategoryToTransferService>();
            builder.RegisterType<EfThirdPartyCategoryToTransferDal>().As<IThirdPartyCategoryToTransferDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

            builder.RegisterType<UserTitleManager>().As<IUserTitleService>();
            builder.RegisterType<EfUserTitleDal>().As<IUserTitleDal>();

            builder.RegisterType<UserTypeManager>().As<IUserTypeService>();
            builder.RegisterType<EfUserTypeDal>().As<IUserTypeDal>();
        }
    }
}
