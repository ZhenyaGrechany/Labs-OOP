using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab5
{
    class Punctuation
    {
        List<string> listOfPunct;
        public Punctuation()
        {
            listOfPunct = new List<string>();
            listOfPunct.Add(",");
        }
        public List<string> GetCollectionOfPunct
        {
            get { return listOfPunct; }
        }
    }
    class Letter
    {
        private char letter;
        public Letter(char letter)
        {
            this.letter = letter;
        }

        public string GetLetter
        {
            get { return letter.ToString(); }
        }
    }

    class Word
    {
        private string word;
        private Letter[] arrayOfLetters;
        //Конструктор, в котором заполняется массив Letter, где каждый элемент массива - это объект типа Letter
        public Word(string word)
        {
            this.word = word;
            arrayOfLetters = new Letter[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                Letter letter = new Letter(word[i]);
                arrayOfLetters[i] = letter;
            }
        }
        public int GetLengthArrayOfLetters
        {
            get { return arrayOfLetters.Length; }
        }
        public string GetWord
        {
            get { return word; }
        }
        public Letter GetLetter(int k)
        {
            return arrayOfLetters[k];
        }

    }
    class Sentence
    {
        private Word[] arrayOfWords;
        //Конструктор, в котором заполняется массив Word, где каждый элемент массива - это объект, который хранит в себе массив объектов типа Letter
        public Sentence(string sentence)
        {
            string[] sentenceArrayOfWords = sentence.Replace(", ", ",").Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            arrayOfWords = new Word[sentenceArrayOfWords.Length];
            for (int i = 0; i < sentenceArrayOfWords.Length; i++)
            {
                Word word = new Word(sentenceArrayOfWords[i]);
                arrayOfWords[i] = word;
            }
        }
        public int GetLengthArrayOfWords
        {
            get { return arrayOfWords.Length; }
        }
        public Word GetWord(int k)
        {
            return arrayOfWords[k];
        }
    }
    class Text
    {
        private Sentence[] arrayOfSentences;
        Dictionary<string, int> myDict = new Dictionary<string, int>();
        string[] words;
        //Конструктор, в котором заполняется массив Sentence, где каждый элемент массива - это объект, который хранит в себе массив объектов типа Word
        public Text(string text, string[] words)
        {
            this.words = words;
            string[] textArrayOfSentences = text.Split(new char[] { '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
            arrayOfSentences = new Sentence[textArrayOfSentences.Length];
            for (int i = 0; i < textArrayOfSentences.Length; i++)
            {
                Sentence sentence = new Sentence(textArrayOfSentences[i]);
                arrayOfSentences[i] = sentence;
            }
            CreateEditedText();
        }
        private void CreateEditedText()
        {
            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arrayOfSentences.Length; j++)
                {
                    Sentence helpSentence = arrayOfSentences[j];
                    for (int k = 0; k < helpSentence.GetLengthArrayOfWords; k++)
                    {
                        if (words[i].ToLower() == helpSentence.GetWord(k).GetWord.ToLower())
                        {
                            count++;
                        }
                    }
                }
                myDict[words[i]] = count;
            }
        }
        public Dictionary<string, int> GetDict
        {
            get { return myDict; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Водсортувати", "Задано", "Слова" };
            string myText = "задано текст та масив слов. Подрахувати у сколькох реченнях зустрочається кожне слово масиву. Водсортувати  слова заданого задано тексту за зростанням колькосто в них заданої лотери. Водсортувати слова заданого тексту, що починаються з голосних лотер, за другою лотерою. Оз заданого тексту видалити всо слова визначеної довжини, що починаються з приголосної лотери.";
            Console.WriteLine(myText);

            Text text = new Text(myText, words);
            Dictionary<string, int> dict = text.GetDict;

            foreach (KeyValuePair<string, int> keyValue in dict)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.ReadKey();
        }
    }
}

