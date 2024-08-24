Console.WriteLine("Before");
object[] beforeShapes =
[
    new OCPDemo.Before.Circle
    {
        Radius= 5,
        CenterX = 10,
        CenterY = 10,
    },
    new OCPDemo.Before.Square
    {
        Left = 10,
        Top = 10,
        Side = 10,
    }
];

var bDrawing = new OCPDemo.Before.DrawingService();
bDrawing.DrawAllShapes(beforeShapes);

Console.WriteLine();

Console.WriteLine("After");
OCPDemo.After.IShape[] afterShapes =
[
    new OCPDemo.After.Circle(5, 10, 10),
    new OCPDemo.After.Square(8, 20, 20)
];

var aDrawing = new OCPDemo.After.DrawingService();
aDrawing.DrawAllShapes(afterShapes);
Console.ReadLine();