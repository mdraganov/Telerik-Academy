namespace Structure
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public List<Point3D> Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public void AddPoint(Point3D point)
        {
            points.Add(point);
        }

        public void AddPoints(params Point3D[] point)
        {
            points.AddRange(point);
        }

        public override string ToString()
        {
            return string.Join(" ", points);
        }
    }
}
