namespace Structure
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void Save(Path pathToSave)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\Paths.txt"))
            {
                writer.Write(pathToSave);
            }
        }

        public static Path Load()
        {
            Path pathToLoad = new Path();
            string[] pointsRead;

            using (StreamReader reader = new StreamReader(@"..\..\Paths.txt"))
            {
               pointsRead = reader.ReadToEnd().Split();
            }

            foreach (string point in pointsRead)
            {
                double[] points = point.Split(',').Select(double.Parse).ToArray();

                pathToLoad.AddPoint(new Point3D(points[0], points[1], points[2]));
            }

            return pathToLoad;
        }
    }
}
