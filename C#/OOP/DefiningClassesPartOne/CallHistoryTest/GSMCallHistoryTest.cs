namespace CallHistoryTest
{
    using System;
    using GSMInfo;
    using System.Collections.Generic;

    public class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM testPhone = new GSM("Lumia", "Microsoft");

            testPhone.AddCall(new DateTime(2015, 1, 1), 0888123456, 50);
            testPhone.AddCall(new DateTime(2015, 1, 10), 0888123456, 50);
            testPhone.AddCall(DateTime.Now, 0888123456, 100);

            PrintCalls(testPhone.CallHistory);

            Console.WriteLine("Total price is {0}", testPhone.TotalCallsPrice(0.37));

            int longestCallIndex = FindLongestCall(testPhone.CallHistory);
            testPhone.DeleteCall(longestCallIndex);

            Console.WriteLine("Total price after removal of longest call is {0}", testPhone.TotalCallsPrice(0.37));

            testPhone.ClearCallHistory();

            PrintCalls(testPhone.CallHistory);
        }

        public static int FindLongestCall(List<Call> callList)
        {
            double longestCall = 0;
            int longestCallIndex = 0;

            for (int i = 0; i < callList.Count; i++)
            {
                double currentCallDuration = callList[i].Duration;
                if (longestCall < currentCallDuration)
                {
                    longestCall = currentCallDuration;
                    longestCallIndex = i;
                }
            }

            return longestCallIndex;
        }

        public static void PrintCalls(List<Call> callList)
        {
            if (callList.Count < 1)
            {
                Console.WriteLine("There are no calls in the call history!");   
            }

            foreach (Call call in callList)
            {
                Console.WriteLine(call);
                Console.WriteLine();
            }
        }
    }
}
