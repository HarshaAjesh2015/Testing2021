//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Testing2021.Pages;
//using Testing2021.Utilities;

//namespace Testing2021.Tests
//{

//    [TestFixture]
//    [Parallelizable]
//    class EmployeeTests
//    {
//        class Employee_Tests : CommonDriver
//        {

//            [Test, Order(1), Description("Check if user is able to create an Employee record with valid data")]
//            public void CreateEmployee_Test()
//            {
//                // Home page object initialization and definition
//                HomePage homePageObj = new HomePage();
//                homePageObj.GoToEmployeePage(driver);

//                // Emp page object initialization and definition
//                EmployeePage employeePageObj = new EmployeePage();
//                employeePageObj.CreateEmp(driver);
//            }

//            [Test, Order(2), Description("Check if user is able to edit an Employee record with valid data")]
//            public void EditEmployee_Test()
//            {
//                // Home page object initialization and definition
//                HomePage homePageObj = new HomePage();
//                homePageObj.GoToEmployeePage(driver);

//                // Emp page object initialization and definition
//                EmployeePage employeePageObj = new EmployeePage();
//                employeePageObj.EditEmp(driver);
//            }

//            [Test, Order(3), Description("Check if user is able to delete an existing Employee record")]
//            public void DeleteEmployee_Test()
//            {
//                // Home page object initialization and definition
//                HomePage homePageObj = new HomePage();
//                homePageObj.GoToEmployeePage(driver);

//                EmployeePage employeePageObj = new EmployeePage();
//                employeePageObj.DeleteEmp(driver);
//            }
//        }

//    }
//}