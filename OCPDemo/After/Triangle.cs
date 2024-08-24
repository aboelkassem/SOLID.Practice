namespace OCPDemo.After
{
    public class Triangle(decimal side1, decimal side2, decimal side3) : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Triangle: Sides={0}, {1}, {3}",
                side1, side2, side3);
        }
    }
}
