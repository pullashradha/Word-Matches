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
      newRepeatCounter.SetSentence("We love dogs");
      Assert.Equal(3, newRepeatCounter.CountRepeats());
    }
  }
}
