using ISPDemo.Models;

var documents = new List<Document>();
documents.Add(new Document("Doc1"));
documents.Add(new Document("Doc2"));
documents.Add(new Document("Doc3"));

// Before
Console.WriteLine("BEFORE");
Console.WriteLine("Machine:");
var b_machine = new ISPDemo.Before.Machine();
b_machine.Print(documents);
Console.WriteLine();

//Console.WriteLine("Printer:");
//var b_Printer = new Before.Machine();
//b_Printer.Print(documents);
//Console.WriteLine();


// After
Console.WriteLine("AFTER");
Console.WriteLine("Machine:");
var a_machine = new ISPDemo.After.Machine();
a_machine.Print(documents);
Console.WriteLine();

Console.WriteLine("Scanner:");
var a_Scanner = new ISPDemo.After.Scanner();
a_Scanner.Scan(documents);

Console.ReadLine();