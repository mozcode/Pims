using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class LegalBasisManager : ILegalBasisService
    {
        private readonly ILegalBasisDal _LegalBasisDal;

        public LegalBasisManager(ILegalBasisDal LegalBasisDal)
        {
            _LegalBasisDal = LegalBasisDal;
        }

        public IDataResult<LegalBasis> GetById(int id)
        {
            return new SuccessDataResult<LegalBasis>(_LegalBasisDal.Get(x => x.Id == id));
        }

        public IDataResult<List<LegalBasis>> GetList()
        {
            return new SuccessDataResult<List<LegalBasis>>(_LegalBasisDal.GetList().ToList());
        }

        public IResult Add(LegalBasis LegalBasis)
        {
            //Business Code

            _LegalBasisDal.Add(LegalBasis);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(LegalBasis LegalBasis)
        {
            //Business Code

            _LegalBasisDal.Update(LegalBasis);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(LegalBasis LegalBasis)
        {
            //Business Code

            _LegalBasisDal.Delete(LegalBasis);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
