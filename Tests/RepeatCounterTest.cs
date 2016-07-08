using Xunit;
using System;

namespace WordMatches.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_ElementsInArray_3()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter ();
      newRepeatCounter.SetSentence("We love dogs");
      Assert.Equal(3, newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_IsWordInArray_true()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter ();
      newRepeatCounter.SetWord("dogs");
      newRepeatCounter.SetSentence("We love dogs");
      Assert.Equal(true, newRepeatCounter.CountRepeats());
    }
  }
}
