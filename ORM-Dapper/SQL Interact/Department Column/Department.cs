using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    //Class matches the table in the database
    // Go ahead and make public
    public class Department
    {// These matchup to the column in database 
        public int DepartmentID { get; set; }
        public string Name { get; set; }
    }
}
