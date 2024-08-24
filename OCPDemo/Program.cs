Console.WriteLine("Before");
object[] beforeShapes =
[
    new OCPDemo.Before.Circle(5, 10, 10),
    new OCPDemo.Before.Square(8, 20, 20)
];

var b_Drawing = new OCPDemo.Before.DrawingService();
b_Drawing.DrawAllShapes(beforeShapes);

Console.WriteLine();

Console.WriteLine("After");
OCPDemo.After.IShape[] afterShapes = {
    new OCPDemo.After.Circle(5, 10, 10),
    new OCPDemo.After.Square(8, 20, 20)
};

var a_Drawing = new OCPDemo.After.DrawingService();
a_Drawing.DrawAllShapes(afterShapes);
Console.ReadLine();