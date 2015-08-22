namespace Structure
{
    using System;

    public static class Distance
    {
        public static double Calculate(Point3D fisrt, Point3D second)
        {
            return Math.Sqrt(Math.Pow(fisrt.X - second.X, 2) + Math.Pow(fisrt.Y - second.Y, 2) + Math.Pow(fisrt.Z - second.Z, 2));
        }
    }
}
