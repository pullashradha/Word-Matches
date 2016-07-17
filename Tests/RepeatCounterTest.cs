using Xunit;
using System;

namespace WordMatches.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void Test_WordNotInSentence_0()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      newRepeatCounter.SetWord("dog");
      newRepeatCounter.SetSentence("We love dogs");
      Assert.Equal(0, newRepeatCounter.CountRepeats());
    }
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
      newRepeatCounter.SetSentence("Our dogs, Rusty and Willow, are dogs. We love dogs! Do you love dogs? We have two other dogs- Apple and Tango. Our dogs love to play with other dogs; the dogs: play fetch, and run around.");
      Assert.Equal(8, newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void Test_CountsWordWithCharPreceding_true()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      newRepeatCounter.SetWord("dog");
      newRepeatCounter.SetSentence("We love dogs -dog");
      Assert.Equal(1, newRepeatCounter.CountRepeats());
    }
  }
}
