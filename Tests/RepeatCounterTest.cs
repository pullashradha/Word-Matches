using Xunit;
using System;

namespace WordMatches.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void Test_TimesWordRepeatedInArray_1()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      newRepeatCounter.SetWord("dogs");
      newRepeatCounter.SetSentence("We love dogs");
      Assert.Equal(1, newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void Test_ExcludeSimilarValues_true()
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
      newRepeatCounter.SetSentence("We love dogs! Do you like dogs?");
      Assert.Equal(0, newRepeatCounter.CountRepeats());
    }
  }
}
