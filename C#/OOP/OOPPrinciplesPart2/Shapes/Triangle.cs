namespace Shapes
{
    public class Triangle : Shape
    {
        public override double CalculateSurface()
        {
            return this.Height * this.Width / 2;
        }
    }
}
