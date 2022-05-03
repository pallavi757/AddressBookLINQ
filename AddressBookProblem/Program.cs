using System;
using System.Data;

namespace AddressBookProblem
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book with LINQ Assignment");
            Console.WriteLine("============================================");
            AddressBook objAddressBook = new AddressBook();
            objAddressBook.CreateAddressBookTable();
            object[] fieldsToInsert =
            {
                new object[] {null, "Mark", "Zukerburg", "Street 90 California", "California", "California", "454545", "mar@gg", "451212121","Friend","a1"},//insert value of contact type and address book name
                new object[] {null, "Swati", "Pathak", "Street 90 California", "California", "California", "454545", "mar@gg", "451212121","Family","a1"},
                new object[] {null, "Mansi", "Sharma", "Lane98", "Pune", "Maharastra", "777777", "mansi@exp.com", "9999999999","Friend","a2"},
                new object[] {null, "Zannat", "Khan", "Street 90", "Noida", "UP", "555555", "ash123@gmail.com", "451212121","Profession","a3"},
                new object[] {null, "Ravi", "Prakash", "Street 90", "Noida", "UP", "555555", "ash123@gmail.com", "451212121","Friend","a2"},
                new object[] {null, "Ram", "Das", "Street 90", "Noida", "UP", "555555", "ash123@gmail.com", "451212121","Friend","a1"},
                new object[] {null, "Ashish", "Mehta", "Street 90", "Noida", "UP", "555555", "ash123@gmail.com", "451212121","Family","a3"},
                new object[] {null, "Anushka", "Sharma", "Street 76", "Mumbai", "Maharastra", "444444", "anu@abc.com", "8888888888","Profession","a2"},
                new object[] {null, "Ashish", "Kumar", "Street 90", "Noida", "UP", "555555", "ash123@gmail.com", "451212121","Friend","a2"},
                new object[] {null, "abhishek", "yaday", "Street 978", "Kanpur", "UP", "666666", "yad@abc.com", "451212121","Friend","a3"},
                new object[] {null, "Rahul", "Kumar", "Street 90 California", "California", "California", "454545", "mar@gg", "451212121", "Family", "a1" }
            };
            DataTable objTable1 = objAddressBook.InsertValues(fieldsToInsert);
            AddressBook.ShowTable(objTable1);
            object[] fieldsToEdit =
            {
                new object[] {null, "Mark", "Zukerburg", "LAne 45", "California", "California", "784512", "mar@gg", "451212121","Friend","a1"},
                new object[] {null, "Swati", "Pathak", "Street 87", "California", "California", "454545", "mar@gg", "451212121", "Family", "a1" }
            };
            DataTable objTable2 = objAddressBook.EditExitingContacts(fieldsToEdit);
            AddressBook.ShowTable(objTable2);
            DataTable objTable3 = objAddressBook.DeleteContact("Mark", "Zukerburg");
            AddressBook.ShowTable(objTable3);
            objAddressBook.RetrieveContactsByCity("California");
            objAddressBook.RetrieveContactsByState("UP");
            objAddressBook.GetSizeByCity("Noida");
            objAddressBook.GetSizeByState("UP");
            objAddressBook.RetriveSortedEntryForACity("Noida");

        }
    }
}

