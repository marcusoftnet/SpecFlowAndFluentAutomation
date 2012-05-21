using FluentAutomation.API;
using FluentAutomation.API.Enumerations;
using NUnit.Framework;

namespace Specs
{
    [TestFixture]
    public class DemoFluentAutomationTests : FluentTest
    {
        private const string TESTURL = "http://localhost:49266/DemoPage.htm";

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
        public void find_text_within_div()
        {
            I.Expect.Text("Div by id").In("div#divById");
        }

        [Test]
        public void find_text_in_link_by_class()
        {
            I.Expect.Text("Marcusoft.Net - the coolest site on the net").In("a.aClassForThisLink");
        }

        [Test]
        public void should_navigate_by_link()
        {
            I.Click("a.aClassForThisLink");
            I.Expect.Url("http://www.marcusoft.net");
        }

        [Test]
        public void assert_only_one_h1_element_on_page_and_its_content()
        {
            I.Expect.Count(1).Of("h1");
            I.Expect.Text("Demo page for FluentAutomation selectors").In("h1");
        }

        [Test]
        public void should_assert_the_title_of_the_page()
        {
            I.Expect.Text("Demo page for FluentAutomation - the title").In("title");
        }

        [Test]
        public void should_select_second_option_in_selectbox()
        {
            // Select the second option in the select list
            I.Select(1).From("#selectBox1");

            // Check that the value has been set in the textbox
            // according to the script on the page
            I.Expect.Value("Value 2 - the special one").In("#txtSelectedOptionValue");
        }

        [Test]
        public void should_find_a_textbox_by_id()
        {
            // Write in textbox
            I.Enter("Text in textbox").In("#DemoTextbox");
            I.Enter("Text in textbox").In("input#DemoTextbox");
            I.Enter("Text in textbox").In("input[type='text'][id='DemoTextbox']");

            // Check value of textbox
            I.Expect.Value("Text in textbox").In("#DemoTextbox");
            I.Expect.Value("Text in textbox").In("input#DemoTextbox");
            I.Expect.Value("Text in textbox").In("input[type='text'][id='DemoTextbox']");
        }

        [Test]
        public void should_find_a_textbox_by_class_name()
        {
            // Write in textbox
            I.Enter("Text in textbox").In(".aSpecialClassNameForThisTextBox");

            // Check value of textbox
            I.Expect.Value("Text in textbox").In(".aSpecialClassNameForThisTextBox");
        }

        [Test]
        public void click_button()
        {
            I.Click("input#TestButton");
            I.Click("#TestButton");
            I.Click("input[type='button'][id='TestButton']");
        }

    }
}
