using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

#nullable disable

namespace homework20.DataContext
{
    public class PersonRepository
    {
        public string connectionString = "Data source=localhost; initial catalog=AlifAcademy; integrated security=true";
        public List<Person> GetPersons()
        {
            var users = new List<Person>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                users = db.Query<Person>("SELECT * FROM Persons").ToList();
            }
            return users;
        }
    }
}