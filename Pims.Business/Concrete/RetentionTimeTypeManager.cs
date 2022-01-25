using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class RetentionTimeTypeManager : IRetentionTimeTypeService
    {
        private readonly IRetentionTimeTypeDal _RetentionTimeTypeDal;

        public RetentionTimeTypeManager(IRetentionTimeTypeDal RetentionTimeTypeDal)
        {
            _RetentionTimeTypeDal = RetentionTimeTypeDal;
        }

        public IDataResult<RetentionTimeType> GetById(int id)
        {
            return new SuccessDataResult<RetentionTimeType>(_RetentionTimeTypeDal.Get(x => x.Id == id));
        }

        public IDataResult<List<RetentionTimeType>> GetList()
        {
            return new SuccessDataResult<List<RetentionTimeType>>(_RetentionTimeTypeDal.GetList().ToList());
        }

        public IResult Add(RetentionTimeType RetentionTimeType)
        {
            //Business Code

            _RetentionTimeTypeDal.Add(RetentionTimeType);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(RetentionTimeType RetentionTimeType)
        {
            //Business Code

            _RetentionTimeTypeDal.Update(RetentionTimeType);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(RetentionTimeType RetentionTimeType)
        {
            //Business Code

            _RetentionTimeTypeDal.Delete(RetentionTimeType);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
