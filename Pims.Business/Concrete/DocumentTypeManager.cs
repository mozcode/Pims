using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class DocumentTypeManager : IDocumentTypeService
    {
        private readonly IDocumentTypeDal _documentTypeDal;

        public DocumentTypeManager(IDocumentTypeDal documentTypeDal)
        {
            _documentTypeDal = documentTypeDal;
        }

        public IDataResult<DocumentType> GetById(int id)
        {
            return new SuccessDataResult<DocumentType>(_documentTypeDal.Get(x => x.Id == id));
        }

        public IDataResult<List<DocumentType>> GetList()
        {
            return new SuccessDataResult<List<DocumentType>>(_documentTypeDal.GetList().ToList());
        }

        public IResult Add(DocumentType documentType)
        {
            //Business Code

            _documentTypeDal.Add(documentType);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(DocumentType documentType)
        {
            //Business Code

            _documentTypeDal.Update(documentType);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(DocumentType documentType)
        {
            //Business Code

            _documentTypeDal.Delete(documentType);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
