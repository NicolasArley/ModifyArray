
namespace ModifyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one of the options to run:\n" +
               "1. Examples of array declaration.\n" +
               "2. Manipulating an array.\n");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Arrays.Arraydeclaration();
                    break;

                case "2":
                    ManipulationArrays.Manipulation();
                    break;
            };

        }
    }

    public class Arrays
    {

        public static void Arraydeclaration()
        {
            Console.Clear();
            string[] arraystring = { "Jake", "Ramiro", "Juan", "Hugo", "Steve" };
            int[] arrayint = { 1, 2, 3 };
            double[] numbers = new double[5];
            numbers[0] = 1.234;
            numbers[1] = 5.678;
            numbers[2] = 9.012;
            numbers[3] = 3.456;
            numbers[4] = 7.890;

            Console.WriteLine("The following numbers were declared through their position in the array: \n" +
                "numbers[0] = 1.234;\r\n numbers[1] = 5.678;\r\n numbers[2] = 9.012;\r\n numbers[3] = 3.456;\r\n " +
                "numbers[4] = 7.890;\n");
           
            Array.ForEach(numbers, Console.WriteLine);
            Console.ReadKey();

            Console.WriteLine("\nThe following numbers were declared next to the array:\n" +
                "int[] arrayint = {1, 2, 3}; \n" +
                "And only the number in index 1 of the array was modified:\n" +
                "arrayint[1] = 6;\n");
            arrayint[1] = 6;
            List<int> nums = arrayint.ToList();
            nums.ForEach(Console.WriteLine);

            Console.WriteLine("\nThis last array was declared as the previous one, only the data type changed:\n" +
                "string[] arraystring = {\"Jake\", \"Ramiro\", \"Juan\", \"Hugo\", \"Steve\"};\n");
            Console.WriteLine(String.Join(", ", arraystring));
            Console.ReadKey();


        }

    }

    public class ManipulationArrays
    {

        public static void Manipulation()
        {
            string[] Listofthings = new string[10]; 
            string message = "Do you want to repeat another action? y/n";
            string? repeat = "y";
            string search = "";
            string newelement = "";
            

            do 
            {
                Console.WriteLine("Choose one of the options to run:\n" +
                "1. Add elements.\n" +
                "2. Modify element.\n" +
                "3. Show elements.\n");
                string? option = Console.ReadLine();

                switch (option)
                {
                    //Guardar
                    case "1":
                        for(int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Type the name of the object you want to add:" + i);
                            Listofthings[i] = Console.ReadLine();
                        }
                        Console.WriteLine(message);
                        repeat = Console.ReadLine();
                        Console.Clear();
                        break;
                    //Modificar
                    case "2":
                        Console.WriteLine("Type the name of the object you want to remove");
                        search = Console.ReadLine();
                        Console.WriteLine("Type the name of the new object");
                        newelement = Console.ReadLine();
                        for (int i = 0; i < 10; i++)
                        {
                            if (Listofthings[i] == search)
                            {
                                Listofthings[i] = newelement;
                                Console.WriteLine("The element has been modified.");
                            }
                            else
                            {
                                Console.WriteLine("The item you wanted to modify was not found.");
                            }
                        }
                        Console.WriteLine(message);
                        repeat = Console.ReadLine();
                        Console.Clear();
                        break;
                    //Mostrar
                    case "3":
                        Array.ForEach(Listofthings, Console.WriteLine);
                        Console.ReadKey();
                        Console.WriteLine(message);
                        repeat = Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("You didn't enter a valid option.\n" +
                            "please enter one of the valid options.");
                        Console.WriteLine(message);
                        repeat = Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (repeat == "y");
        }
    }

}
