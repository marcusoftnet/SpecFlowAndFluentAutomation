using System;

namespace Specs.Automation
{
    public class TeamListingPageWrapper : PageWrapperBase
    {
        public TeamListingPageWrapper() : base("/") { }

        public void AssertTeamExistsInTeamList(string teamName)
        {
            Browser.Expect.Text(teamName).In("div#TeamName");
        }

        public void AssertCreateNewTeamLinkExists()
        {
            Browser.Expect.Text("Create New").In("a#NewLink");
        }

        public void DeleteTeam(string lagNamn)
        {
            // Gå till rätt sida
            Visit();

            // Hitta länken för Delete för detta lag
            Browser.Click("a#Delete" + lagNamn.Replace(" ", "_"));

            // Vänta på nästa 
            Browser.Wait(2);

            // Kontroller att man är på rätt sida
            Browser.Click("input#Delete");
        }

        public void TeamNameShouldNotExists(string teamName)
        {
            Visit();
            Browser.Expect.Count(0).Of("div#TeamName");
        }
    }
}
