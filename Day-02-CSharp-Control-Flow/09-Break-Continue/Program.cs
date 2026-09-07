for (int i = 1; i <= 20; i++)
{
    if(i %2 != 0)
    {
        continue; // Skip the rest of the loop when i is even
    }
    Console.WriteLine(i);
}