// Commit 2: Added loop structure
// Commit 3: Implemented FizzBuzz logic.
// Commit 4: Final testing and cleanup

for (int i = 1; i <= 100; i++)
    //LOGIC BELOW
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}