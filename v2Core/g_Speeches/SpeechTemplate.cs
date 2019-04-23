using System;
using System.Collections.Generic;

namespace Reflexa
{
    class SpeechTemplate : Core
    {
        protected static Random random = new Random();


        public static string GetWelcomeSpeech()
        {
            List<string> welcomeSpeeches = Speech.GetWelcomeSpeeches();
            return welcomeSpeeches[random.Next(welcomeSpeeches.Count)];
        }

        public static string GetShortHelpSpeech()
        {
            List<string> shortHelpSpeeches = Speech.GetShortHelpSpeeches();
            return shortHelpSpeeches[random.Next(shortHelpSpeeches.Count)];
        }

        public static string GetDetailedHelpSpeech()
        {
            List<string> detailedHelpSpeeches = Speech.GetDetailedHelpSpeeches();
            return detailedHelpSpeeches[random.Next(detailedHelpSpeeches.Count)];
        }

        public static string GetWhatWouldYouSpeech()
        {
            List<string> whatWouldYouSpeeches = Speech.GetWhatWouldYouSpeeches();
            return whatWouldYouSpeeches[random.Next(whatWouldYouSpeeches.Count)];
        }

        public static string GetWhatWouldYouNextSpeech()
        {
            List<string> whatWouldYouNextSpeeches = Speech.GetWhatWouldYouNextSpeeches();
            return whatWouldYouNextSpeeches[random.Next(whatWouldYouNextSpeeches.Count)];
        }

        public static string GetGoodbyeSpeech()
        {
            List<string> goodbyeSpeeches = Speech.GetGoodbyeSpeeches();
            return goodbyeSpeeches[random.Next(goodbyeSpeeches.Count)];
        }

        public static string GetExceptionSpeech()
        {
            List<string> exceptionSpeeches = Speech.GetExceptionSpeeches();
            return exceptionSpeeches[random.Next(exceptionSpeeches.Count)];
        }
    }
}
