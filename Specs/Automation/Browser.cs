using FluentAutomation.API;

namespace Specs.Automation
{
    public class BrowserAutomation : FluentTest
    {
        public override void Setup()
        {
            ScreenshotOnAssertException = true;
            ScreenshotPath = @"C:\temp\";
            base.Setup();
        }
    }
}
