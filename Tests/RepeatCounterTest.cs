using Xunit;
using System;

namespace WordMatches.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void Test_CountsTimesWordRepeatedInSentence_1()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      newRepeatCounter.SetWord("dogs");
      newRepeatCounter.SetSentence("We love dogs");
      Assert.Equal(1, newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void Test_ExcludeSimilarWordValues_true()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      newRepeatCounter.SetWord("dogs");
      newRepeatCounter.SetSentence("My dog is scared of other dogs");
      Assert.Equal(1, newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void Test_CountsWordWithCharFollowing_true()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      newRepeatCounter.SetWord("dogs");
      newRepeatCounter.SetSentence("We love dogs! Do you love dogs?");
      Assert.Equal(2, newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void Test_CountsWordWithCharPreceding_true()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      newRepeatCounter.SetWord("dogs");
      newRepeatCounter.SetSentence("What did they name their pet -dogs");
      Assert.Equal(1, newRepeatCounter.CountRepeats());
    }
  }
}
