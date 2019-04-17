using System;
using System.Collections.Generic;

namespace Reflexa
{
    class SpeechTemplate
    {
        protected static Random random = new Random();


        public static string GetWelcomeSpeech()
        {
            List<string> welcomeSpeeches = Core.speech.GetWelcomeSpeeches();
            return welcomeSpeeches[random.Next(welcomeSpeeches.Count)];
        }

        public static string GetShortHelpSpeech()
        {
            List<string> shortHelpSpeeches = Core.speech.GetShortHelpSpeeches();
            return shortHelpSpeeches[random.Next(shortHelpSpeeches.Count)];
        }

        public static string GetDetailedHelpSpeech()
        {
            List<string> detailedHelpSpeeches = Core.speech.GetDetailedHelpSpeeches();
            return detailedHelpSpeeches[random.Next(detailedHelpSpeeches.Count)];
        }

        public static string GetWhatWouldYouSpeech()
        {
            List<string> whatWouldYouSpeeches = Core.speech.GetWhatWouldYouSpeeches();
            return whatWouldYouSpeeches[random.Next(whatWouldYouSpeeches.Count)];
        }

        public static string GetWhatWouldYouNextSpeech()
        {
            List<string> whatWouldYouNextSpeeches = Core.speech.GetWhatWouldYouNextSpeeches();
            return whatWouldYouNextSpeeches[random.Next(whatWouldYouNextSpeeches.Count)];
        }

        public static string GetGoodbyeSpeech()
        {
            List<string> goodbyeSpeeches = Core.speech.GetGoodbyeSpeeches();
            return goodbyeSpeeches[random.Next(goodbyeSpeeches.Count)];
        }

        public static string GetExceptionSpeech()
        {
            List<string> exceptionSpeeches = Core.speech.GetExceptionSpeeches();
            return exceptionSpeeches[random.Next(exceptionSpeeches.Count)];
        }
    }
}
