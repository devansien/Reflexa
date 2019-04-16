using System.Collections.Generic;

namespace Reflexa
{
    interface ISpeech
    {
        List<string> GetWelcomeSpeeches();
        List<string> GetShortHelpSpeeches();
        List<string> GetDetailedHelpSpeeches();
        List<string> GetWhatWouldYouSpeeches();
        List<string> GetGoodbyeSpeeches();
        List<string> GetExceptionSpeeches();
    }
}
