using System;
using System.IO;
using System.Reflection;
using Simple.Data;

namespace Specs.Automation
{
    public class DBWrapper
    {
        private const string DatabasePath = @"c:\Dev\WebAutomationWithSpecFlow\Web\App_Data\Teams.sdf";
        private static dynamic db = Database.Opener.OpenFile(DatabasePath);
        
        public static void RemoveAllTeamsFromDatabase()
        {
            db.Teams.DeleteAll();
        }

        public static void EmptyAllTestData()
        {
            RemoveAllTeamsFromDatabase();
        }

        public static void AddTeamToDatabase(string lagNamn)
        {
            db.Teams.Insert(Name: lagNamn, City: "Stockholm", Founded: DateTime.Now);
        }
    }
}
