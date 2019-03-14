using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public class CountWord
    {
        public Dictionary<string, int> wordList = new Dictionary<string, int>();

        public void AddWord(string word)
        {
            if (wordList.ContainsKey(word))
            {
                wordList[word] += 1;
            }
            else
            {
                wordList.Add(word, 1);
            }
        }

        public void Stats()
        {
            int cnt = 1;
            int sum = 0;
            int unqSum = 0;
            foreach (var i in wordList)
            {
                if(i.Key.Length>5)
                Console.WriteLine( "{2}.\t {0} \t{1} ", i.Key, i.Value,cnt);
                else
                    Console.WriteLine("{2}.\t {0}\t\t{1} ", i.Key, i.Value, cnt);
                cnt++;
                sum += i.Value;
                if (i.Value == 1) unqSum += 1;
            }
            Console.WriteLine("\nОбщее количество слов: {0} из них уникальных: {1}",sum,unqSum);

        }
    }
}
