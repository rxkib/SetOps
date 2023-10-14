using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOps
{
    public class Menu
    {
        public Menu() { }

        public void Run()
        {
            Set set = new Set();
            int option = 0;

            do
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Insert an element");
                Console.WriteLine("2. Remove an element");
                Console.WriteLine("3. Check if the set is empty");
                Console.WriteLine("4. Check if the set contains an element");
                Console.WriteLine("5. Get a random element");
                Console.WriteLine("6. Get the largest element");
                Console.WriteLine("7. Print the set");
                Console.WriteLine("8. Exit the program");


                Console.Write("Enter your choice: ");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    int m;

                    switch (option)
                    {
                        case 1:
                            Console.Write("Enter an element to insert: ");
                            m = Convert.ToInt32(Console.ReadLine());
                            set.Insert(m);
                            Console.WriteLine("The element has been inserted.");
                            break;

                        case 2:
                            Console.Write("Enter an element to remove: ");
                            m = Convert.ToInt32(Console.ReadLine());
                            set.Remove(m);
                            Console.WriteLine("The element has been removed.");
                            break;

                        case 3:
                            if (set.IsEmpty())
                            {
                                Console.WriteLine("The set is empty.");
                            }
                            else
                            {
                                Console.WriteLine("The set is not empty.");
                            }
                            break;

                        case 4:
                            Console.Write("Enter an element to check: ");
                            m = Convert.ToInt32(Console.ReadLine());
                            if (set.Contains(m))
                            {
                                Console.WriteLine("Yes, the set contains the element.");
                            }
                            else
                            {
                                Console.WriteLine("No, the set does not contain the element.");
                            }
                            break;

                        case 5:
                            int randomElement = set.RandomElement();
                            Console.WriteLine("Random element: " + randomElement);
                            break;

                        case 6:
                            int largestEntry = set.Largest();
                            if (set.IsEmpty())
                            {
                                Console.WriteLine("The set is empty.");
                            }
                            else
                            {
                                Console.WriteLine("Largest element: " + largestEntry);
                            }
                            break;

                        case 7:
                            set.PrintSet();
                            break;

                        case 8:
                            Console.WriteLine("Exiting the program . . .");
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please select from 1-8.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter a number from 1-8.");
                }
                catch (Exception err)
                {
                    Console.WriteLine("An error has occurred: " + err.Message);
                }

                Console.WriteLine();
            } while (option != 8);
        }
    }
}
