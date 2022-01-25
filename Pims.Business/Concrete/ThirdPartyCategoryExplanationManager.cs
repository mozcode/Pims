using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class ThirdPartyCategoryExplanationManager : IThirdPartyCategoryExplanationService
    {
        private readonly IThirdPartyCategoryExplanationDal _ThirdPartyCategoryExplanationDal;

        public ThirdPartyCategoryExplanationManager(IThirdPartyCategoryExplanationDal ThirdPartyCategoryExplanationDal)
        {
            _ThirdPartyCategoryExplanationDal = ThirdPartyCategoryExplanationDal;
        }

        public IDataResult<ThirdPartyCategoryExplanation> GetById(int id)
        {
            return new SuccessDataResult<ThirdPartyCategoryExplanation>(_ThirdPartyCategoryExplanationDal.Get(x => x.Id == id));
        }

        public IDataResult<List<ThirdPartyCategoryExplanation>> GetList()
        {
            return new SuccessDataResult<List<ThirdPartyCategoryExplanation>>(_ThirdPartyCategoryExplanationDal.GetList().ToList());
        }

        public IResult Add(ThirdPartyCategoryExplanation ThirdPartyCategoryExplanation)
        {
            //Business Code

            _ThirdPartyCategoryExplanationDal.Add(ThirdPartyCategoryExplanation);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(ThirdPartyCategoryExplanation ThirdPartyCategoryExplanation)
        {
            //Business Code

            _ThirdPartyCategoryExplanationDal.Update(ThirdPartyCategoryExplanation);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(ThirdPartyCategoryExplanation ThirdPartyCategoryExplanation)
        {
            //Business Code

            _ThirdPartyCategoryExplanationDal.Delete(ThirdPartyCategoryExplanation);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
