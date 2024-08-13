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

    throw new DivideByZeroException("Divide by zero is forbidden");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Divide by zero exception caught.");

    //throw;
}
catch (FormatException ex)
{
    string message = ex.Message;

    Console.WriteLine($"Exception ToString:  {message}");

    //Console.WriteLine(message);
    //Console.WriteLine(ex.StackTrace);

    Console.WriteLine("Format exception caught.");

    throw ex;
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


//int x = 0;
//int y = 100 / x;

//Console.WriteLine(y);

//double x1 = 0;

//if (x1 == 0)
//{
//    throw new DivideByZeroException();
//}

//double y1 = 100 / x1;

//Console.WriteLine(y1);