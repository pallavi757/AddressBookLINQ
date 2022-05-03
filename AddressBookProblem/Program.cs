using System;

namespace AddressBookProblem
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book with LINQ Assignment");
            Console.WriteLine("============================================");
            AddressBook objAddressBook = new AddressBook();
            //objAddressBook.ShowTable(objAddressBook.CreateAddressBookTable());
            object[] fieldsToInsert =
            {
                new object[] {null, "Mark", "Zukerburg", "Street 90 California", "California", "California", "454545", "mar@gg", "451212121"},
                new object[] {null, "Swati", "Pathak", "Street 90 California", "California", "California", "454545", "mar@gg", "451212121" }
            };
            objAddressBook.ShowTable(objAddressBook.InsertValues(fieldsToInsert));
        }
    }
}
