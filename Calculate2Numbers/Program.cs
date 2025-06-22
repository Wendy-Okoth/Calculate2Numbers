// See https:/
// This C# program implements a simple console-based calculator
// that performs addition, subtraction, multiplication, and division
// on two numbers provided by the user.

using System; // Imports the System namespace, which contains fundamental classes and base types.

namespace SimpleCalculator // Defines a namespace to organize the code.
{
    class Calculate2Num // Defines the main class for the program.
    {
        static void Main(string[] args) // The entry point of the program.
        {
            // Display a welcome message to the user.
            Console.WriteLine("Welcome to the Simple C# Calculator!");
            Console.WriteLine("-------------------------------------");

            double num1; // Declare a variable to store the first number.
            double num2; // Declare a variable to store the second number.
            string operation; // Declare a variable to store the chosen operation.
            double result = 0; // Declare a variable to store the result, initialized to 0.

            // --- Get the first number from the user ---
            while (true) // Loop until valid input is received.
            {
                Console.Write("Enter the first number: "); // Prompt for input.
                string input1 = Console.ReadLine(); // Read the user's input as a string.

                // Attempt to parse the string input to a double.
                // double.TryParse returns true if successful, false otherwise.
                if (double.TryParse(input1, out num1))
                {
                    break; // Exit the loop if parsing is successful.
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number."); // Error message for invalid input.
                }
            }

            // --- Get the operation from the user ---
            while (true) // Loop until a valid operation is received.
            {
                Console.Write("Enter the operation (+, -, *, /): "); // Prompt for input.
                operation = Console.ReadLine(); // Read the user's input.

                // Check if the entered operation is one of the valid ones.
                if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                {
                    break; // Exit the loop if the operation is valid.
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please enter +, -, *, or /."); // Error message for invalid operation.
                }
            }

            // --- Get the second number from the user ---
            while (true) // Loop until valid input is received.
            {
                Console.Write("Enter the second number: "); // Prompt for input.
                string input2 = Console.ReadLine(); // Read the user's input as a string.

                // Attempt to parse the string input to a double.
                if (double.TryParse(input2, out num2))
                {
                    // Special check for division by zero.
                    if (operation == "/" && num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero. Please enter a non-zero second number.");
                    }
                    else
                    {
                        break; // Exit the loop if parsing is successful and not division by zero.
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number."); // Error message for invalid input.
                }
            }

            // --- Perform the calculation based on the chosen operation ---
            switch (operation) // Use a switch statement for cleaner handling of multiple operations.
            {
                case "+":
                    result = num1 + num2; // Perform addition.
                    break;
                case "-":
                    result = num1 - num2; // Perform subtraction.
                    break;
                case "*":
                    result = num1 * num2; // Perform multiplication.
                    break;
                case "/":
                    result = num1 / num2; // Perform division (division by zero handled above).
                    break;
                default:
                    // This case should ideally not be reached due to the input validation loop.
                    Console.WriteLine("An unexpected error occurred with the operation.");
                    break;
            }

            // --- Display the result ---
            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}"); // Output the full expression and result.
            Console.WriteLine("\nPress any key to exit."); // Prompt user to press a key before closing.
            Console.ReadKey(); // Keep the console window open until a key is pressed.
        }
    }
}

