using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IDataResult<Company> GetById(int id)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Company>> GetList()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetList().ToList());
        }

        public IDataResult<List<Company>> GetListByCompanyTypeId(int companyTypeId)
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetList(x => x.CompanyTypeId == companyTypeId).ToList());
        }

        public IResult Add(Company company)
        {
            //Business Code

            _companyDal.Add(company);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(Company company)
        {
            //Business Code

            _companyDal.Update(company);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(Company company)
        {
            //Business Code

            _companyDal.Delete(company);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
