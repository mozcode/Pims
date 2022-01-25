using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class CountryGroupManager : ICountryGroupService
    {
        private readonly ICountryGroupDal _CountryGroupDal;

        public CountryGroupManager(ICountryGroupDal CountryGroupDal)
        {
            _CountryGroupDal = CountryGroupDal;
        }

        public IDataResult<CountryGroup> GetById(int id)
        {
            return new SuccessDataResult<CountryGroup>(_CountryGroupDal.Get(x => x.Id == id));
        }

        public IDataResult<List<CountryGroup>> GetList()
        {
            return new SuccessDataResult<List<CountryGroup>>(_CountryGroupDal.GetList().ToList());
        }

        public IResult Add(CountryGroup CountryGroup)
        {
            //Business Code

            _CountryGroupDal.Add(CountryGroup);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(CountryGroup CountryGroup)
        {
            //Business Code

            _CountryGroupDal.Update(CountryGroup);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(CountryGroup CountryGroup)
        {
            //Business Code

            _CountryGroupDal.Delete(CountryGroup);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
