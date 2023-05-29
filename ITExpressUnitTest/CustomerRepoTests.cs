using Abstraction.Interfaces;
using DAL.Models;
using DAL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ITExpressUnitTest
{
    [TestClass]
    public class CustomerRepoTests
    {
        private readonly CustomerRepo _customerRepo = new CustomerRepo();

        [TestMethod]
        public void GetAllCustomersTest()
        {
            //Arrange            

            //Act
            List<ICustomer> customers = _customerRepo.GetAllCustomers();

            //Assert
            Assert.IsNotNull(customers);
        }

        [TestMethod]
        public void AddCustomerTest()
        {
            //Arrange
            ICustomer testCustomer = new Customer()
            {
                FirstName = "test",
                LastName = "test",
                Login = "test",
                Password = "test",
                Email = "test",
                Address = "test",
                ZipCode = 0,
                City = "test",
                PhoneNumber = 5
            };

            //Act
            _customerRepo.AddCustomer(testCustomer);
            List<ICustomer> testCustomers = _customerRepo.GetAllCustomers();

            //Assert
            bool customerFound = false;
            foreach(ICustomer customer in testCustomers)
            {
                if (customer.FirstName == testCustomer.FirstName 
                    && customer.LastName == testCustomer.LastName 
                    && customer.Address == testCustomer.Address)
                {
                    customerFound = true;
                    break;
                }
            }
            Assert.IsTrue(customerFound);
        }

        [TestMethod]
        public void DeleteCustomerTest()
        {
            //Arrange                        
            List<ICustomer> testCustomers = _customerRepo.GetAllCustomers();            
            ICustomer testCustomer = testCustomers.Last();

            //Act
            _customerRepo.DeleteCustomer(testCustomer);

            //Assert
            testCustomers = _customerRepo.GetAllCustomers();
            bool customerFound = false;
            foreach (ICustomer customer in testCustomers)
            {
                if (customer == testCustomer)
                {
                    customerFound = true;
                    break;
                }
            }
            Assert.IsFalse(customerFound);
        }    
    }    
}
