using ISPDemo.Models;

var documents = new List<Document>
{
    new Document("Doc1"),
    new Document("Doc2"),
    new Document("Doc3")
};

// Before
Console.WriteLine("BEFORE");
Console.WriteLine("Machine:");
var bMachine = new ISPDemo.Before.Machine();
bMachine.Print(documents);
Console.WriteLine();

// After
Console.WriteLine("AFTER");
Console.WriteLine("Machine:");
var aMachine = new ISPDemo.After.Machine();
aMachine.Print(documents);
Console.WriteLine();

Console.WriteLine("Scanner:");
var aScanner = new ISPDemo.After.Scanner();
aScanner.Scan(documents);

Console.ReadLine();