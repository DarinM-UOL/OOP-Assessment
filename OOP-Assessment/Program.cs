//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Assessment
{
    class Program
    {
        static void Main()
        {
            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input getText = new Input();
            bool correct = false;
            string rawText = "";
            //allows the user to pick option one or two
            Console.WriteLine("do you want to manually enter text(type 'enter') or have it read from a file?(type 'read'): ");
            //error handling while loop
            while (correct == false)
            {
                string response = Console.ReadLine();
                //more error catching
                while (response != "enter" && response != "read")
                {
                    //makes the user input a correct value
                    Console.WriteLine("that response is invalid, please choose enter or read: ");
                    response = Console.ReadLine();
                }
                if (response == "enter")
                {
                    //runs option 1
                    string lines = getText.manualTextInput();
                    rawText = lines;
                }
                else if (response == "read")
                {
                    //runs option 2
                    bool valid = false;
                    //prevents user from inputting a value that will throw back an exception
                    while (valid == false)
                    {
                        Console.WriteLine("please input the file path of the selected file: ");
                        string path = Console.ReadLine();
                        //Exception handling, if the file cannot be found 
                        try
                        {
                            //runs option 2
                            string lines = getText.fileTextInput(path);
                            rawText = lines;
                            valid = true;
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("file not found, please try again.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That input is invalid");
                }
                correct = true;
            }

            string text = getText.formatText(rawText);
            //Create an 'Analyse' object
            Analyse analyseText = new Analyse();
            analyseText.GenerateLongs(text);
            //Pass the text input to the 'analyseText' method
            List<int> results = analyseText.analyseText(text);
            Dictionary<char, int> Frequencies = analyseText.letterFreq(text);
            //Receive a list of integers back
            Report Result = new Report();
            Result.reportValues(results, Frequencies);

            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }



    }


}

