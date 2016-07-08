using Xunit;
using System;

namespace WordMatches.Objects
{
  public class RepeatCounterTest
  {
    // [Fact]
    // public void CountRepeats_DisplaySentenceArray_true()
    // {
    //   RepeatCounter newRepeatCounter = new RepeatCounter ();
    //   newRepeatCounter.SetSentence("I love dogs");
    //   Assert.Equal("I love dogs", newRepeatCounter.CountRepeats());
    // }
    // [Fact]
    // public void CountRepeats_CountElementsInArray_3()
    // {
    //   RepeatCounter newRepeatCounter = new RepeatCounter ();
    //   newRepeatCounter.SetSentence("We love dogs");
    //   Assert.Equal(3, newRepeatCounter.CountRepeats());
    // }
    [Fact]
    public void CountRepeats_WordRepeatedInArray_true()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter ();
      newRepeatCounter.SetWord("dogs");
      newRepeatCounter.SetSentence("We love dogs, and dogs love us, because dogs are cool!");
      Assert.Equal(3, newRepeatCounter.CountRepeats());
    }
  }
}
