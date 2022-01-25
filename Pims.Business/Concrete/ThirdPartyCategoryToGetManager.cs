using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class ThirdPartyCategoryToGetManager : IThirdPartyCategoryToGetService
    {
        private readonly IThirdPartyCategoryToGetDal _ThirdPartyCategoryToGetDal;

        public ThirdPartyCategoryToGetManager(IThirdPartyCategoryToGetDal ThirdPartyCategoryToGetDal)
        {
            _ThirdPartyCategoryToGetDal = ThirdPartyCategoryToGetDal;
        }

        public IDataResult<ThirdPartyCategoryToGet> GetById(int id)
        {
            return new SuccessDataResult<ThirdPartyCategoryToGet>(_ThirdPartyCategoryToGetDal.Get(x => x.Id == id));
        }

        public IDataResult<List<ThirdPartyCategoryToGet>> GetList()
        {
            return new SuccessDataResult<List<ThirdPartyCategoryToGet>>(_ThirdPartyCategoryToGetDal.GetList().ToList());
        }

        public IResult Add(ThirdPartyCategoryToGet ThirdPartyCategoryToGet)
        {
            //Business Code

            _ThirdPartyCategoryToGetDal.Add(ThirdPartyCategoryToGet);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(ThirdPartyCategoryToGet ThirdPartyCategoryToGet)
        {
            //Business Code

            _ThirdPartyCategoryToGetDal.Update(ThirdPartyCategoryToGet);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(ThirdPartyCategoryToGet ThirdPartyCategoryToGet)
        {
            //Business Code

            _ThirdPartyCategoryToGetDal.Delete(ThirdPartyCategoryToGet);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
