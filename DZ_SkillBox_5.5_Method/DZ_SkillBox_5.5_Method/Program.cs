using System;
using System.Globalization;

static class Program
{
    private static void Main()
    {
        //string text = "простой текст без точек и запятых";
        Console.Write("Введите предложение: ");
        string text = Console.ReadLine();
        WordWrap(text, true);
        ReversWords(text);
    }

    private static string[] WordWrap(string word, bool isWrap)
    {
        if (isWrap)
        {
            var ArrayWords = word.Split(' ');
            foreach (var item in ArrayWords)
            {
                Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.ToLower()));
            }

            return ArrayWords;

        }
        else
        {
            return word.Split(' ');
        }
    }

    private static void ReversWords(string words)
    {
        var ArrayWord = WordWrap(words, false);
        var w = ArrayWord.Reverse();

        foreach (var item in w)
        {
            Console.Write(item + " ");
        }
    }

}
