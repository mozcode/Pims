using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class DistrictManager : IDistrictService
    {
        private readonly IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public IDataResult<District> GetById(int id)
        {
            return new SuccessDataResult<District>(_districtDal.Get(x => x.Id == id));
        }

        public IDataResult<List<District>> GetList()
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetList().ToList());
        }

        public IDataResult<List<District>> GetListByCityId(int cityId)
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetList(x => x.CityId == cityId).ToList());
        }

        public IResult Add(District district)
        {
            //Business Code

            _districtDal.Add(district);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(District district)
        {
            //Business Code

            _districtDal.Update(district);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(District district)
        {
            //Business Code

            _districtDal.Delete(district);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
