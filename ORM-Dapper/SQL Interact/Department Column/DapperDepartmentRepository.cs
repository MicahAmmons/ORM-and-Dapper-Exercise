using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    //This is where the methods will live that access the database
    public class DapperDepartmentRepository : IDepartmentRepository
    {

        //Placeholder private field
        private readonly IDbConnection _conn;

        //Create contructors that only allows us to make instances if they pass the field below 
        public DapperDepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        //Use this method to query the database.  First, we need to form a connection 
        public IEnumerable<Department> GetAllDepartments()
        {
                                           //This is the string that will be sent into the SQL 
            return _conn.Query<Department>("SELECT * FROM departments");
        }
        //Since we are just changing info, not retrieving, return value void
        // no return needed
        //no query needed
        //Execute is the key word for this (it's a method)
        public void InsertDepartment(string name)
        {
            _conn.Execute("INSERT INTO departments (Name) VALUES (@name)", new {name});
        }
    }
}
