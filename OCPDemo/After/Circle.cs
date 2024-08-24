namespace OCPDemo.After
{
    public class Circle(decimal radius, decimal centerX, decimal centerY) : IShape
    {
        public void Draw()
        {
            var center = new Tuple<decimal, decimal>(centerX, centerY);
            Console.WriteLine("Circle: Center={0}; radius={1}", center, radius);
        }
    }
}
