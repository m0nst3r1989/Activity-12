using System;
using System.IO;
using System.Text;
public class Letters
{
    public static void Main()
    {
        //making my strings
        int letter, i;


        //this is where my my program reads my file
        string str = System.IO.File.ReadAllText("Input.txt");

        i = 1;
        letter = 1;

        /* this loop will finish once all of the text has been read */
        while (i <= str.Length - 1)
        {
            /* checking the character types*/
            if ((str[i] == '.' || str[i] == ' ' || str[i] == '\t' || str[i] == '!' || str[i] == ',' || str[i] == '?' || str[i] == '\n') && (str[i - 1] == 't' || str[i - 1] == 'e'))
            {
                letter++;
            }


            i++;
        }

        Console.Write("There are {0} words ending in t or e", letter);
    }
}