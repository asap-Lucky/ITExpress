﻿using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Facader
{
    public class CustomerService
    {
       //Create an Interface of type ICustomerService
        public ICustomerService customerService { get; set; }
        // Create an interface of type ICustomer
        public Abstraction.Interfaces.ICustomer MyCustomer { get; set; }
        //Uses Customersevice and ICustomerService to create a new instance of customerservice
        public CustomerService(ICustomerService customerService) 
        { 
        this.customerService = customerService;
        }
        public void RegisterCustomer(string FirstName,string LastName,string Adress, int Zipcode,int Phonenumber,string Email,string Login,string Password,string City)
        {
            // Initialize MyCustomer with a new instance of the Customer class.
            MyCustomer = new Customer();


            MyCustomer.FirstName = FirstName;
            MyCustomer.LastName = LastName;
            MyCustomer.Address = Adress;
            MyCustomer.ZipCode = Zipcode;
            MyCustomer.PhoneNumber = Phonenumber;
            MyCustomer.Email = Email;
            MyCustomer.Login = Login;
            MyCustomer.Password = Password;
            MyCustomer.City = City;

            // Call the AddCustomer method of the CustomerService object and pass in MyCustomer object.
            customerService.AddCustomer(MyCustomer);
        }
    }
}
