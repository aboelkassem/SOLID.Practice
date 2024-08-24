namespace OCPDemo.After
{
    public class DrawingService
    {
        public void DrawAllShapes(IShape[] shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
