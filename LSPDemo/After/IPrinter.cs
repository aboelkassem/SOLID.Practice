using ISPDemo.Models;

namespace ISPDemo.After
{
    public interface IPrinter
    {
        void Print(List<Document> documents);
    }
}
