using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Specs.Automation;
using Specs.Automation.PageWrappers;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    [Binding]
    public class SpecFlowEvents
    {
        [AfterScenario]
        public void AfterScenario() { DBWrapper.EmptyAllTestData(); }

        [AfterTestRun]
        public static void AfterTestRun() { PageWrapperBase.Browser.Finish(); }

    }
}
