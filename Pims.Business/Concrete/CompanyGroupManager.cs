using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class CompanyGroupManager : ICompanyGroupService
    {
        private readonly ICompanyGroupDal _companyGroupDal;

        public CompanyGroupManager(ICompanyGroupDal companyGroupDal)
        {
            _companyGroupDal = companyGroupDal;
        }

        public IDataResult<CompanyGroup> GetById(int id)
        {
            return new SuccessDataResult<CompanyGroup>(_companyGroupDal.Get(x => x.Id == id));
        }

        public IDataResult<List<CompanyGroup>> GetList()
        {
            return new SuccessDataResult<List<CompanyGroup>>(_companyGroupDal.GetList().ToList());
        }

        public IResult Add(CompanyGroup companyGroup)
        {
            //Business Code

            _companyGroupDal.Add(companyGroup);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(CompanyGroup companyGroup)
        {
            //Business Code

            _companyGroupDal.Update(companyGroup);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(CompanyGroup companyGroup)
        {
            //Business Code

            _companyGroupDal.Delete(companyGroup);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
