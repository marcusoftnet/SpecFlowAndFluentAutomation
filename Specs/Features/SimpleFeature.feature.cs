﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Demonstrationer")]
    public partial class DemonstrationerFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SimpleFeature.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("sv-SE"), "Demonstrationer", "För att kunna visa hur man skulle kunna bygga automatisering av websidor\r\nSom en " +
                    "utvecklare\r\nVill jag ha några scenarion som jag kan dema med", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Öppna första sidan")]
        public virtual void OppnaForstaSidan()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Öppna första sidan", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("att jag är på hemsidan");
#line 8
 testRunner.Then("ska det finnas en länk för att skapa nytt lag där");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Skapa ett nytt lag")]
        public virtual void SkapaEttNyttLag()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Skapa ett nytt lag", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
 testRunner.Given("att det inte finns några lag i databasen");
#line 12
 testRunner.When("jag skapar ett nytt lag med namn \'Marcus United\'");
#line 13
 testRunner.Then("ska \'Marcus United\' listas bland lagen på hemsidan");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Skapa många nya lag")]
        [NUnit.Framework.TestCaseAttribute("Marcus United", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Emma Rockers", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Twins from heaven", new string[0])]
        public virtual void SkapaMangaNyaLag(string lagnamn, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Skapa många nya lag", exampleTags);
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("att det inte finns några lag i databasen");
#line 17
 testRunner.When(string.Format("jag skapar ett nytt lag med namn \'{0}\'", lagnamn));
#line 18
 testRunner.Then(string.Format("ska \'{0}\' listas bland lagen på hemsidan", lagnamn));
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ta bort ett lag")]
        public virtual void TaBortEttLag()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ta bort ett lag", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("att laget \'Marcus united\' finns i databasen");
#line 28
 testRunner.When("jag tar bort \'Marcus united\'");
#line 29
 testRunner.Then("ska inte \'Marcus united\' listas bland lagen på hemsidan");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion