using System.Collections.Generic;

namespace Reflexa
{
    interface ISpeech
    {
        List<string> GetWelcomeSpeeches();
        List<string> GetWelcomeBackSpeeches();
        List<string> GetAskReviewSpeeches();

        List<string> GetShortHelpSpeeches();
        List<string> GetDetailedHelpSpeeches();
        List<string> GetAudioHelpSpeeches();
        List<string> GetVideoHelpSpeeches();
        List<string> GetWhatWouldYouSpeeches();

        List<string> GetPlaySpeeches();
        List<string> GetOkaySpeeches();
        List<string> GetNextSpeeches();
        List<string> GetNoNextSpeeches();
        List<string> GetPreviousSpeeches();
        List<string> GetNoPreviousSpeeches();
        List<string> GetResumeSpeeches();
        List<string> GetRepeatSpeeches();
        List<string> GetRandomSpeeches();
        List<string> GetStartOverSpeeches();
        List<string> GetShuffleOnSpeeches();
        List<string> GetShuffleOffSpeeches();
        List<string> GetLoopOnSpeeches();
        List<string> GetLoopOffSpeeches();

        List<string> GetFoundSpeeches();
        List<string> GetSelectSpeeches();
        List<string> GetNotFoundInputSpeeches();
        List<string> GetNotFoundOrdinalSpeeches();
        List<string> GetNotUnderstandSpeeches();
        List<string> GetTryAgainSpeeches();

        List<string> GetListSpeeches();
        List<string> GetMoreSpeeches();
        List<string> GetAllListSpeeches();

        List<string> GetPauseSpeeches();
        List<string> GetCancelSpeeches();
        List<string> GetGoodbyeSpeeches();

        List<string> GetForcedEndSpeeches();
        List<string> GetExceptionSpeeches();
    }
}
