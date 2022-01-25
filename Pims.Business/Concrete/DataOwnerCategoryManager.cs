using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class DataOwnerCategoryManager : IDataOwnerCategoryService
    {
        private readonly IDataOwnerCategoryDal _DataOwnerCategoryDal;

        public DataOwnerCategoryManager(IDataOwnerCategoryDal DataOwnerCategoryDal)
        {
            _DataOwnerCategoryDal = DataOwnerCategoryDal;
        }

        public IDataResult<DataOwnerCategory> GetById(int id)
        {
            return new SuccessDataResult<DataOwnerCategory>(_DataOwnerCategoryDal.Get(x => x.Id == id));
        }

        public IDataResult<List<DataOwnerCategory>> GetList()
        {
            return new SuccessDataResult<List<DataOwnerCategory>>(_DataOwnerCategoryDal.GetList().ToList());
        }

        public IResult Add(DataOwnerCategory DataOwnerCategory)
        {
            //Business Code

            _DataOwnerCategoryDal.Add(DataOwnerCategory);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(DataOwnerCategory DataOwnerCategory)
        {
            //Business Code

            _DataOwnerCategoryDal.Update(DataOwnerCategory);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(DataOwnerCategory DataOwnerCategory)
        {
            //Business Code

            _DataOwnerCategoryDal.Delete(DataOwnerCategory);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
