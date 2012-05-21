using System;
using FluentAutomation.API;
using FluentAutomation.API.Enumerations;
using NUnit.Framework;

namespace Specs.FluentDemos
{
    [TestFixture]
    public class AdvancedDynamicStuff : FluentTest
    {
        private static string TESTURL = "http://automation.apphb.com/forms";

        [TestFixtureSetUp]
        public void TestSetUp()
        {
            I.Use(BrowserType.Chrome);
            I.Open(TESTURL);
        }

        [TestFixtureTearDown]
        public void TestTearDown()
        {
            I.Finish();
        }

        [Test]
        public void Autocomplete_ExpectedResult()
        {
            I.Open(TESTURL);
            I.Enter("abcd").In("#form02input02");


            // wait for our keypresses to be processed
            I.Wait(TimeSpan.FromMilliseconds(2500));
            I.Expect.Text("Khogaijc").In("ul.typeahead li:eq(0) a");
        }

        [Test]
        public void CartEditor_BuyMotorcycles()
        {
            I.Open(TESTURL);
            I.Select("Motorcycles").From(".liveExample tr select:eq(0)"); // Select by value/text
            I.Select(2).From(".liveExample tr select:eq(1)"); // Select by index
            I.Enter(6).In(".liveExample td.quantity input:eq(0)");
            I.Expect.Text("$197.70").In(".liveExample tr span:eq(1)");

            // add second product
            I.Click(".liveExample button:eq(0)");
            I.Select(1).From(".liveExample tr select:eq(2)");
            I.Select(4).From(".liveExample tr select:eq(3)");
            I.Enter(8).In(".liveExample td.quantity input:eq(1)");
            I.Expect.Text("$788.64").In(".liveExample tr span:eq(3)");

            // validate totals
            I.Expect.Text("$986.34").In("p.grandTotal span");

            // remove first product
            I.Click(".liveExample a:eq(0)");

            // validate new total
            I.Wait(1);
            I.Expect.Text("$788.64").In("p.grandTotal span");
        }
    }
}
