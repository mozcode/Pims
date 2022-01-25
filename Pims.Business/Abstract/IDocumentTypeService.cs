using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IDocumentTypeService
    {
        IDataResult<DocumentType> GetById(int id);

        IDataResult<List<DocumentType>> GetList();

        IResult Add(DocumentType documentType);

        IResult Update(DocumentType documentType);

        IResult Delete(DocumentType documentType);
    }
}
