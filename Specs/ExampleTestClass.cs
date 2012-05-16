using System;
using FluentAutomation.API;
using FluentAutomation.API.Enumerations;
using NUnit.Framework;

namespace Specs
{
    [TestFixture]
    public class ExampleTestClass : FluentTest
    {
        public override void Setup()
        {
            ScreenshotOnAssertException = true;
            ScreenshotPath = @"C:\TestResults\ExceptionImages\";
            base.Setup();
        }

        [TestFixtureSetUp]
        public void TestSetUp()
        {
            I.Use(BrowserType.Firefox);
        }

        [Test]
        public void Test()
        {
            I.Open("http://www.google.com/");
        }

        [Test]
        public void Drag_Drop_Test()
        {
            I.Open("http://developer.yahoo.com/yui/examples/dragdrop/dd-groups.html");
            I.Drag("#pt1").To("#t2");
            I.Drag("#pt2").To("#t1");
            I.Drag("#pb1").To("#b1");
            I.Drag("#pb2").To("#b2");
            I.Drag("#pboth1").To("#b3");
            I.Drag("#pboth2").To("#b4");
            I.Drag("#pt1").To("#pt2");
            I.Drag("#pboth1").To("#pb2");
        }
    }
}
