using System;
using Nancy;
using Xunit;
using System.Collections.Generic;

namespace WordMatches.Objects
{
  public class RepeatCounter
  {
    private string _wordInput;
    private string _sentenceInput;
    public string GetWord()
    {
      return _wordInput;
    }
    public void SetWord(string newWord)
    {
      _wordInput = newWord;
    }
    public string GetSentence()
    {
      return _sentenceInput;
    }
    public void SetSentence(string newSentence)
    {
      _sentenceInput = newSentence;
    }
    public bool IsWordInArray()
    {
      foreach (string word in _sentenceArray)
      {
        if (_wordInput == word)
        {
          return true;
        }
      }
      return false;
    }
    public int CountRepeats()
    {
      string[] _sentenceArray = _sentenceInput.Split();
      int numberArrayElements = 0;
      foreach (string word in _sentenceArray)
      {
        numberArrayElements += 1;
      }
      return numberArrayElements;
    }
  }
}
