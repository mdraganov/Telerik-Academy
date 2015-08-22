namespace GSMInfo
{
    using System;
    using System.Collections.Generic;

    public class Call
    {
        private DateTime date;
        private long dialedNumber;
        private long duration;

        public Call(DateTime date, long dialedNumber, long duration)
        {
            this.Date = date;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get { return date; }
            set { this.date = value; }
        }

        public long DialedNumber
        {
            get { return dialedNumber; }
            set { this.dialedNumber = value; }
        }

        public long Duration
        {
            get { return duration; }
            set { this.duration = value; }
        }

        public override string ToString()
        {
            return string.Format("Call date: {0}\nDialed number: {1}\nCall duration (sec): {2}", this.Date, this.DialedNumber, this.Duration);
        }
    }
}
