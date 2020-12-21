using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CRUD c = new CRUD();
            string ID, Name, ch;
            do
            {
                Console.WriteLine("Choose an option:\n1.Create \n2. Read \n3. Update \n4.Delete\n5. Exit");
                ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        Console.WriteLine("Enter ID:");
                        ID = Console.ReadLine();
                        Console.WriteLine("Enter Name:");
                        Name = Console.ReadLine();
                        Console.WriteLine(c.create(ID, Name));
                        break;
                    case "2":
                        Console.WriteLine("Enter ID:");
                        ID = Console.ReadLine();
                        Console.WriteLine(c.read(ID));
                        break;
                    case "3":
                        Console.WriteLine("Enter ID:");
                        ID = Console.ReadLine();
                        Console.WriteLine("Enter Name:");
                        Name = Console.ReadLine();
                        Console.WriteLine(c.update(ID, Name));
                        break;
                    case "4":
                        Console.WriteLine("Enter ID:");
                        ID = Console.ReadLine();
                        Console.WriteLine(c.delete(ID));
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Choose the right option");
                        break;
                }
            } while (ch != "5");
        }
    }
}
