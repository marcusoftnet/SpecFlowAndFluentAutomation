using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Specs.Automation;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    [Binding]
    public class SpecFlowEvents
    {
        [BeforeScenario]
        public void BeforeScenario() { }

        [AfterScenario]
        public void AfterScenario() { DBWrapper.EmptyAllTestData(); }

        [AfterTestRun]
        public static void AfterTestRun() { PageWrapperBase.Browser.Finish(); }

    }
}
