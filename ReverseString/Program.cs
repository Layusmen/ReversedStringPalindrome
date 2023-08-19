namespace ReversedStringPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input string and greetings
            Console.WriteLine("Welcome to Reverse String App. Please insert a string: ");
            string insertedWords = Console.ReadLine().ToUpper();

            //Convert to array and reverse
            char[] stringArray = insertedWords.ToCharArray();
            Array.Reverse(stringArray);
            string reversedString = new string(stringArray);

            //Output the input and reversed strings
            Console.WriteLine($"Inserted String : {insertedWords}\n");
            Console.WriteLine($"Reversed String : {reversedString}");

            /*Checking if the inserted string is same as the reversed string,
            with that we can test for palindrome.*/
            bool checkPalindrome = reversedString == insertedWords;

            // Check if the string is a Palindrome.
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