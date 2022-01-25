using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class CountryManager : ICountryService
    {
        private readonly ICountryDal _CountryDal;

        public CountryManager(ICountryDal CountryDal)
        {
            _CountryDal = CountryDal;
        }

        public IDataResult<Country> GetById(int id)
        {
            return new SuccessDataResult<Country>(_CountryDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Country>> GetList()
        {
            return new SuccessDataResult<List<Country>>(_CountryDal.GetList().ToList());
        }

        public IResult Add(Country Country)
        {
            //Business Code

            _CountryDal.Add(Country);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(Country Country)
        {
            //Business Code

            _CountryDal.Update(Country);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(Country Country)
        {
            //Business Code

            _CountryDal.Delete(Country);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
