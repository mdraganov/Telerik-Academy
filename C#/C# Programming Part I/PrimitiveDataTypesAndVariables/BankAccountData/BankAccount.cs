//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Pesho";
        string middleName = "Peshev";
        string lastName = "Peshistiq";
        decimal balance = 9999999.999999M;
        string bankName = "Banka PESHOVSKA";
        string iban = "BG25 BPES 2551 2364 2164";
        ulong creditCard1 = 4536123456984567;
        ulong creditCard2 = 9437126981919783;
        ulong creditCard3 = 9836123456959737;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", firstName, middleName, lastName, balance, bankName, iban, creditCard1, creditCard2, creditCard3);
    }
}

