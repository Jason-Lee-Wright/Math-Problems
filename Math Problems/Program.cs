namespace Math_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is the Float example you wanted!
            float bigNumber = 350000000000000000f;
            Console.WriteLine($"Big Number: {bigNumber:F0}");
            Console.WriteLine("Add 1!");
            Console.WriteLine($"New Big Number: {(bigNumber + 1):F0}");
            Console.WriteLine("?? Did not change!");

            //This is just being used as a seperation in the console.
            Console.WriteLine();   

            //This is the int overflow!
            int Maximum = 2147483647; //this is the highest an int can be
            int Overflow = Maximum + 1;
            Console.WriteLine($"Maximum: {Maximum}");
            Console.WriteLine($"Overflow: {Overflow}");
            Console.WriteLine($"Dividing non int numbers: {3 / 2}");

        }
    }
}
