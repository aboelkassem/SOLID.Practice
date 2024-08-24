namespace OCPDemo.Before
{
    public class Circle
    {
        public decimal Radius { get; set; }
        public decimal CenterX { get; set; }
        public decimal CenterY { get; set; }

        public Circle(decimal radius, decimal centerX, decimal centerY)
        {
            Radius = radius;
            CenterX = centerX;
            CenterY = centerY;
        }
    }
}
