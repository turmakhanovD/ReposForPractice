using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GenericsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            CountWord countWord = new CountWord();
            string text = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном  чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек";
            char[] separator = { ' ', ',', '.','!' };
            string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        
            foreach (string i in words)
            {
                countWord.AddWord(i);
            }
            StringFormat stringFormat = new StringFormat();
         
 
            Console.WriteLine("\t Слово:\t\tКол-во:");
           
            countWord.Stats();
            Console.ReadLine();
        }
    }
}
