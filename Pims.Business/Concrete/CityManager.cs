using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IDataResult<City> GetById(int id)
        {
            return new SuccessDataResult<City>(_cityDal.Get(x => x.Id == id));
        }

        public IDataResult<List<City>> GetList()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetList().ToList());
        }

        public IResult Add(City city)
        {
            //Business Code

            _cityDal.Add(city);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(City city)
        {
            //Business Code

            _cityDal.Update(city);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(City city)
        {
            //Business Code

            _cityDal.Delete(city);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
