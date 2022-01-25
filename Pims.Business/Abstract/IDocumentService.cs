using System.Collections.Generic;
using Core.Utilities.Results;
using Pims.Entities.Concrete;

namespace Pims.Business.Abstract
{
    public interface IDocumentService
    {
        IDataResult<Document> GetById(int id);

        IDataResult<List<Document>> GetList();

        IDataResult<List<Document>> GetListByDocumentTypeId(int documentTypeId);

        IResult Add(Document document);

        IResult Update(Document document);

        IResult Delete(Document document);
    }
}
