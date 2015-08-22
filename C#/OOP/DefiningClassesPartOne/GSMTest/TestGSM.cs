namespace GSMTest
{
    using System;
    using GSMInfo;

    class TestGSM
    {
        static void Main()
        {
            GSM[] phones = new GSM[] { new GSM("Lumia", "Microsoft", "Pesho"), new GSM("Galaxy", "Samsung", "Gosho"), new GSM("Iphone 6", "Apple", "Asen") };

            phones[0].BatteryInfo.HoursTalk = 325;
            phones[0].BatteryInfo.MAhCapacity = 4000;
            phones[1].DisplayInfo.Colors = 256;
            phones[1].Price = 200;
            phones[2].DisplayInfo.Size = 6;
            phones[2].BatteryInfo.MAhCapacity = 2000;

            foreach (GSM phone in phones)
            {
                Console.WriteLine(phone);
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4S.Manufacturer + " " + GSM.IPhone4S.Model);
        }
    }
}
