using ISPDemo.Models;

namespace ISPDemo.After
{
    interface IPhotocopier
    {
        void PhotoCopy(List<Document> documents);
    }
}
