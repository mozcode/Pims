using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class UserTypeManager : IUserTypeService
    {
        private readonly IUserTypeDal _userTypeDal;

        public UserTypeManager(IUserTypeDal userTypeDal)
        {
            _userTypeDal = userTypeDal;
        }

        public IDataResult<UserType> GetById(int id)
        {
            return new SuccessDataResult<UserType>(_userTypeDal.Get(x => x.Id == id));
        }

        public IDataResult<List<UserType>> GetList()
        {
            return new SuccessDataResult<List<UserType>>(_userTypeDal.GetList().ToList());
        }

        public IResult Add(UserType userType)
        {
            //Business Code

            _userTypeDal.Add(userType);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(UserType userType)
        {
            //Business Code

            _userTypeDal.Update(userType);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(UserType userType)
        {
            //Business Code

            _userTypeDal.Delete(userType);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
