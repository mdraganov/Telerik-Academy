namespace Shapes
{
    public class Square : Shape
    {
        public Square(double side)
        {
            this.Height = side;
            this.Width = side;
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Height;
        }
    }
}
