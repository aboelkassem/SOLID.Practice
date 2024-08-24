using ISPDemo.Models;

namespace ISPDemo.After
{
    public class Photocopier : IPhotocopier
    {
        public void PhotoCopy(List<Document> documents)
        {
            // Photocopy the items.
            foreach (var doc in documents)
            {
                Console.WriteLine("Photocopying {0}...", doc.Text);
            }
            Console.WriteLine("All Items Photocopied" + documents.Count);
        }
    }
}
