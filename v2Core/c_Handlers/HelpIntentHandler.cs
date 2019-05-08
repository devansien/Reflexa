using System.Threading.Tasks;

namespace Reflexa
{
    class HelpIntentHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.HelpIntent}", async () =>
            {
                Response.SetSpeech(false, false,
                    SpeechTemplate.GetDetailedHelpSpeech() + SpeechTemplate.GetWhatWouldYouSpeech(),
                    SpeechTemplate.GetShortHelpSpeech() + SpeechTemplate.GetWhatWouldYouSpeech());

                await Task.Run(() => { });
            });
        }
    }
}
