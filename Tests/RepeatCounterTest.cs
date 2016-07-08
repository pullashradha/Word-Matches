using Xunit;
using System;

namespace WordMatches.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_DisplaySentenceArray_true()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter ();
      newRepeatCounter.SetSentence("I love dogs");
      Assert.Equal("I love dogs", newRepeatCounter.CountRepeats());
    }
  }
}
