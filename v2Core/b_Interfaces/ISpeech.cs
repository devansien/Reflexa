using System.Collections.Generic;

namespace Reflexa
{
    public interface ISpeech
    {
        List<string> GetWelcomeSpeeches();
        List<string> GetShortHelpSpeeches();
        List<string> GetDetailedHelpSpeeches();
        List<string> GetWhatWouldYouSpeeches();
        List<string> GetWhatWouldYouNextSpeeches();
        List<string> GetGoodbyeSpeeches();
        List<string> GetExceptionSpeeches();
    }
}
