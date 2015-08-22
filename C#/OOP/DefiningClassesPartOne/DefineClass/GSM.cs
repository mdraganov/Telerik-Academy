namespace GSMInfo
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery batteryInfo;
        private Display displayInfo;
        private List<Call> calls = new List<Call>();
        private static GSM iPhone4S = new GSM("IPhone4S", "Apple");

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.price = 0;
            this.owner = null;
            this.batteryInfo = new Battery();
            this.displayInfo = new Display();
        }

        public GSM(string model, string manufacturer, double price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, string owner)
            : this(model, manufacturer)
        {
            this.Owner = owner;
        }

        public void AddCall(DateTime date, long dialedNumber, long duration)
        {
            Call currentCall = new Call(date, dialedNumber, duration);
            this.CallHistory.Add(currentCall);
        }

        public void DeleteCall(int callIndex)
        {
            if (this.CallHistory.Count > 0)
            {
                calls.RemoveAt(callIndex);
            }
            else
            {
                throw new IndexOutOfRangeException("There are no calls in this call history");
            }
        }

        public void ClearCallHistory()
        {
            if (this.CallHistory.Count > 0)
            {
                calls.RemoveRange(0, calls.Count);
            }
            else
            {
                throw new IndexOutOfRangeException("There are no calls in this call history");
            }
        }

        public double TotalCallsPrice(double pricePerMin)
        {
            double totalCost = 0;
            foreach (Call call in calls)
            {
                double currentCallCost = call.Duration * (pricePerMin / 60);
                totalCost += currentCallCost;
            }

            return totalCost;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length < 2 || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer's name should be longer!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length < 2 || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer's name should be longer!");
                }

                this.manufacturer = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price should be zero or more!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length < 2 || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner's name should be longer!");
                }

                this.owner = value;
            }
        }

        public Battery BatteryInfo
        {
            get { return this.batteryInfo; }
            set { this.batteryInfo = value; }
        }

        public Display DisplayInfo
        {
            get { return displayInfo; }
            set { displayInfo = value; }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }

        public List<Call> CallHistory
        {
            get { return calls; }
        }

        public override string ToString()
        {
            return string.Format("The phone is {0} {1}. It's owner is {2} and the price is {3}. The display is {4} inches big and has {5} colors. The battery is {6} with {7} mAh of capacity and {8} hours of idle time and {9} hours of talk time.",
                this.Manufacturer, this.Model, this.Owner, this.Price, this.DisplayInfo.Size, this.DisplayInfo.Colors, this.BatteryInfo.TypeOfBattery, this.BatteryInfo.MAhCapacity, this.BatteryInfo.HoursIdle, this.BatteryInfo.HoursTalk);
        }

        static void Main()
        {

        }
    }
}
