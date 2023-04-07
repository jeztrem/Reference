using System;

public class RemoveTest
{
    public static void Main()
    {


        string rootPath = "https://localhost:44382/";
        string locationsr = "https://localhost:44382/sr";
        string locationen = "https://localhost:44382/";
        string locationme = "https://localhost:44382/sr234324";

        int stripLength = rootPath.Length -1;

        Console.WriteLine(locationsr.Remove(0, stripLength));
        Console.WriteLine(locationen.Remove(0, stripLength));
        Console.WriteLine(locationme.Remove(0, stripLength));
            ;
        string name = "Michelle Violet Banks";

        Console.WriteLine("The entire name is '{0}'", name);

        // Remove the middle name, identified by finding the spaces in the name.
        int foundS1 = name.IndexOf(" ");
        int foundS2 = name.IndexOf(" ", foundS1 + 1);

        if (foundS1 != foundS2 && foundS1 >= 0)
        {
            name = name.Remove(foundS1 + 1, foundS2 - foundS1);

            Console.WriteLine("After removing the middle name, we are left with '{0}'", name);
        }
    }
}
// The example displays the following output:
//       The entire name is 'Michelle Violet Banks'
//       After removing the middle name, we are left with 'Michelle Banks'
