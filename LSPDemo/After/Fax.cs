using ISPDemo.Models;

namespace ISPDemo.After
{
    public class FaxMachine : IFax
    {
        public void Fax(List<Document> documents)
        {
            StartFaxMachine();

            // Fax the items.
            foreach (var doc in documents)
            {
                Console.WriteLine("Faxing {0}...", doc.Text);
            }
            Console.WriteLine("All Items Faxed" + documents.Count);
        }

        public void StartFaxMachine()
        {
            Console.WriteLine("Fax machine starting...");
        }
    }
}
