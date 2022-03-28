﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Assessment
{
    public class Analyse
    {
        private char[] vowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' }; //encapsulated
        private char wordEnd = ' ';
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 6; i++)
            {
                values.Add(0);
            }
            //creates an array of all vowels
            
            foreach (char i in input)
            {
                //checks if the character is uppercase
                bool upper = Char.IsUpper(i);
                if (i == '.')
                {
                    //counts sentences
                    values[0]++;
                }
                if (vowels.Contains(i))
                {
                    //counts vowells
                    values[1]++;
                }
                if (!vowels.Contains(i) && Char.IsLetter(i))
                {
                    //counts consonants
                    values[2]++;
                }
                if (upper == true && Char.IsLetter(i))
                {
                    //counts uppercase letters
                    values[3]++;
                }
                if (upper == false && Char.IsLetter(i))
                {
                    //counts lowercase letters
                    values[4]++;
                }
            }
        //adds vowels and consonants
        values[5] = values[1] + values[2];
        return values;
        }

        public void GenerateLongs(string text)
        //Additional Method - checks for words with 7 or more letters and writes them to a text file
        {
            string allText = text.Replace(".", "");
            char wordEnd = ' ';
            string[] allWords = allText.Split(wordEnd);
            List<string> longWords = new List<string>();
            foreach (string word in allWords)
            {
                if (word.Length > 6)
                {
                    longWords.Add(word);
                }

            }
            File.WriteAllLines("longWords.txt", longWords);
            string fullpath = Path.GetFullPath("longWords.txt");
        }

        public Dictionary<char, int> letterFreq(string text)
        //Additional Method - counts the frequency of each letter in the text
        {
            text = text.Replace(".", "");
            text = text.Replace(" ", "");
            Dictionary<char, int> Frequencies = new Dictionary<char, int>();
            foreach (char character in text)
            {
                if (Frequencies.ContainsKey(character))
                {
                    Frequencies[character]++;
                }
                else
                {
                    Frequencies[character] = 1;
                }
            }
            return Frequencies;
        }
    }
}
