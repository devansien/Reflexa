using System.Collections.Generic;

namespace Reflexa
{
    class EnPlainSpeech : ISpeech
    {
        private const string WelcomeA = "Welcome to #. ";
        private const string WelcomeBackA = "Welcome back. ";
        private const string AskReviewA = "Sounds like you enjoy using #. Whenever you want, please search for # in your Alexa app, then select write a review. We always value your feedback. ";

        private const string ShortHelpA = "Say play, followed by name, or number of the recording. You can also say list, or random. ";
        private const string DetailedHelpA = "Say play, followed by name, or number of the recording. And also, you can simply say random to start an instant play. Otherwise, say list to find about the available recordings. ";
        private const string AudioHelpA = "While recording is playing, you can say cancel to go back to the main menu, say next, or previous, to switch between the recordings, or say random to play a random recording. ";
        private const string VideoHelpA = "While recording is playing, you can say previous to go back to the main menu, say stop to pause. Otherwise, say next, or previous, to switch between the recordings, or say random to play a random recording. ";
        private const string WhatWouldYouA = "What would you like to do? ";

        private const string PlayA = "Playing #. ";
        private const string OkayA = "No worries. ";
        private const string NextA = "Playing next recording, #. ";
        private const string NoNextA = "Next recording is not available. ";
        private const string PreviousA = "Playing previous recording, #. ";
        private const string NoPreviousA = "Previous recording is not available. ";
        private const string ResumeA = "Resume playing #. ";
        private const string NoResumeA = "Currently, there is no recording to resume. ";
        private const string RepeatA = "Repeating #. ";
        private const string RandomA = "Playing random recording, #. ";
        private const string StartOverA = "Playing from the first recording. #. ";
        private const string ShuffleOnA = "Shuffle mode on. ";
        private const string ShuffleOffA = "Shuffle mode off. ";
        private const string LoopOnA = "Single track loop mode on. ";
        private const string LoopOffA = "Single track loop mode off. ";

        private const string FoundA = "I have found # recordings matching #. ";
        private const string SelectA = "Say play, followed by name, or number of the recording. Which recording would you like to play? ";
        private const string NotFoundInputA = "I could not find any recordings matching #. Please say play, followed by a different name, or try saying list, more, random, help. ";
        private const string NotFoundOrdinalA = "I could not find the # recording. Try saying list, more, random, or help. ";
        private const string NotUnderstandA = "I didn't understand. ";

        private const string TryAgainA = "Please try again. ";
        private const string TryAgainB = "I suggest you to say help. ";
        private const string TryAgainC = "Try again with other commands like list, random, or help. ";
        private const string TryAgainD = "Perhaps, it's better for you to get some instructions by saying help. ";
        private const string TryAgainE = "I was unable to process your request. What about saying help? ";

        private const string ListA = "Here is the list of the first half recordings. # if you want to hear about more recordings, say more. Otherwise, say play, followed by name, or number of the recording. ";
        private const string MoreA = "Here are the rest of the recordings. # Say play, followed by name, or number of the recording. ";
        private const string AllA = "Here is the full list of the recordings. # Say play, followed by name, or number of the recording. ";
        //private const string AllA = "Here is the full list of the recordings. # Say play, followed by name, or number of the recording. If you want to hear again, say repeat. ";

        private const string PauseA = "Play paused. You can say next, or previous to change the current recording. Cancel to go back to the main menu. Otherwise, say resume to go back to the point where you left. ";
        private const string CancelA = "Going back to the main menu. ";

        private const string GoodbyeA = "Hope to see you soon. Goodbye. ";
        private const string GoodbyeB = "Pleasure to meet you. Goodbye. ";
        private const string GoodbyeC = "Thank you for using our skill. Goodbye. ";

        private const string ForceEndA = "Please try again later. Goodbye. ";
        private const string ForceEndB = "Please try again later, or restart the skill. Goodbye. ";

