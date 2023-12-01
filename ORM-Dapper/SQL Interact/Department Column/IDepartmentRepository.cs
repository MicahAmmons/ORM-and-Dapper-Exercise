using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    // All the classes (tables) will conform to this MABY WRONG
    // go ahead and change to public
    public interface IDepartmentRepository
    {
        
        IEnumerable<Department> GetAllDepartments();
    }
}
