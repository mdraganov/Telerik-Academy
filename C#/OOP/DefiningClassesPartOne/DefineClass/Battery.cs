namespace GSMInfo
{
    using System;

    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    public class Battery
    {
        private float hoursIdle;
        private float hoursTalk;
        private int mAhCapacity;
        private BatteryType typeOfBattery;

        public Battery()
        {
            this.hoursIdle = 5;
            this.hoursTalk = 2;
            this.mAhCapacity = 100;
        }

        public Battery(float hoursIdle)
            : this()
        {
            this.HoursIdle = hoursIdle;
        }

        public Battery(float hoursTalk, float hoursIdle)
            : this(hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(float hoursTalk, float hoursIdle, int mAhCapacity)
            : this(hoursTalk, hoursIdle)
        {
            this.MAhCapacity = mAhCapacity;
        }

        public float HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Idle time should be positive!");
                }

                this.hoursIdle = value; 
            }
        }

        public float HoursTalk 
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Talk time should be positive!");
                }

                this.hoursTalk = value;
            }
        }

        public int MAhCapacity
        {
            get { return this.mAhCapacity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Talk time should be positive!");
                }

                this.mAhCapacity = value;
            }
        }

        public BatteryType TypeOfBattery
        {
            get { return this.typeOfBattery; }
            set { this.typeOfBattery = value; }
        }
    }
}
