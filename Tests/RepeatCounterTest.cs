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
      newRepeatCounter.SetSentence("We love dogs, and dogs love us, because dogs are cool!");
      Assert.Equal(3, newRepeatCounter.CountRepeats());
    }
  }
}
