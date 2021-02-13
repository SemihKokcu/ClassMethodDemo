using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {

        public void Added(Customer customer)
        {
            Console.WriteLine("enter the customer id you want to add  ");
            int Id;
            Id = Convert.ToInt32(Console.ReadLine());
            if (Id == customer.Id)
            {
                Console.WriteLine("Name:" + customer.Name + "\n" +
                    "Surname:" + customer.SurName + "\n" +
                    "Age:" + customer.Age + "\n" +
                    "Job:" + customer.Job + "\n" +
                    "Adress:" + customer.Adress + "\n" +
                    "PhoneNumber" + customer.PhoneNumber + "\n");

            }
            else
            {
                Console.WriteLine("No customer with this ID found");
            }
        }
        public void Deleted(Customer customer)
        {
            Console.WriteLine("enter the customer id you want to delete");
            int Id;
            Id = Convert.ToInt32(Console.ReadLine());
            if (Id == customer.Id)
            {
                Console.WriteLine("Name:" + customer.Name + "\n" +
                    "Surname:" + customer.SurName + "\n" +
                    "Age:" + customer.Age + "\n" +
                    "Job:" + customer.Job + "\n" +
                    "Adress:" + customer.Adress + "\n" +
                    "PhoneNumber" + customer.PhoneNumber + "\n");
                Console.WriteLine("..customer deleted.. ");

            }
            else
            {
                Console.WriteLine("No customer with this ID found");
            }
        }
        public void CustomerList(Customer customer1, Customer customer2, Customer customer3)
        {
            Customer[] customerList = new Customer[] {  customer1, customer2, customer3 };

            foreach (Customer customer in customerList)
            {
                Console.WriteLine("Name:" + customer.Name + "\n" +
                    "Surname:" + customer.SurName + "\n" +
                    "Age:" + customer.Age + "\n" +
                    "Job:" + customer.Job + "\n" +
                    "Adress:" + customer.Adress + "\n" +
                    "PhoneNumber" + customer.PhoneNumber + "\n");

            }

        }
    }
}
