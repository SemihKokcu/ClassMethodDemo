using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1, customer2, customer3;
            Customers(out customer1, out customer2, out customer3);

            CustomerManager customerManager = new CustomerManager();

            int result = 0;
            while (result != -1)
            {

                Console.WriteLine("Select your action\n1-) Customer Add\n2-) Customer Delete\n3-)Customer List\nTo exit : -1\n");

                result = Convert.ToInt32(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        int select;
                        Console.WriteLine("There are 3 customers, enter the id of the customer you want to add select to(1,2or3)\n");
                        select = Convert.ToInt32(Console.ReadLine());
                        if (select == 1)
                        {
                            customerManager.Added(customer1);
                        }
                        else if (select == 2)
                        {
                            customerManager.Added(customer2);
                        }
                        else if (select == 3)
                        {
                            customerManager.Added(customer3);
                        }
                        else
                        {
                            Console.WriteLine("No customer with this claim found");
                        }


                        break;
                    case 2:
                        int select2;
                        Console.WriteLine("There are 3 customers, enter the id of the customer you want to delete select to(1,2or3)\n");
                        select2 = Convert.ToInt32(Console.ReadLine());
                        if (select2 == 1)
                        {
                            customerManager.Deleted(customer1);
                        }
                        else if (select2 == 2)
                        {
                            customerManager.Deleted(customer2);
                        }
                        else if (select2 == 3)
                        {
                            customerManager.Deleted(customer3);
                        }
                        else
                        {
                            Console.WriteLine("No customer with this claim found");
                        }


                        break;
                    case 3:
                        Console.WriteLine("Customer List is \n:");
                        customerManager.CustomerList(customer1, customer2, customer3);


                        break;

                    default:
                        break;


                }
            }




        }

        private static void Customers(out Customer customer1, out Customer customer2, out Customer customer3)
        {
            customer1 = new Customer()
            {
                Id = 1,
                Name = "Semih",
                SurName = "Kökçü",
                Age = 21,
                Job = " student",
                Adress = "semihkkc@gmail.com",
                PhoneNumber = "123456789"
            };
            customer2 = new Customer()
            {
                Id = 2,
                Name = "Melih",
                SurName = "Kökçü",
                Age = 19,
                Job = "programmer",
                Adress = "melihkkc@gmail.com",
                PhoneNumber = "123456789"
            };
            customer3 = new Customer()
            {
                Id = 2,
                Name = "Ahmet",
                SurName = "Kökçü",
                Age = 42,
                Job = "Police",
                Adress = "Ahmetkkc@gmail.com",
                PhoneNumber = "123456789"
            };
        }
    }
}
