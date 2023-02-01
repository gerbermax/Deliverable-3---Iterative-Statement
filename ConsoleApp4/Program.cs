// Input maximum integer
int max = 0;
// Infinite loop to make user enter until valid data is entered
while (true)
{
    try
    {
        Console.WriteLine("Enter integer between 1 to 100: ");
        max = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Only integer numbers are allowed");
    }
}

// Input series type odd or even
Console.WriteLine("Specify series (Odd/Even): ");
// Lower class it so user can enter series in any input
string series = Console.ReadLine().ToLower();

// Display the output
Console.WriteLine("You have selected the ", series, " series. The numbers between 0 and ", max, " are:");
// If series is odd
if (series == "odd")
{
    // Loop from 1 to max 
    for (int i = 1; i <= max; i++)
    {
        // Check if number is odd
        if (i % 2 == 1)
        {
            // Display the output
            Console.WriteLine(i);
        }
    }
}
// If series is even
if (series == "even")
{
    // Loop from 1 to max 
    for (int i = 1; i <= max; i++)
    {
        // Check if number is even
        if (i % 2 == 0)
        {
            // Display the output
            Console.WriteLine(i);
        }
    }
}