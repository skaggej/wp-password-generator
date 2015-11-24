using System;
using System.Security.Cryptography;
using Skaggs.Utilities;

/// <summary>
/// Illustrates the use of the RandomPassword class.
/// </summary>
public class RandomPasswordTest
{    
    /// <summary>
    /// The main entry point for the application.    
    /// </summary>
    [STAThread]    static void Main(string[] args)    
    {
        // Print 100 randomly generated passwords (8-to-10 char long).
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(RandomPassword.Generate(8, 10));
        }
        Console.ReadLine();
    }
}
//
// END OF FILE
///////////////////////////////////////////////////////////////////////////////