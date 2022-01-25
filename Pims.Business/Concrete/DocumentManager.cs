using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Pims.Business.Abstract;
using Pims.Business.Constants;
using Pims.DataAccess.Abstract;
using Pims.Entities.Concrete;

namespace Pims.Business.Concrete
{
    public class DocumentManager : IDocumentService
    {
        private readonly IDocumentDal _documentDal;

        public DocumentManager(IDocumentDal documentDal)
        {
            _documentDal = documentDal;
        }

        public IDataResult<Document> GetById(int id)
        {
            return new SuccessDataResult<Document>(_documentDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Document>> GetList()
        {
            return new SuccessDataResult<List<Document>>(_documentDal.GetList().ToList());
        }

        public IDataResult<List<Document>> GetListByDocumentTypeId(int documentTypeId)
        {
            return new SuccessDataResult<List<Document>>(_documentDal.GetList(x => x.DocumentTypeId == documentTypeId).ToList());
        }

        public IResult Add(Document document)
        {
            //Business Code

            _documentDal.Add(document);

            return new SuccessResult(OperationMessages.AddSuccessfull);
        }

        public IResult Update(Document document)
        {
            //Business Code

            _documentDal.Update(document);

            return new SuccessResult(OperationMessages.UpdateSuccessfull);
        }

        public IResult Delete(Document document)
        {
            //Business Code

            _documentDal.Delete(document);

            return new SuccessResult(OperationMessages.DeleteSuccessfull);
        }
    }
}
