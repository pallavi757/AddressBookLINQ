using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    class AddressBook
    {
        DataSet addressBookSet;
        DataTable addressBookTable;
        /// <summary>Initializes a new instance of the <see cref="AddressBook" /> class.</summary>
        public AddressBook()
        {
            addressBookSet = new DataSet();
        }

        /// <summary>Creates the address book table.</summary>
        
        public DataTable CreateAddressBookTable()
        {
            addressBookTable = new DataTable();
            addressBookSet.Tables.Add(addressBookTable);
            DataColumn[] columns =
            {
                new DataColumn("Id",typeof(int)),
                new DataColumn("FirstName",typeof(string)),
                new DataColumn("LastName",typeof(string)),
                new DataColumn("Address",typeof(string)),
                new DataColumn("City",typeof(string)),
                new DataColumn("State",typeof(string)),
                new DataColumn("Zip",typeof(string)),
                new DataColumn("Email",typeof(string)),
                new DataColumn("PhoneNo",typeof(string)),
            };
            columns[0].AutoIncrement = true;
            columns[0].AutoIncrementSeed = 1;
            addressBookTable.Columns.AddRange(columns);
            addressBookTable.PrimaryKey = new[] { columns[0] };
            return addressBookTable;
        }
        /// <summary>Shows the table.</summary>
        /// <param name="table">The table.</param>
        public static void ShowTable(DataTable table)
        {
            foreach (DataColumn column in table.Columns)
            {
                Console.Write("{0,-20}".PadRight(8, '|').PadLeft(9, ' '), column);
            }
            Console.WriteLine();
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    Console.Write("{0,-20}".PadRight(8, '|').PadLeft(9, ' '), row[column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        /// <summary>Inserts the values.</summary>
        /// <param name="values">The values.</param>
  
        public DataTable InsertValues(params object[] values)
        {
            int insertedRows = 0;
            foreach (object[] field in values)
            {
                addressBookTable.Rows.Add(field);
                insertedRows++;
            }
            Console.WriteLine($"{insertedRows} rows inserted");
            return addressBookTable;
        }
        /// <summary>Edits the exiting contacts.</summary>
        /// <param name="values">The values.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public DataTable EditExitingContacts(params object[] values)
        {
            int editedRows = 0;
            foreach (object[] field in values)
            {
                IEnumerable<DataRow> rows = from row in addressBookTable.AsEnumerable()
                                            where row.Field<string>("FirstName") == field[1].ToString() && row.Field<string>("LastName") == field[2].ToString()
                                            select row;
                foreach (DataRow row in rows)
                {
                    row.SetField("Address", field[3].ToString());
                    row.SetField("City", field[4].ToString());
                    row.SetField("State", field[5].ToString());
                    row.SetField("Zip", field[6].ToString());
                    row.SetField("Email", field[7].ToString());
                    row.SetField("PhoneNo", field[8].ToString());
                    editedRows++;
                }
            }
            Console.WriteLine($"{editedRows} rows edited");
            return addressBookTable;
        }
    }
}
