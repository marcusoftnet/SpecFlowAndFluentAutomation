using System;
using System.IO;
using System.Reflection;
using Simple.Data;

namespace Specs.Automation
{
    public class DBWrapper
    {
        private static dynamic DB
        {
            get
            {
                var currentDir = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase.Substring(8)));
                var solutionDir = currentDir.Parent.Parent.Parent;
                var dbPath = solutionDir.FullName + @"\Web\App_Data\Teams.sdf";

                return Database.Opener.OpenFile(dbPath);
            }
        }
        
        public static void RemoveAllTeamsFromDatabase()
        {
            DB.Teams.DeleteAll();
        }

        public static void EmptyAllTestData()
        {
            RemoveAllTeamsFromDatabase();
        }

        public static void AddTeamToDatabase(string lagNamn)
        {
            DB.Teams.Insert(Name: lagNamn, City: "Stockholm", Founded: DateTime.Now);
        }
    }
}
