namespace TestTask3
{
    internal class Program
    {
        static string Multiples(int[] arr)
        {
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                { 
                    result += arr[i];
                    result += " ";
                };
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of numbers in array:");
            int count = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the number:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The answer is: " + Multiples(array));
            Console.ReadLine();
        }
    }
}