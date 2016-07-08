using System;
using Nancy;
using Xunit;
using System.Collections.Generic;

namespace WordMatches.Objects
{
  public class RepeatCounter
  {
    // private string _wordInput;
    private string _sentenceInput;
    private int numberArrayElements;
    // public string GetWord()
    // {
    //   return _wordInput;
    // }
    // public void SetWord(string newWord)
    // {
    //   _wordInput = newWord;
    // }
    public string GetSentence()
    {
      return _sentenceInput;
    }
    public void SetSentence(string newSentence)
    {
      _sentenceInput = newSentence;
    }
    public int CountRepeats()
    {
      string[] sentenceArray = _sentenceInput.Split();
      foreach (string word in sentenceArray)
      {
        numberArrayElements += 1;
      }
      return numberArrayElements;
    }
  }
}
