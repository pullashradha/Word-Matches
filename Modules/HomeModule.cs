using System;
using Nancy;
using WordMatches.Objects;
using System.Collections.Generic;

namespace WordMatches
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get ["/"] = _ => View ["index.cshtml"];
      Post ["/result"] = _ => {
        RepeatCounter newCounter = new RepeatCounter ();
        newCounter.SetWord(Request.Form["word-input"]);
        newCounter.SetSentence(Request.Form["sentence-input"]);
        return View ["result.cshtml", newCounter.CountRepeats()];
      };
    }
  }
}
