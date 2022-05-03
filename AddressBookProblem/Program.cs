using System;

namespace AddressBookProblem
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book with LINQ Assignment");
            Console.WriteLine("============================================");
            AddressBook objAddressBook = new AddressBook();
            objAddressBook.ShowTable(objAddressBook.CreateAddressBookTable());

        }
    }
}