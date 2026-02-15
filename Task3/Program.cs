using System.Security.Cryptography;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = [];
                     
            while (true)
            {
                Console.WriteLine("Enter P : To print numbers");
                Console.WriteLine("Enter A : To Add a number");
                Console.WriteLine("Enter M : To Display mean of the numbers");
                Console.WriteLine("Enter S : Display the smallest number");
                Console.WriteLine("Enter L : Display the largest number");
                Console.WriteLine("Enter F : search for a number in the list and if found display the index");
                Console.WriteLine("Enter C : clearing out the list");
                Console.WriteLine("Enter D : delete a number in the list ");
                Console.WriteLine("Enter Q : To Quit");

                Char practical = Char.Parse(Console.ReadLine());
               practical= Char.ToUpper(practical);

                switch (practical) 
                {
                    case 'P':
                        {
                            if (list.Count > 0)
                            {
                                for (int i = 0; i < list.Count; i++)
                                {
                                    Console.Write(list[i] + " ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The list is empty ");
                            }
                            Console.Write("\n");
                        }
                     break;

                    case 'A':
                        int addNumber = int.Parse(Console.ReadLine());  
                        bool exists = false;
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == addNumber)
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine($"Number {addNumber} already exists in the list, not added.");
                        }
                        else
                        {
                            list.Add(addNumber);
                            Console.WriteLine($"Number {addNumber} added successfully.");
                        }

                        break;

                    case 'M':
                        {
                            if (list.Count > 0)
                            {
                                int sum = 0;
                                for (int i = 0; i < list.Count; i++)
                                {
                                    sum += list[i];
                                }
                                double avg = sum / list.Count;
                                Console.WriteLine($"The average of list = {avg}");
                            }
                            else {
                                Console.WriteLine("list is empty");
                                 }
                        }
                      break;

                    case 'S' :
                        {
                            if (list.Count > 0)
                            {
                                int largestNumber = list[0];
                                for (int i = 1; i < list.Count; i++)
                                {
                                    if (list[i] < largestNumber)
                                        largestNumber = list[i];
                                }
                                Console.WriteLine(largestNumber);
                            }
                            else if (list.Count == 0)
                            {
                                Console.WriteLine("List is Empty");
                            }

                            
                        }
                     break;

                    case 'L' :
                        {
                            if (list.Count > 0)
                            {
                                int smallestNumber = list[0];
                                for (int i = 1; i < list.Count; i++)
                                {
                                    if (list[i] > smallestNumber)
                                        smallestNumber = list[i];
                                }
                                Console.WriteLine(smallestNumber);
                            }
                            else
                            {
                                Console.WriteLine("List is Empty");
                            }
                        }
                     break;

                    case 'C':
                        list.Clear();
                        Console.WriteLine("list is empty");
                        break;

                    case 'F':
                        Console.Write("Enter a number to search: ");
                        int searchNumber = int.Parse(Console.ReadLine());
                        bool found = false;

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == searchNumber)
                            {
                                Console.WriteLine($"Number {searchNumber} found at index {i}");
                                found = true;
                                break; 
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine($"Number {searchNumber} not found in the list");
                        }
                        break;

                    case 'D':
                        Console.Write("Enter a number to delete: ");
                        int deleteNumber = int.Parse(Console.ReadLine());
                        bool deleted = false;

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == deleteNumber)
                            {
                                list.RemoveAt(i); 
                                Console.WriteLine($"Number {deleteNumber} deleted successfully.");
                                deleted = true;
                                break;
                            }
                        }

                        if (!deleted)
                            Console.WriteLine($"Number {deleteNumber} not found in the list.");
                        break;

                    case 'Q':
                        string Q = " Good buy ";
                        return ;
                     

                    default:
                        Console.WriteLine("invalid choice ");
                        break;



                }
                   
            }
        }
    }
}
