namespace Assignments_2._4._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements to be stored in the array.");
            if (!int.TryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine("Incorrect value, enter a number.");
            }

            int[] myArray = new int[value];
            Console.WriteLine($"\nInput {value} elements in the array.");
            CalculateArraySum(myArray);
        }

        public static void CalculateArraySum(int[] myArray)
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"element - {i}: ");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Incorrect value!");
                    break;
                }
                myArray[i] = number;
                sum += number;
            }

            Console.WriteLine($"\nSum of all elements stored in the array is: {sum}");
        }
    }
}
