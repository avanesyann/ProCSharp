using ProcessMultipleExceptions;

Console.WriteLine("***** Handling Multiple Exceptions *****\n");

Car myCar = new Car("Rusty", 90);
try
{
    // Trip Arg out of range exception.
    myCar.Accelerate(-10);
}
catch (CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
{
    Console.WriteLine(e.Message);

    try
    {
        FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
    }
    catch (Exception e2)
    {
        // This causes a compile error-InnerException is read only
        // Throw an exception that records the new exception
        // as well as the message of the first exception.
        throw new CarIsDeadException(e.CauseOfError, e.ErrorTimeStamp, e.Message, e2);
    }
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
// This will catch any other exception
// beyond CarIsDeadException or
// ArgumentOutOfRangeException.
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    // This will always occur. Exception or not.
    myCar.CrankTunes(false);
}


// General catch
// (this is not the most informative way to handle exceptions)
//try
//{
//    myCar.Accelerate(90);
//}
//catch
//{
//    Console.WriteLine("Something bad happened...");
//}