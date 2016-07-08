using Xunit;
using System;

namespace WordMatches.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_WordRepeatedInArray_true()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter ();
      newRepeatCounter.SetWord("dogs");
      newRepeatCounter.SetSentence("We love dogs");
      Assert.Equal("Your word appears 1 time(s) in the given sentence/phrase!", newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_WordRepeatedInArray_false()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter ();
      newRepeatCounter.SetWord("cats");
      newRepeatCounter.SetSentence("We love dogs");
      Assert.Equal("Your word does not appear in the given sentence/phrase! Enter in another sentence.", newRepeatCounter.CountRepeats());
    }
  }
}
