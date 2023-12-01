using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System.Data;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ignore appsettings.json file in .gitignore and commit
            //Create appsettings.json in netcoreapp folder 3.Run a git status to make sure appsettings is ignored
            //Add the MySql.Data Nuget Package
            //Add the Dapper Nuget package
            //Add the Microsoft.Extensions.Configuration.Json Nuget package
            //Make sure your config code is in your main method
            //Copy this code in.  Control . for using directive.  this is the connection to database 
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);
            //Create a Department class 9.Create an IDepartmentRepository interface
            //Create a DapperDepartmentRepository class
            //Create a GetAllDepartments Method
            //Create a Department class 9.Create an IDepartmentRepository interface
            //Create a DapperDepartmentRepository class
            //Create a GetAllDepartments Method
            //Create an InsertDepartment Method//Create an InsertDepartment Method

            //departmentRepo is the Instance that we will use to call the methods within the same class
            DapperDepartmentRepository departmentRepo = new DapperDepartmentRepository(conn);

            departmentRepo.InsertDepartment("TestDepo");

            var departments = departmentRepo.GetAllDepartments(); 
            foreach (var department in departments)
            {
                Console.WriteLine(department.DepartmentID);
                Console.WriteLine(department.Name);
                Console.WriteLine();
                Console.WriteLine();
            }
            DapperProductRepository productRepository = new DapperProductRepository(conn);
            var allProducts = productRepository.GetAllProducts();
            foreach (var product in allProducts)
            {
                    Console.WriteLine(product.Name);
                    Console.WriteLine(product.ProductID);
                    Console.WriteLine(product.Price);
                Console.WriteLine();
            }
    }
    }
}
