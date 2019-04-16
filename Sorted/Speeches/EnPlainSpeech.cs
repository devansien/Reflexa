using System.Collections.Generic;

namespace Reflexa
{
    class EnPlainSpeech : ISpeech
    {
        private const string WelcomeA = "Welcome to Reflexa. ";

        private const string ShortHelpA = "Say anything you want, I will repeat whatever it is. ";
        private const string DetailedHelpA = "You can say anything you want for me to repeat. Otherwise, say stop or cancel to exit. ";
        private const string WhatWouldYouA = "What would you like to say? ";

        private const string GoodbyeA = "See you soon. Goodbye. ";
        private const string GoodbyeB = "Pleasure to meet you. Goodbye. ";

        private const string ExceptionA = "Sorry, something went wrong. Please try again later. ";
        private const string ExceptionB = "Sorry, something is not right. Please try again later. ";
        private const string ExceptionC = "Sorry, something must've happened. I suggest you to try again. ";


        public List<string> GetWelcomeSpeeches() { return new List<string> { WelcomeA }; }
        public List<string> GetShortHelpSpeeches() { return new List<string> { ShortHelpA, }; }
        public List<string> GetDetailedHelpSpeeches() { return new List<string> { DetailedHelpA }; }
        public List<string> GetWhatWouldYouSpeeches() { return new List<string> { WhatWouldYouA }; }
        public List<string> GetGoodbyeSpeeches() { return new List<string> { GoodbyeA, GoodbyeB }; }
        public List<string> GetExceptionSpeeches() { return new List<string> { ExceptionA, ExceptionB, ExceptionC }; }
    }
}
