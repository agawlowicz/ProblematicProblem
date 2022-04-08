using System;
namespace ProblematicProblem
{
    public class BoolValues
    {
        public BoolValues()
        {
        }

        public static bool GetBoolValue(string s)
        {
            switch (s.ToLower())
            {
                case "yes":
                case "sure":
                case "redo": //redo means keep cont true so it runs again
                    return true;
                case "no":
                case "no thanks":
                case "keep": //keep stops the program so cont must be false
                    return false;
                default:
                    return true;
            }
        }
    }
}
