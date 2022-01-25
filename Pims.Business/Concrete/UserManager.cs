using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        public IDataResult<List<User>> GetList()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetList().ToList());
        }

        public IDataResult<List<User>> GetListByCompanyId(int companyId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetList(u => u.CompanyId == companyId).ToList());
        }
        
        public IDataResult<List<User>> GetListByUserTypeId(int userTypeId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetList(u => u.UserTypeId == userTypeId).ToList());
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }

        public IResult Add(User user)
        {
            //Business Code

            _userDal.Add(user);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(User user)
        {
            //Business Code

            _userDal.Update(user);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(User user)
        {
            //Business Code

            _userDal.Delete(user);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
