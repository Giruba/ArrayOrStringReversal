using System;

namespace ReverseAnArrayOrString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse an Array or String!");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Enter one of these options...");
            Console.WriteLine("1. Reverse an array");
            Console.WriteLine("2. Reverse a string");
            try
            {
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    ReverseArray();
                }
                else if (option == 2)
                {
                    ReverseString();
                }
                else {
                    Console.WriteLine("Please enter only one of the specified options!");
                }
            } catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }

            Console.ReadLine();
        }

        private static void ReverseArray() {

            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int noOfElements = int.Parse(Console.ReadLine());
                int[] array = new int[noOfElements];
                Console.WriteLine("Enter the elements separated by space");
                String elemens = Console.ReadLine();
                String[] elements = elemens.Split(' ');

                for (int i = 0; i < noOfElements; i++) {
                    array[i] = int.Parse(elements[i]);
                }

                ReverseTheArray(array);

            }catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }

        }

        private static void ReverseTheArray(int[] array) {

            int start = 0;
            int end = array.Length - 1;

            while (start < end) {
                int temp = array[end];
                array[end--] = array[start];
                array[start++] = temp;
            }

            Console.WriteLine("The reversed array --------------");
            for (int i = 0; i < end + 1; i++) {
                Console.Write(array[i]+ " ");
            }

        }

        private static void ReverseString() {
            Console.WriteLine("Enter the string to be reversed");
            try
            {
                String input = Console.ReadLine();
                Char[] newString = input.ToCharArray();
                int start = 0; int end = input.Length - 1;
                while (start < end)
                {
                    char temp = input[end];
                    newString[end--] = input[start];
                    newString[start++] = temp;
                }

                Console.WriteLine("Reversed string is \""+ new string(newString) + "\"");
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }
        }
    }
}
