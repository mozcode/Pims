using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class DataRecordTypeCategoryManager : IDataRecordTypeCategoryService
    {
        private readonly IDataRecordTypeCategoryDal _DataRecordTypeCategoryDal;

        public DataRecordTypeCategoryManager(IDataRecordTypeCategoryDal DataRecordTypeCategoryDal)
        {
            _DataRecordTypeCategoryDal = DataRecordTypeCategoryDal;
        }

        public IDataResult<DataRecordTypeCategory> GetById(int id)
        {
            return new SuccessDataResult<DataRecordTypeCategory>(_DataRecordTypeCategoryDal.Get(x => x.Id == id));
        }

        public IDataResult<List<DataRecordTypeCategory>> GetList()
        {
            return new SuccessDataResult<List<DataRecordTypeCategory>>(_DataRecordTypeCategoryDal.GetList().ToList());
        }

        public IResult Add(DataRecordTypeCategory DataRecordTypeCategory)
        {
            //Business Code

            _DataRecordTypeCategoryDal.Add(DataRecordTypeCategory);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(DataRecordTypeCategory DataRecordTypeCategory)
        {
            //Business Code

            _DataRecordTypeCategoryDal.Update(DataRecordTypeCategory);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(DataRecordTypeCategory DataRecordTypeCategory)
        {
            //Business Code

            _DataRecordTypeCategoryDal.Delete(DataRecordTypeCategory);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