        private const string ExceptionA = "Sorry, something went wrong. Please try again later. ";
        private const string ExceptionB = "Sorry, something is not right. Please try again later. ";
        private const string ExceptionC = "Sorry, something must've happened. I suggest you to try again. ";
        private const string ExceptionD = "Sorry, something went wrong. If problem persists, please contact support. ";


        public List<string> GetWelcomeSpeeches() { return new List<string> { WelcomeA }; }
        public List<string> GetWelcomeBackSpeeches() { return new List<string> { WelcomeBackA }; }
        public List<string> GetAskReviewSpeeches() { return new List<string> { AskReviewA }; }

        public List<string> GetShortHelpSpeeches() { return new List<string> { ShortHelpA, }; }
        public List<string> GetDetailedHelpSpeeches() { return new List<string> { DetailedHelpA }; }
        public List<string> GetAudioHelpSpeeches() { return new List<string> { AudioHelpA }; }
        public List<string> GetVideoHelpSpeeches() { return new List<string> { VideoHelpA }; }
        public List<string> GetWhatWouldYouSpeeches() { return new List<string> { WhatWouldYouA }; }

        public List<string> GetPlaySpeeches() { return new List<string> { PlayA }; }
        public List<string> GetOkaySpeeches() { return new List<string> { OkayA }; }
        public List<string> GetNextSpeeches() { return new List<string> { NextA }; }
        public List<string> GetNoNextSpeeches() { return new List<string> { NoNextA }; }
        public List<string> GetPreviousSpeeches() { return new List<string> { PreviousA }; }
        public List<string> GetNoPreviousSpeeches() { return new List<string> { NoPreviousA }; }
        public List<string> GetResumeSpeeches() { return new List<string> { ResumeA }; }
        public List<string> GetRepeatSpeeches() { return new List<string> { RepeatA }; }
        public List<string> GetRandomSpeeches() { return new List<string> { RandomA }; }
        public List<string> GetStartOverSpeeches() { return new List<string> { StartOverA }; }
        public List<string> GetShuffleOnSpeeches() { return new List<string> { ShuffleOnA }; }
        public List<string> GetShuffleOffSpeeches() { return new List<string> { ShuffleOffA }; }
        public List<string> GetLoopOnSpeeches() { return new List<string> { LoopOnA }; }
        public List<string> GetLoopOffSpeeches() { return new List<string> { LoopOffA }; }

        public List<string> GetFoundSpeeches() { return new List<string> { FoundA }; }
        public List<string> GetSelectSpeeches() { return new List<string> { SelectA }; }
        public List<string> GetNotFoundInputSpeeches() { return new List<string> { NotFoundInputA }; }
        public List<string> GetNotFoundOrdinalSpeeches() { return new List<string> { NotFoundOrdinalA }; }

        public List<string> GetNotUnderstandSpeeches() { return new List<string> { NotUnderstandA }; }
        public List<string> GetTryAgainSpeeches() { return new List<string> { TryAgainA, TryAgainB, TryAgainC, TryAgainD, TryAgainE }; }

        public List<string> GetListSpeeches() { return new List<string> { ListA }; }
        public List<string> GetMoreSpeeches() { return new List<string> { MoreA }; }
        public List<string> GetAllListSpeeches() { return new List<string> { AllA }; }

        public List<string> GetPauseSpeeches() { return new List<string> { PauseA, }; }
        public List<string> GetCancelSpeeches() { return new List<string> { CancelA }; }
        public List<string> GetGoodbyeSpeeches() { return new List<string> { GoodbyeA, GoodbyeB, GoodbyeC }; }

        public List<string> GetForcedEndSpeeches() { return new List<string> { ForceEndA, ForceEndB }; }
        public List<string> GetExceptionSpeeches() { return new List<string> { ExceptionA, ExceptionB, ExceptionC, ExceptionD }; }
    }
}
