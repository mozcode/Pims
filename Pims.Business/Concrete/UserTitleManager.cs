using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class UserTitleManager : IUserTitleService
    {
        private readonly IUserTitleDal _userTitleDal;

        public UserTitleManager(IUserTitleDal userTitleDal)
        {
            _userTitleDal = userTitleDal;
        }

        public IDataResult<UserTitle> GetById(int id)
        {
            return new SuccessDataResult<UserTitle>(_userTitleDal.Get(x => x.Id == id));
        }

        public IDataResult<List<UserTitle>> GetList()
        {
            return new SuccessDataResult<List<UserTitle>>(_userTitleDal.GetList().ToList());
        }

        public IResult Add(UserTitle userTitle)
        {
            //Business Code

            _userTitleDal.Add(userTitle);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(UserTitle userTitle)
        {
            //Business Code

            _userTitleDal.Update(userTitle);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(UserTitle userTitle)
        {
            //Business Code

            _userTitleDal.Delete(userTitle);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
