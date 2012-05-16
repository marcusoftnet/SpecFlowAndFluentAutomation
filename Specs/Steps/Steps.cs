using System;
using Specs.Automation;
using Specs.Automation.PageWrappers;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    [Binding]
    public class Steps
    {
        private readonly TeamListingPageWrapper _teamListingPageWrapper = new TeamListingPageWrapper();
        private readonly CreateTeamPageWrapper _createTeamPageWrapper = new CreateTeamPageWrapper();

        [Given(@"att jag är på hemsidan")]
        public void GivetAttJagArPaHemsidan()
        {
            _teamListingPageWrapper.Visit();
        }

        [Then(@"ska det finnas en länk för att skapa nytt lag där")]
        public void SaSkaDetFinnasEnLankForAttSkapaNyLagDar()
        {
            _teamListingPageWrapper.AssertCreateNewTeamLinkExists();
        }
        
        [Given(@"att det inte finns några lag i databasen")]
        public void GivetAttDetInteFinnsNagraLagIDatabasen()
        {
            DBWrapper.RemoveAllTeamsFromDatabase();
        }

        [When(@"jag skapar ett nytt lag med namn '(.*)'")]
        public void CreateNewTeam(string teamName)
        {
            _createTeamPageWrapper.CreateTeam(teamName, "Stockholm", DateTime.Now);
        }

        [Then(@"ska '(.*)' listas bland lagen på hemsidan")]
        public void ListTeam(string teamName)
        {
            _teamListingPageWrapper.AssertTeamExistsInTeamList(teamName);
        }

        [Given(@"att laget '(.*)' finns i databasen")]
        public void Steg1(string lagNamn)
        {
            DBWrapper.AddTeamToDatabase(lagNamn);
        }

        [When(@"jag tar bort '(.*)'")]
        public void TarBortLagMedNamn(string lagNamn)
        {
            _teamListingPageWrapper.DeleteTeam(lagNamn);
        }

        [Then(@"ska inte '(.*)' listas bland lagen på hemsidan")]
        public void LagNamnSkaInteFinnas(string lagNamn)
        {
            _teamListingPageWrapper.TeamNameShouldNotExists(lagNamn);
        }




    }
}
