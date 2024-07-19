try {
    // Code that may throw an exception
    int result = SomeMethodThatMightThrowException();
    Console.WriteLine(result);
} catch (IOException ex) {
    // Handle IOException
    Console.WriteLine("IOException occurred: " + ex.Message);
} catch (FormatException ex) {
    // Handle FormatException
    Console.WriteLine("FormatException occurred: " + ex.Message);
} catch (Exception ex) {
    // Handle other types of exceptions
    Console.WriteLine("Exception occurred: " + ex.Message);
}
