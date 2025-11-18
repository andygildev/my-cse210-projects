using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] splitWords = text.Split(" ");

        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {

        Random rand = new Random();
        int attempts = 0;

        while (attempts < numberToHide)
        {
            int index = rand.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                attempts++;
            }

            
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (var word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        string text = string.Join(" ", displayWords);
        return $"{_reference.GetDisplayText()}\n{text}";
    }
}
