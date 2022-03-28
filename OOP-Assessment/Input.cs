using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Assessment
{
    public class Input
    {
        private char[] toRemove = { ',', '!', '\'', '\"', '*' }; //encapsulated 
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string  manualTextInput()
        {
            List<string> Inputs = new List<string>();
            bool Asterisk = false;
            Console.WriteLine("input sentences one at a time, when you are done end the last sentence with an asterisk\n");
            while (Asterisk == false)
                //recursively allows the user to type text one sentence at a time
            {
                string Sentence = Console.ReadLine();
                Inputs.Add(Sentence);
                //checks for asterisks
                int found = Sentence.IndexOf('*');
                if (found != -1)
                {
                    Asterisk = true;
                }
            }
            string[] Sentences = Inputs.ToArray();
            //joins the sentences into one string and returns them
            string fullText = String.Join("", Sentences);

            return fullText;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            //reads text and puts it into a string
            string text = File.ReadAllText(fileName);
            Console.WriteLine(text[0]);
            return text;
        }

        public string formatText(string Sentences)
        //additional method
        //takes the text and removes unnescessary characters
        {
            foreach (char character in Sentences)
            {
                if (toRemove.Contains(character))
                {
                    Sentences = Sentences.Replace(character, ' ');
                }
                
            }
            return Sentences;
        }
    }    
}
