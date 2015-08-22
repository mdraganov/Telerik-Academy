namespace GSMInfo
{
    using System;

    public class Display
    {
        private float size;
        private long colors;     
        
        public Display()
        {
            this.size = 2;
            this.colors = 2;
        }

        public Display(float size)
            : this()
        {
            this.Size = size;
        }

        public Display(float size, long colors)
            : this(size)
        {
            this.Colors = colors;
        }

        public float Size
        {
            get { return this.size; }
            set 
            {
                if (value > 20)
                {
                    throw new ArgumentException("Display size too big for a phone!");
                }

                if (value <= 0)
                {
                    throw new ArgumentException("Display size should be positive!");
                }

                this.size = value; 
            }
        }

        public long Colors
        {
            get { return this.colors; }
            set 
            {
                if (value > long.MaxValue)
                {
                    throw new ArgumentException("This display is too colorful!");
                }

                if (value <= 1)
                {
                    throw new ArgumentException("Colors should be more than one!");
                }

                this.colors = value; 
            }
        }
    }
}
