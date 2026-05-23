using System.Numerics;
using System.Reflection.PortableExecutable;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    // Constructor for diapason of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    // Method that brings it all in one string
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
    public static Reference ParseFromString(string referenceText)
    {
        string[] bookAndRest = referenceText.Split(' ');
        string book = bookAndRest[0];
        string rest = bookAndRest[1];
        string[] chapterAndVerse = rest.Split(':');
        int chapter = int.Parse(chapterAndVerse[0]);
        string versePart = chapterAndVerse[1];
        if (versePart.Contains('-'))
        {
            string[] verses = versePart.Split('-');
            int verse1 = int.Parse(verses[0]);
            int verse2 = int.Parse(verses[1]);
            return new Reference(book, chapter, verse1, verse2);
        }
        else
        {
            int verse = int.Parse(versePart);
            return new Reference(book, chapter, verse);
        }
    }

    }