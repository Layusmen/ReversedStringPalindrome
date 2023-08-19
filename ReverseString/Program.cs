namespace ReversedStringPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Reverse String App. Please insert a string: ");
            string insertedWords = Console.ReadLine().ToUpper();

            char[] stringArray = insertedWords.ToCharArray();
            Array.Reverse(stringArray);
            string reversedString = new string(stringArray);
            Console.WriteLine($"Actual String is : {insertedWords} \n");
            Console.WriteLine($"Reversed String is : {reversedString} ");

            /*Checking if the inserted string is same as the reversed string,
            with that we can test for palindrome.*/
            bool checkPalindrome = reversedString == insertedWords;

            // Print the result
            if (checkPalindrome)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }

        }
    }

}
