namespace ReversedStringPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input string and greetings
            Console.WriteLine("Welcome to Reverse String App. Please insert a string: ");
            string wordEntered = Console.ReadLine().ToUpper();

            //Reverse the string using loop
            string reversedString = string.Empty;
            for (int i = wordEntered.Length - 1; i >= 0; i--)
            {
                reversedString += wordEntered[wordEntered.Length - 1 - i];
            }

            //Output the input and reversed strings
            Console.WriteLine($"Inserted String : {wordEntered}\n");
            Console.WriteLine($"Reversed String : {reversedString}");

            /*Checking if the inserted string is same as the reversed string,
            with that we can test for palindrome.*/
            bool checkPalindrome = reversedString == wordEntered;

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
