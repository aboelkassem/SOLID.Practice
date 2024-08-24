namespace OCPDemo.After
{
    public class Square(decimal side, decimal top, decimal left) : IShape
    {
        public void Draw()
        {
            var topLeft = new Tuple<decimal, decimal>(top, left);
            Console.WriteLine("Square: TopLeft={0}; side={1}", 
                topLeft, side);
        }
    }
}
