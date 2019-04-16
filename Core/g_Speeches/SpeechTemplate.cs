using System;
using System.Collections.Generic;
using System.Text;

namespace Reflexa
{
    class SpeechTemplate
    {
        protected const string replaceTarget = "#";
        protected static Random random = new Random();


        public static string GetWelcomeSpeech()
        {
            List<string> welcomeSpeeches = Core.speech.GetWelcomeSpeeches();
            string welcomeSpeech = welcomeSpeeches[random.Next(welcomeSpeeches.Count)];

            int targetIndex = welcomeSpeech.IndexOf(replaceTarget);
            welcomeSpeech = welcomeSpeech.Remove(targetIndex, replaceTarget.Length).Insert(targetIndex, Core.skill.Title);

            return welcomeSpeech;
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


        public static string GetNotUnderstandSpeech()
        {
            List<string> notUnderstandSpeeches = Core.speech.GetNotUnderstandSpeeches();
            return notUnderstandSpeeches[random.Next(notUnderstandSpeeches.Count)];
        }

        public static string GetTryAgainSpeech()
        {
            List<string> tryAgainSpeeches = Core.speech.GetTryAgainSpeeches();
            return tryAgainSpeeches[random.Next(tryAgainSpeeches.Count)];
        }



        public static string GetGoodbyeSpeech()
        {
            List<string> goodbyeSpeeches = Core.speech.GetGoodbyeSpeeches();
            return goodbyeSpeeches[random.Next(goodbyeSpeeches.Count)];
        }

        public static string GetForceEndSpeech()
        {
            List<string> forceEndSpeeches = Core.speech.GetForcedEndSpeeches();
            return forceEndSpeeches[random.Next(forceEndSpeeches.Count)];
        }

        public static string GetExceptionSpeech()
        {
            List<string> exceptionSpeeches = Core.speech.GetExceptionSpeeches();
            return exceptionSpeeches[random.Next(exceptionSpeeches.Count)];
        }

        protected static int CountTargetString(string text)
        {
            int i = 0;
            int count = 0;

            while ((i = text.IndexOf(replaceTarget, i)) != -1)
            {
                i += replaceTarget.Length;
                count++;
            }

            return count;
        }
    }
}
