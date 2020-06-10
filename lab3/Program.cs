using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3_var9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> my_dict = new Dictionary<string, int>();
            string[] my_text = "задано текст та масив слов. Подрахувати у сколькох реченнях зустрочається кожне слово масиву. Водсортувати  слова заданого задано тексту за зростанням колькосто в них заданої лотери. Водсортувати слова заданого тексту, що починаються з голосних лотер, за другою лотерою. Оз заданого тексту видалити всо слова визначеної довжини, що починаються з приголосної лотери.".Replace(". ", ".").Split(new char[] { '.' });
            string[] words = { "Водсортувати", "Задано", "Слова" };
            //для каждого слова
            for (int i = 0; i < words.Length; i++)
            {
                int counter = 0;
                //для каждого предложения
                for (int j = 0; j < my_text.Length; j++)
                {
                    string[] help = my_text[j].Split(new char[] { ' ' });
                    //для каждого слова в каждом предложении
                    for (int k = 0; k < help.Length; k++)
                    {
                        //чтоб с регистром проблем не было
                        if (words[i].ToLower() == help[k].ToLower())
                        {
                            counter++;
                            break;
                        }
                    }
                }
                //записали как ключ слово, как значение в скольких предложениях оно есть в тексте
                my_dict[words[i]] = counter;
            }
            foreach (KeyValuePair<string, int> keyValue in my_dict)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.ReadKey();
        }
    }
}
