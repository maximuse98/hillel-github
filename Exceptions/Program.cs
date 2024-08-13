Console.WriteLine("Hello, World!");

try
{
    int t = 10;
    int j = 40;

    //Console.WriteLine("Enter a number: ");
    //Console.ReadLine();

    Console.WriteLine(j);

    int.Parse("adasd");

    int zero = 0;
    int k = 5 / zero;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Divide by zero exception caught.");
}
catch (FormatException)
{
    Console.WriteLine("Format exception caught.");
}
catch (Exception)
{
    Console.WriteLine("General exception caught.");
}
finally
{
    Console.WriteLine("Finally block.");
}

Console.WriteLine("Goodbye, World!");