namespace Shapes
{
    using System;

    class TestShapes
    {
        static void Main()
        {
            Shape[] shapesArray = new Shape[] 
                    {   
                        new Rectangle() {Height = 1, Width = 2}, 
                        new Square(2.45), 
                        new Triangle() {Width = 5.5, Height = 6.5} 
                    };

            foreach (Shape shape in shapesArray)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
