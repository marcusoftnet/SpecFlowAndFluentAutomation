using System;

namespace Specs.Automation
{
    public class CreateTeamPageWrapper : PageWrapperBase
    {
        public CreateTeamPageWrapper() : base("/Teams/Create") { }

        public void CreateTeam(string teamName, string city, DateTime founded)
        {
            // Go to page
             Visit();

            // Fill out form
            Browser.Enter(teamName).Quickly.In("input#Name");
            Browser.Enter(city).Quickly.In("input#City");
            Browser.Enter(founded.ToShortDateString()).Quickly.In("input#Founded");

            // Click create button
            Browser.Click("input#Create");
        }
    }
}
