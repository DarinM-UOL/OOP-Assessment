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
            string text = "";
            Console.WriteLine("do you want to manually enter text(type 'enter') or have it read from a file?(type 'read'): ");
            while (correct == false)
            {
                string response = Console.ReadLine();
                while (response != "enter" && response != "read")
                {
                    Console.WriteLine("that response is invalid, please choose enter or read: ");
                    response = Console.ReadLine();
                }
                if (response == "enter")
                {
                    string lines = getText.manualTextInput();
                    text = lines;
                }
                else if (response == "read")
                {
                    Console.WriteLine("please input the file path of the selected file: ");
                    string path = Console.ReadLine();
                    string lines = getText.fileTextInput(path);
                    text = lines;
                }
                else
                {
                    Console.WriteLine("That input is invalid");
                }
                correct = true;
            }
            getText.formatText(text);

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse analyseText = new Analyse();
            List<int> results = analyseText.analyseText(text);
            //Receive a list of integers back
            Report Result = new Report();
            Result.reportValues(results);

            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }



    }


}

