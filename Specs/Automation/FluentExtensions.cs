using FluentAutomation.API;

namespace Specs.Automation
{
    public static class FluentExtensions
    {
        public static void WriteWait(this CommandManager I, string textToEnter, string textboxName)
        {
            I.Enter(textToEnter).In("input#" + textboxName);
        }

        public static void Write(this CommandManager I, string textToEnter, string textboxName)
        {
            I.Enter(textToEnter).Quickly.In("input#" + textboxName); 
        }
    }
}
