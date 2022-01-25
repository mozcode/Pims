using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class CompanyTypeManager : ICompanyTypeService
    {
        private readonly ICompanyTypeDal _companyTypeDal;

        public CompanyTypeManager(ICompanyTypeDal companyTypeDal)
        {
            _companyTypeDal = companyTypeDal;
        }

        public IDataResult<CompanyType> GetById(int id)
        {
            return new SuccessDataResult<CompanyType>(_companyTypeDal.Get(x => x.Id == id));
        }

        public IDataResult<List<CompanyType>> GetList()
        {
            return new SuccessDataResult<List<CompanyType>>(_companyTypeDal.GetList().ToList());
        }

        public IResult Add(CompanyType companyType)
        {
            //Business Code

            _companyTypeDal.Add(companyType);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(CompanyType companyType)
        {
            //Business Code

            _companyTypeDal.Update(companyType);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(CompanyType companyType)
        {
            //Business Code

            _companyTypeDal.Delete(companyType);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
