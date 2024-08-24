using ISPDemo.Models;

namespace ISPDemo.After
{
    public interface IFax
    {
        void Fax(List<Document> documents);
    }
}
